using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using DataTransferObject.CozumlemeSoruUser;
using DataTransferObject.User.Mobil;
using Microsoft.AspNetCore.Mvc;
using MSC.Extentions.ApiFilter;

namespace UI.ApiControllers
{
    [Route("api/cozumlemeSoruUser")]
    [ApiController]
    public class ApiCozumlemeSoruUserController : Controller
    {
        private readonly ICozumlemeSoruUserBL _cozumlemeSoruUserBL;

        public ApiCozumlemeSoruUserController(ICozumlemeSoruUserBL cozumlemeSoruUserBL)
        {
            _cozumlemeSoruUserBL = cozumlemeSoruUserBL;
        }
        [HttpPost("AddCozumlemeCevap")]
        [AuthorizeFilter]
        public IActionResult AddCozumlemeCevap([FromBody] CozumlemeSoruUserDTO model)
        {
            var res = _cozumlemeSoruUserBL.Add(model);
            return Ok(res);
        }
    }
}
