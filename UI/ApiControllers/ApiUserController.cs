using BusinessLogicLayer.Abstracts;
using DataTransferObject.User.KullaniciIslemleri;
using DataTransferObject.User.Mobil;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.ApiControllers
{
    [Route("api/user")]
    [ApiController]
    public class ApiUserController : ControllerBase
    {
        private readonly IUserBL _userBL;
        public ApiUserController(IUserBL userBL)
        {
            _userBL = userBL;
        }
        [HttpPost("update-profile")]
        public async Task<IActionResult> UpdateProfile(UpdateProfileDTO dto)
        {
            var result = await _userBL.UpdateProfileAsync(dto);
            return Ok(result);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(UserCreateDto dto)
        {
            dto.RoleId = 2;
            var result = await _userBL.CreateAsync(dto);
            return Ok(result);
        }

        [HttpPost("update-password")]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordDTO dto)
        {
            var result = await _userBL.UpdatePasswordAsync(dto);
            return Ok(result);
        }
    }
}
