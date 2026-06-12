using BusinessLogicLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class SoruUserController : Controller
    {
        private readonly ISoruUserBL _soruUserBL;
        private readonly IWebHostEnvironment _env;

        public SoruUserController(ISoruUserBL soruUserBL, IWebHostEnvironment env)
        {
            _soruUserBL = soruUserBL;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetUserAnswerReports()
        {
            var res = _soruUserBL.GetUserAnswerReports();
            return Ok(res);
        }
    }
}
