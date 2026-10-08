using BusinessLogicLayer.Abstracts;
using DataTransferObject.OnBlgilendirme;
using Microsoft.AspNetCore.Mvc;
using MSC.Extentions.Filters;

namespace UI.Controllers
{
    public class OnBilgilendirmeController : Controller
    {
        private readonly IOnBilgilendirmeBL _onBilgilendirmeBL;

        public OnBilgilendirmeController(IOnBilgilendirmeBL onBilgilendirmeBL)
        {
            _onBilgilendirmeBL = onBilgilendirmeBL;
        }

        [HttpGet]
        [AuthorizeFilter]
        public IActionResult GetOnBilgilendirme()
        {
            var result = _onBilgilendirmeBL.GetOnBilgilendirme();
            return Ok(result);
        }
        [HttpPost]
        [AuthorizeFilter]
        public IActionResult SaveOnBilgilendirme([FromBody] OnBilgilendirmeDTO model)
        {
            var result = _onBilgilendirmeBL.Add(model);
            return Ok(result);
        }
    }
}
