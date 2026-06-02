using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.FluentValidationRules.User;
using Core.Cache.Microsoft;
using DataTransferObject.User;
using Microsoft.AspNetCore.Mvc;
using UI.Extensions;
using UI.Filters;
using Utility;
using Utility.Security.Encryption;

namespace UI.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IAuthBL _authBL;
        private readonly IWebHostEnvironment _environment;
        private readonly IMemoryService _memoryService;

        public AuthController(IAuthBL authBL, IWebHostEnvironment environment, IMemoryService memoryService)
        {
            _authBL = authBL;
            _environment = environment;
            _memoryService = memoryService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        //[Route("yonetim_paneli")]
        public IActionResult Login()
        {
            if (CheckUserLogin())
            {
                return RedirectToAction("Index", "Home");
            }
            UserLoginDTO userLoginDTO = new UserLoginDTO();
            return View(userLoginDTO);
        }

        [HttpPost, ValidateAntiForgeryToken]
        [ValidationFilter(typeof(UserLoginRules))]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO model)
        {
            var connectionString = Environment.GetEnvironmentVariable("MY_CONNECTION_STRING");
            var loginResult = await _authBL.Login(model);

            if (loginResult.IsSuccess)
            {
                ManageCookies(loginResult.Data);
                Functions.WriteMenu(loginResult.Data.AuthList, loginResult.Data.Id, _environment);
                Functions.WriteUserInformation(loginResult.Data, loginResult.Data.roleDTO, _environment);
            }
            return Ok(loginResult);
        }

        [HttpGet]
        public IActionResult Logout()
        {

            bool state = false;
            string authIdFromContext = Request.Cookies["AuthId"];
            if (!string.IsNullOrEmpty(authIdFromContext))
            {
                string decryptAuthId = EncryptionHelper.Decrypt(authIdFromContext);
                string redisKey = decryptAuthId.Split("-")[0];
                _authBL.ClearCache(redisKey);
                ClearCookies();
            }
            string user = HttpContext.Request.Cookies["vusername"];

            return Redirect("/Auth/login");
        }

        [HttpGet]
        public IActionResult AccessError()
        {
            return View();
        }

        [NonAction]
        public void ManageCookies(UserModel userModel)
        {
            Functions.CookieCreator("vusername", userModel.Phone, 24, Response);
            string authId = userModel.Phone + "." + userModel.Id + "-" + DateTime.Now.ToString("d");
            string encrypted_auth_id = EncryptionHelper.Encrypt(authId);
            Functions.CookieCreator("AuthId", encrypted_auth_id, 24, Response);
            int adminId = userModel.Id;
            var cryption = adminId.ToString() + "-" + DateTime.Now.ToString("d");
            var idEncryption = EncryptionHelper.Encrypt(cryption);
            Functions.CookieCreator("vid", idEncryption, 24, Response);
        }

        [NonAction]
        public void ClearCookies()
        {
            Functions.CookieCreator("vusername", "", -24, Response);
            Functions.CookieCreator("vid", "", -24, Response);
            Functions.CookieCreator("AuthId", "", -24, Response);
        }

        [NonAction]
        public bool CheckUserLogin()
        {
            string authIdFromContext = Request.Cookies["AuthId"];
            
            if (!string.IsNullOrEmpty(authIdFromContext))
            {
                string authId = EncryptionHelper.Decrypt(authIdFromContext);
                string permissions = _memoryService.Get<string>(authId.Split('-')[0]);
                if (!string.IsNullOrEmpty(permissions))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
