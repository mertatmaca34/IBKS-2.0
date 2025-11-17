using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using WebAPI.Abstract;
using WebAPI.Enums;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendCalibrationController : ControllerBase, ISendCalibrationController
    {
        private readonly IApiHttpClientFactory _httpClientFactory;
        private readonly ICalibrationService _calibrationManager;

        public SendCalibrationController(IApiHttpClientFactory httpClientFactory, ICalibrationService calibrationManager)
        {
            _httpClientFactory = httpClientFactory;
            _calibrationManager = calibrationManager;
        }

        [HttpPost]
        public async Task<IDataResult<ResultStatus>> SendCalibration([FromBody] SendCalibration data)
        {
            try
            {
                var httpClient = await _httpClientFactory.CreateClientAsync();

                var content = new StringContent(
                    JsonConvert.SerializeObject(data),
                    Encoding.UTF8,
                    "application/json");

                var response = await httpClient.PostAsync(StationType.SAIS + "/SendCalibration", content);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                var desResponseContent = JsonConvert.DeserializeObject<ResultStatus>(responseContent)!;

                return new SuccessDataResult<ResultStatus>(desResponseContent, Messages.CalibrationSent);
            }
            catch (HttpRequestException)
            {
                return new ErrorDataResult<ResultStatus>(null, Messages.CalibrationNotSent);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ResultStatus>(null, ex.Message);
            }
        }

        [HttpGet(Name = "SendCalibration")]
        public IEnumerable<Calibration>? Get(DateTime start, DateTime end)
        {
            return _calibrationManager.GetByDateTime(start, end).Data;
        }
    }
}
