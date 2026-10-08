using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using DataTransferObject.SoruUser;
using DataTransferObject.User.Mobil;
using Microsoft.AspNetCore.Mvc;
using MSC.Extentions.ApiFilter;

namespace UI.ApiControllers
{
    [Route("api/soruUser")]
    [ApiController]
    public class ApiSoruUserController : Controller
    {
        private readonly ISoruUserBL _soruUserBL;

        public ApiSoruUserController(ISoruUserBL soruUserBL)
        {
            _soruUserBL = soruUserBL;
        }

        [HttpPost("add")]
        [AuthorizeFilter]
        public IActionResult AddBulk([FromBody] SoruUserBulkDTO model)
        {
            var res = _soruUserBL.Add(model);
            return Ok(res);
        }

        [HttpGet("GetCompetitionHome")]
        [AuthorizeFilter]
        public IActionResult GetCompetitionHome(int userId)
        {
            var res = _soruUserBL.GetMobileCompetitionHome(userId);
            return Ok(res);
        }
    }
}
