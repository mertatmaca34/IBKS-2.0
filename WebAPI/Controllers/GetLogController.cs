using Entities.Concrete.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetLogController : ControllerBase
    {
        [HttpGet(Name = "GetLog")]
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
