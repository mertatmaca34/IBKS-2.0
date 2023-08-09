using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebAPI.Abstract;
using WebAPI.Enums;
using WebAPI.Utils;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendDataController : ControllerBase
    {
        readonly IApiService _apiManager;

        private readonly HttpClient _httpClient;

        private readonly string? _apiBaseUrl;

        readonly ILogin _login;

        public SendDataController(IApiService apiManager, ILogin login)
        {
            _apiManager = apiManager;

            _httpClient = new HttpClient();

            _login = login;

            var loginInfo = _apiManager.Get();

            _login.Login(loginInfo.Data.UserName, loginInfo.Data.Password);
        }

        [HttpPost]
        public async Task<IDataResult<SendDataResult>> SendData([FromBody] SendData data)
        {
            try
            {
                if (Constants.Constants.TicketId == null)
                {
                    var loginInfo = _apiManager.Get();

                    _login.Login(loginInfo.Data.UserName, loginInfo.Data.Password);
                }

                var content = new StringContent(
                    JsonConvert.SerializeObject(data),
                    Encoding.UTF8,
                    "application/json"
                );

                var resAssign = Assigns.AssignHttpClient(_apiManager, _apiBaseUrl, _httpClient);

                if (resAssign.Success)
                {
                    var response = await _httpClient.PostAsync(StationType.SAIS.ToString() + "/SendData", content);

                    response.EnsureSuccessStatusCode();

                    var responseContent = await response.Content.ReadAsStringAsync();

                    var desResponseContent = JsonConvert.DeserializeObject<SendDataResult>(responseContent)!;

                    return new SuccessDataResult<SendDataResult>(desResponseContent, Messages.ApiSendDataSuccces);
                }

                return new ErrorDataResult<SendDataResult>(null, Messages.ApiSendDataFault);
            }
            catch (HttpRequestException ex)
            {
                 return new ErrorDataResult<SendDataResult>(null, Messages.ApiSendDataFault);
            }
        }

        [HttpGet(Name = "GetSendData")]
        public IEnumerable<SendData> Get()
        {
            return null;
        }
    }
}
