using BusinessLogicLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class HelperController : Controller
    {
        private readonly IModuleBL _moduleBL;

        public HelperController(IModuleBL moduleBL)
        {
            _moduleBL = moduleBL;
        }

        [HttpPost]
        public async Task<IActionResult> ConfigureBreadCrumb()
        {
            var res = await _moduleBL.GetBreadCrumbValue();
            return Ok(res);
        }
    }
}
