using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetInstantDataController : ControllerBase
    {
        readonly ISendDataService _sendDataManager;
        public GetInstantDataController(ISendDataService sendDataManager)
        {
            _sendDataManager = sendDataManager;
        }

        [HttpGet(Name = "GetInstantData")]
        public ActionResult<ResultStatus> Get(Guid StationId)
        {
            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = _sendDataManager.GetAll(x => x.Stationid == StationId).Data.LastOrDefault()!
            };
        }
    }
}
