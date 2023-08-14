using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCalibrationController : ControllerBase
    {
        readonly ICalibrationService _calibrationManager;
        public GetCalibrationController(ICalibrationService calibrationManager)
        {
            _calibrationManager = calibrationManager;
        }

        [HttpGet(Name = "GetCalibration")]
        public ActionResult<ResultStatus> GetCalibration(Guid StationId, DateTime startDate, DateTime endDate)
        {
            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = _calibrationManager.GetAll(x => x.TimeStamp >= startDate && x.TimeStamp <= endDate).Data.ToList()!
            };
        }
    }
}
