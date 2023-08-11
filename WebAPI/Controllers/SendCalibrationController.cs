using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebAPI.Abstract;
using WebAPI.Enums;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendCalibrationController : ControllerBase, ISendCalibrationController
    {
        IHttpClientAssign _httpClientAssign;

        public SendCalibrationController(IHttpClientAssign httpClientAssign)
        {
            _httpClientAssign = httpClientAssign;
        }

        [HttpPost]
        public async Task<IDataResult<ResultStatus>> SendCalibration([FromBody] SendCalibration data)
        {
            try
            {
                _httpClientAssign.AssignHttpClient();

                if (Constants.Constants.TicketId != null)
                {
                    var content = new StringContent(
                        JsonConvert.SerializeObject(data),
                        Encoding.UTF8,
                        "application/json"
                    );

                    var response = await Constants.Constants.HttpClient.PostAsync(StationType.SAIS.ToString() + "/SendCalibration", content);

                    response.EnsureSuccessStatusCode();

                    var responseContent = await response.Content.ReadAsStringAsync();

                    var desResponseContent = JsonConvert.DeserializeObject<ResultStatus>(responseContent)!;

                    return new SuccessDataResult<ResultStatus>(desResponseContent, Messages.CalibrationSent);
                }
                else
                {
                    return new ErrorDataResult<ResultStatus>(null, Messages.ApiLoginFailed);
                }

            }
            catch (HttpRequestException)
            {
                return new ErrorDataResult<ResultStatus>(null, Messages.CalibrationNotSent);
            }
        }

        [HttpGet(Name = "SendCalibration")]
        public IEnumerable<SendCalibration>? Get()
        {
            return null;
        }
    }
}
