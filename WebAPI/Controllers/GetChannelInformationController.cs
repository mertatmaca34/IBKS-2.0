using Entities.Concrete.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]

    public class GetChannelInformationController : ControllerBase
    {
        [HttpGet(Name = "GetChannelInformation")]
        public ActionResult<ResultStatus> GetChannelInformation(Guid StationId)
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