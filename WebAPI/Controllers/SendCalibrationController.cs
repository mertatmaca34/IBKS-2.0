using Business.Abstract;
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
    [ApiController]
    [Route("[controller]")]
    public class SendCalibrationController : ControllerBase, ISendCalibrationController
    {
        private readonly IApiService _apiManager;
        private readonly ILogin _login;

        public SendCalibrationController(IApiService apiManager, ILogin login)
        {
            _apiManager = apiManager;
            _login = login;
        }

        [HttpPost]
        public async Task<IDataResult<ResultStatus>> SendCalibration([FromBody] SendCalibration data)
        {
            try
            {
                var apiData = _apiManager.Get();

                if (apiData.Data != null)
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        httpClient.BaseAddress = new Uri(apiData.Data.ApiAdress);

                        var loginRes = await _login.Login(apiData.Data.UserName, apiData.Data.Password);

                        if (loginRes != null && loginRes.objects != null)
                        {
                            httpClient.DefaultRequestHeaders.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = loginRes.objects.TicketId.ToString() }));

                            var content = new StringContent(
                                JsonConvert.SerializeObject(data),
                                Encoding.UTF8,
                                "application/json");

                            var response = await httpClient.PostAsync(StationType.SAIS.ToString() + "/SendCalibration", content);
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
                }
                else
                {
                    return new ErrorDataResult<ResultStatus>(null, "LoginRes or LoginRes.objects is null");
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
