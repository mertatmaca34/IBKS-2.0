using Entities.Concrete.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PLC.Sharp7.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class GetServerDateTimeController : ControllerBase
    {
        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        [HttpGet(Name = "GetServerDateTime")]
        public ActionResult<ResultStatus> GetServerDateTime(Guid StationId)
        {
            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = _sharp7Service.S71200.DB43.SystemTime
            };
        }
    }
}
