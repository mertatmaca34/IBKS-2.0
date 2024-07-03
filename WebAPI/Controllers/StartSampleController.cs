using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using PLC.Sharp7.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StartSampleController : ControllerBase
    {
        readonly ISampleService _sampleManager;
        readonly IPlcService _plcManager;

        public StartSampleController(ISampleService sampleManager, IPlcService plcManager)
        {
            _sampleManager = sampleManager;
            _plcManager = plcManager;
        }

        [HttpGet(Name = "StartSample")]
        public ActionResult<ResultStatus> Get(Guid StationId, string Code)
        {
            Sharp7Service sharp7Service = new Sharp7Service(_plcManager);

            sharp7Service.WriteToDB50();

            //sharp7Service.StartSample();

            Sample sample = new()
            {
                DateTime = DateTime.Now,
                SampleCode = Code,
                LastState = "Start",
                PlaceOfDelivery = "Tesis",
                Sampler = "Program",
                SampleType = "Uzaktan"
            };

            _sampleManager.Add(sample);

            sharp7Service.Disconnect();

            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = true
            };
        }
    }
}
