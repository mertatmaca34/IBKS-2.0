using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetLogController : ControllerBase
    {
        [HttpGet(Name = "GetLog")]
        public ActionResult<ResultStatus> GetLog(Guid StationId, DateTime startDate, DateTime endDate)
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
