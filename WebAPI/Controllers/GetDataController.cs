using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDataController : ControllerBase
    {
        readonly ISendDataService _sendDataManager;
        public GetDataController(ISendDataService sendDataManager)
        {
            _sendDataManager = sendDataManager;
        }

        [HttpGet(Name = "GetData")]
        public ActionResult<ResultStatus> Get(Guid StationId, DateTime startDate, DateTime endDate, int Period)
        {
            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = _sendDataManager.GetAll(x => x.Stationid == StationId && x.Readtime >= startDate && x.Readtime <= endDate).Data.ToList()!
            };
        }
    }
}
