using BusinessLogicLayer.Abstracts;
using DataTransferObject.SoruUser;
using Microsoft.AspNetCore.Mvc;
using MSC.Extentions.Filters;
using UI.Extensions;

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
        [AuthorizeFilter]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AuthorizeFilter]
        public IActionResult GetUserAnswerReports([FromQuery] UserAnswerReportRequestDTO request)
        {
            var res = _soruUserBL.GetUserAnswerReports(request);
            return Ok(res);
        }
        [HttpGet]
        [AuthorizeFilter]
        public IActionResult UserAnswerReportsExcel()
        {
            var result = _soruUserBL.GetUserAnswerExcelExportData();

            if (!result.IsSuccess || result.Data == null)
                return BadRequest(result.Message);
            ImageExtensions extension = new ImageExtensions(_env);

            var memoryStream = extension.UserAnswerReportsExcelDocument(result.Data);

            var fileName = $"Cevap_Raporlari_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

            return File(
                memoryStream,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileName
            );
        }
    }
}
