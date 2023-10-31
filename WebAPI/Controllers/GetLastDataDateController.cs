using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class GetLastDataDateController : ControllerBase
    {
        readonly ISendDataService _sendDataManager;
        public GetLastDataDateController(ISendDataService sendDataManager)
        {
            _sendDataManager = sendDataManager;
        }

        [HttpGet(Name = "GetLastDataDate")]
        public ActionResult<ResultStatus> GetLastData(Guid StationId)
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
