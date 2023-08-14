using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetLastDataController : ControllerBase
    {
        readonly ISendDataService _sendDataManager;
        public GetLastDataController(ISendDataService sendDataManager)
        {
            _sendDataManager = sendDataManager;
        }

        [HttpGet(Name = "GetData")]
        public ActionResult<ResultStatus> Get(Guid StationId)
        {
            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = _sendDataManager.GetAll(x => x.Stationid == StationId).Data.LastOrDefault()!.Readtime
            };
        }
    }
}
