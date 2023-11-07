using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class GetDataController : ControllerBase
    {
        readonly ISendDataService _sendDataManager;
        public GetDataController(ISendDataService sendDataManager)
        {
            _sendDataManager = sendDataManager;
        }

        [HttpGet(Name = "GetData")]
        public ActionResult<ResultStatus> GetData(Guid StationId, DateTime startDate, DateTime endDate, int Period)
        {
            var data = _sendDataManager.GetAll(x => x.Stationid == StationId && x.Readtime >= startDate && x.Readtime <= endDate).Data!;

            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = data
            };
        }
    }
}
