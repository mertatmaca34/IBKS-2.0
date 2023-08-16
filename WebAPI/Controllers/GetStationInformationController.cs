using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetStationInformationController : ControllerBase
    {
        [HttpGet(Name = "GetStationInformation")]
        public ActionResult<ResultStatus> GetStationInformation(Guid StationId)
        {
            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = null!
            };
        }
    }
}
