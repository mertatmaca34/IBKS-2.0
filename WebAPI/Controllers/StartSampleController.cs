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

        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public StartSampleController(ISampleService sampleManager)
        {
            _sampleManager = sampleManager;
        }

        [HttpGet(Name = "StartSample")]
        public ActionResult<ResultStatus> Get(Guid StationId, string Code)
        {
            _sharp7Service.StartSample();

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

            return new ResultStatus
            {
                result = true,
                message = "null",
                objects = true
            };
        }
    }
}
