using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using DataTransferObject.SoruUser;
using DataTransferObject.User.Mobil;
using Microsoft.AspNetCore.Mvc;

namespace UI.ApiControllers
{
    [Route("api/soruUser")]
    [ApiController]
    public class ApiSoruUserController : Controller
    {
        private readonly ISoruUserBL _soruUserBL;

        public ApiSoruUserController(ISoruUserBL soruUserBL)
        {
            _soruUserBL = soruUserBL;
        }

        [HttpPost("update-profile")]
        public async Task<IActionResult> UpdateProfile(UpdateProfileDTO dto)
        {
            //var result = await _cozumlemeSoruUserBL.UpdateProfileAsync(dto);
            //return Ok(result);
            return Ok();
        }
        [HttpPost("add")]
        public IActionResult Cevapla([FromBody] SoruUserDTO model)
        {
            var res = _soruUserBL.Add(model);
            return Ok(res);
        }
        [HttpPost("update-password")]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordDTO dto)
        {
            //var result = await _cozumlemeSoruUserBL.UpdatePasswordAsync(dto);
            //return Ok(result);
            return Ok();
        }
        [HttpGet("GetCompetitionHome")]
        public IActionResult GetCompetitionHome(int userId)
        {
            var res = _soruUserBL.GetMobileCompetitionHome(userId);
            return Ok(res);
        }
    }
}
