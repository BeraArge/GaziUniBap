using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using BusinessLogicLayer.Helpers.SmsHelper;
using Core.ResultType;
using DataTransferObject.SmsModel;
using DataTransferObject.User;
using DataTransferObject.User.KullaniciIslemleri;
using Microsoft.AspNetCore.Mvc;
using MSC.Extentions.Filters;
using Utility.Security.Encryption;

namespace UI.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserBL _userBL;
        private readonly IAuthBL _authBL;
        private readonly IUserDetailBL _userDetailBL;
        private readonly IOneTimePasswordService _oneTimePasswordService;

        public UserController(IUserBL userBL, IUserDetailBL userDetailBL, IAuthBL authBL, IOneTimePasswordService oneTimePasswordService)
        {
            _userBL = userBL;
            _userDetailBL = userDetailBL;
            _authBL = authBL;
            _oneTimePasswordService = oneTimePasswordService;
        }
        [AuthorizeFilter]
        public IActionResult KullaniciIslemleri() => View();
        public IActionResult Profil()
        {
            var user = GetAdmin().Data;
            return View(user);
        }
        [HttpPost]
        public IActionResult UpdateProfile([FromBody] UserModel model)   //profil güncelliyoruz
        {
            var res = _userBL.UpdateDetailed(model);
            return Ok(res);
        }
        [HttpPost]
        public IActionResult UpdatePassword([FromBody] PasswordModel model)  //şifre güncelliyoruz
        {
            var userid = GetUserId();
            model.Id = userid;
            var res = _userBL.UpdatePasswordProfile(model);
            return Ok(res);
        }


        [HttpPost]
        public IActionResult SendSms([FromBody] SendSmsModel model)
        {
            var targets = new List<string>(); // Entegrasyondan liste şeklinde istendiği için liste olarak string yazıldı.
            var user = _userBL.GetByPhone(model);
            if (!user.IsSuccess)
            {
                return BadRequest(user.Message);
            }
            targets.Add(user.Data.Phone);
            string pass = _authBL.GeneratePassword();
            var sendOtp = _oneTimePasswordService.SendOtp(pass, targets).Result;
            _userBL.UpdatePasswordForSms(pass, user.Data.Id);
            return Ok();
        }
        [HttpGet]
        [AuthorizeFilter]
        public IActionResult Detail(int id)
        {
            ViewBag.UserId = id;
            return View();
        }

        [HttpGet]
        [AuthorizeFilter]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userBL.GetAllAsync();
            return Json(result);
        }

        [HttpGet]
        [AuthorizeFilter]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _userBL.GetByIdAsync(id);
            return Json(result);
        }

        [HttpPost]
        [AuthorizeFilter]
        public async Task<IActionResult> CreateUser([FromBody] UserCreateDto dto)
        {
            var result = await _userBL.CreateAsync(dto);
            return Json(result);
        }

        [HttpPost]
        [AuthorizeFilter]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateDto dto)
        {
            var result = await _userBL.UpdateAsync(dto);
            return Json(result);
        }

        [HttpPost]
        [AuthorizeFilter]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userBL.DeleteAsync(id);
            return Json(result);
        }

        [HttpPost]
        [AuthorizeFilter]
        public async Task<IActionResult> ResetPassword([FromBody] UserPasswordResetDto dto)
        {
            var result = await _userBL.ResetPasswordAsync(dto);
            return Json(result);
        }

        [NonAction]
        public Result<UserModel> GetAdmin()
        {
            string cookieValueFromContext = Request.Cookies["vid"];
            var idEncryption = EncryptionHelper.Decrypt(cookieValueFromContext);
            string myId = idEncryption.Split("-")[0];
            int id = int.Parse(myId);
            var admin = _userBL.GetById(id);
            return admin;
        }
    }
}
