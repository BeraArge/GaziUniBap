using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using BusinessLogicLayer.Helpers.SmsHelper;
using DataTransferObject.SmsModel;
using DataTransferObject.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.ApiControllers
{
    [Route("api/auth")]
    [ApiController]
    public class ApiAuthController : ControllerBase
    {
        private readonly IAuthBL _authBL;
        private readonly IUserBL _userBL;
        private readonly IOneTimePasswordService _oneTimePasswordService;
        public ApiAuthController(IAuthBL authBL, IUserBL userBL, IOneTimePasswordService oneTimePasswordService)
        {
            _authBL = authBL;
            _userBL = userBL;
            _oneTimePasswordService = oneTimePasswordService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO loginDTO)
        {
            var res = await _authBL.Login(loginDTO);
            return Ok(res);
        }


        [HttpPost("sifremi-unuttum")]
        public IActionResult SendSms([FromBody] SendSmsModel model)
        {
            var targets = new List<string>();
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
    }
}
