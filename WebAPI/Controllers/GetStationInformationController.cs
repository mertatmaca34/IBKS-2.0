using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
