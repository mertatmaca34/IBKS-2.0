using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebAPI.Enums;
using WebAPI.Utils;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendCalibrationController : ControllerBase
    {
        readonly IApiService _apiManager;

        private readonly HttpClient _httpClient;

        private string _apiBaseUrl;

        public SendCalibrationController(IApiService apiManager)
        {
            _apiManager = apiManager;

            _httpClient = new HttpClient();
        }

        [HttpPost]
        public async Task<IDataResult<ResultStatus>> SendCalibration([FromBody] SendCalibration data)
        {
            try
            {
                var content = new StringContent(
                    JsonConvert.SerializeObject(data),
                    Encoding.UTF8,
                    "application/json"
                );

                var resAssign = Assigns.AssignHttpClient(_apiManager, _apiBaseUrl, _httpClient);

                if (resAssign.Success)
                {
                    var response = await _httpClient.PostAsync(StationType.SAIS.ToString() + "/SendCalibration", content);

                    response.EnsureSuccessStatusCode();

                    var responseContent = await response.Content.ReadAsStringAsync();

                    var desResponseContent = JsonConvert.DeserializeObject<ResultStatus>(responseContent)!;

                    return new SuccessDataResult<ResultStatus>(desResponseContent, Messages.ApiSendDataSuccces);
                }

                return new ErrorDataResult<ResultStatus>(null, Messages.ApiSendDataFault);
            }
            catch (HttpRequestException ex)
            {
                return new ErrorDataResult<ResultStatus>(null, Messages.ApiSendDataFault);
            }
        }

        [HttpGet(Name = "SendCalibration")]
        public IEnumerable<SendCalibration> Get()
        {
            return null;
        }
    }
}
