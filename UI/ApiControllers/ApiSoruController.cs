using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using DataTransferObject.User.KullaniciIslemleri;
using Microsoft.AspNetCore.Mvc;
using MSC.Extentions.ApiFilter;

namespace UI.ApiControllers
{
    [Route("api/soru")]
    [ApiController]
    public class ApiSoruController : Controller
    {
        private readonly ISoruBL _soruBL;

        public ApiSoruController(ISoruBL soruBL)
        {
            _soruBL = soruBL;
        }

        [HttpGet("GetAllSorus")]
        [AuthorizeFilter]
        public IActionResult GetAllSorus(int userId)
        {
            var res = _soruBL.GetMobileSorular(userId);
            return Ok(res);
        }
    }
}
