using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPowerOffTimesController : ControllerBase
    {
        [HttpGet(Name = "GetPowerOffTimes")]
        public ActionResult<ResultStatus> Get(Guid StationId, DateTime startDate, DateTime endDate)
        {
            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = null
            };
        }
    }
}
