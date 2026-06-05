using BusinessLogicLayer.Abstracts;
using DataTransferObject.Soru;
using Microsoft.AspNetCore.Mvc;
using UI.Extensions;
using UI.Filters;

namespace UI.Controllers
{
    public class SoruController : Controller
    {
        private readonly ISoruBL _soruBL;
        private readonly IWebHostEnvironment _env;


        public SoruController(ISoruBL soruBL, IWebHostEnvironment env)
        {
            _soruBL = soruBL;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SoruGetAll()
        {
            var res = _soruBL.GetAll();
            return Ok(res);
        }

        [HttpPost, ValidateAntiForgeryToken]
        //[AuthorizeFilter]
        public async Task<IActionResult> AddSoru([FromForm] SoruDTO Soru)
        {
            ImageExtensions image = new(_env);
            if (Soru.VideoFile != null)
            {
                var file = await image.FileUpload(Soru.VideoFile, "videos");
                Soru.VideoPath = file.address;
            }

            var res = _soruBL.Add(Soru);
            return Ok(res);
        }
    }
}
