using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using DataTransferObject.CozumlemeSoruUser;
using DataTransferObject.User.Mobil;
using Microsoft.AspNetCore.Mvc;

namespace UI.ApiControllers
{
    [Route("api/cozumlemeSoruUser")]
    [ApiController]
    public class ApiCozumlemeSoruUserController : Controller
    {
        private readonly ICozumlemeSoruUserBL _cozumlemeSoruUserBL;

        public ApiCozumlemeSoruUserController(ICozumlemeSoruUserBL cozumlemeSoruUserBL)
        {
            _cozumlemeSoruUserBL = cozumlemeSoruUserBL;
        }
        [HttpPost("AddCozumlemeCevap")]
        public IActionResult AddCozumlemeCevap([FromBody] CozumlemeSoruUserDTO model)
        {
            var res = _cozumlemeSoruUserBL.Add(model);
            return Ok(res);
        }
        [HttpPost("update-profile")]
        public async Task<IActionResult> UpdateProfile(UpdateProfileDTO dto)
        {
            //var result = await _cozumlemeSoruUserBL.UpdateProfileAsync(dto);
            //return Ok(result);
            return Ok();
        }

        [HttpPost("update-password")]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordDTO dto)
        {
            //var result = await _cozumlemeSoruUserBL.UpdatePasswordAsync(dto);
            //return Ok(result);
            return Ok();
        }
    }
}
