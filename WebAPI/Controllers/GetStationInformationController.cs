using Entities.Concrete.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
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
