using BusinessLogicLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;
using MSC.Extentions.ApiFilter;

namespace UI.ApiControllers
{
    [Route("api/onBilgilendirme")]
    [ApiController]
    public class ApiOnBilgilendirmeController : Controller
    {
        private readonly IOnBilgilendirmeBL _onBilgilendirmeBL;

        public ApiOnBilgilendirmeController(IOnBilgilendirmeBL onBilgilendirmeBL)
        {
            _onBilgilendirmeBL = onBilgilendirmeBL;
        }

        [HttpGet("GetOnBilgilendirmeForMobile")]
        [AuthorizeFilter]
        public IActionResult GetOnBilgilendirmeForMobile()
        {
            var result = _onBilgilendirmeBL.GetOnBilgilendirme();
            return Ok(result);
        }
    }
}
