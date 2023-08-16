using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
