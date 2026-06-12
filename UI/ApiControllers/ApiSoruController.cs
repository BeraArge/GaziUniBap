using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using DataTransferObject.User.KullaniciIslemleri;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAllSorus()
        {
            var result = _soruBL.GetAll();
            return Ok(result);
        }
    }
}
