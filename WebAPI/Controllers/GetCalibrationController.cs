using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
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
            var calibrations = _calibrationManager.GetAll(x => x.TimeStamp >= startDate && x.TimeStamp <= endDate).Data.ToList();

            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = calibrations
            };
        }
    }
}
