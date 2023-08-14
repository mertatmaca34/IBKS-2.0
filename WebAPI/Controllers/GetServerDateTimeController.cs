using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using PLC.Sharp7.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetServerDateTimeController : ControllerBase
    {
        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        [HttpGet(Name = "GetServerDateTime")]
        public ActionResult<ResultStatus> Get()
        {
            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = _sharp7Service.S71200.DB4.SystemTime
            };
        }
    }
}
