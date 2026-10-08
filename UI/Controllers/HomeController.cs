using BusinessLogicLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MSC.Extentions.Filters;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISoruUserBL _soruUserBL;

        public HomeController(ILogger<HomeController> logger, ISoruUserBL soruUserBL)
        {
            _logger = logger;
            _soruUserBL = soruUserBL;
        }

        [AuthorizeFilter]
        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        [AuthorizeFilter]
        public IActionResult GetDashboardData()
        {
            var res = _soruUserBL.GetDashboardData();
            return Ok(res);
        }
    }
}