using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebAPI.Abstract;
using WebAPI.Enums;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class GetMissingDatesController : ControllerBase, IGetMissingDatesController
    {
        private readonly IApiService _apiManager;
        private readonly ILogin _login;


        public GetMissingDatesController(IApiService apiManager, ILogin login)
        {
            _apiManager = apiManager;
            _login = login;
        }

        [HttpPost]
        public async Task<IDataResult<ResultStatus<MissingDate>>> GetMissingDates([FromQuery] Guid stationId)
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

                            var url = $"SAIS/GetMissingDates?stationId={stationId:D}";

                            using var response = await httpClient.PostAsync(url, new StringContent(string.Empty, Encoding.UTF8, "application/json"));
                            var responseContent = await response.Content.ReadAsStringAsync();

                            if (!response.IsSuccessStatusCode)
                                return new ErrorDataResult<ResultStatus<MissingDate>>(null, $"HTTP {(int)response.StatusCode}: {responseContent}");

                            var deserialized = JsonConvert.DeserializeObject<ResultStatus<MissingDate>>(responseContent)!;
                            return new SuccessDataResult<ResultStatus<MissingDate>>(deserialized, Messages.ApiSendDataSuccces);
                        }
                        else
                        {
                            return new ErrorDataResult<ResultStatus<MissingDate>>(null, Messages.ApiLoginFailed);
                        }
                    }
                }
                else
                {
                    return new ErrorDataResult<ResultStatus<MissingDate>>(null, "LoginRes or LoginRes.objects is null");

                }
            }
            catch (HttpRequestException)
            {
                return new ErrorDataResult<ResultStatus<MissingDate>>(null, Messages.ApiSendDataFault);
            }
        }
    }
}
