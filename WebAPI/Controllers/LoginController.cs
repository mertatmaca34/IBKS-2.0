using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using WebAPI.Abstract;
using WebAPI.Utils;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase, ILogin
    {
        private readonly IApiService _apiManager;
        private readonly IHttpClientFactory _httpClientFactory;

        public LoginController(IApiService apiManager, IHttpClientFactory httpClientFactory)
        {
            _apiManager = apiManager;
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        public async Task<ResultStatus<LoginResult>> Login([FromBody] string username, string password)
        {
            try
            {
                var apiData = _apiManager.Get();

                if (apiData?.Data == null || !apiData.Success)
                {
                    return new ResultStatus<LoginResult>
                    {
                        result = false,
                        message = "API bilgileri alınamadı."
                    };
                }

                if (string.IsNullOrWhiteSpace(apiData.Data.ApiAdress))
                {
                    return new ResultStatus<LoginResult>
                    {
                        result = false,
                        message = "API adresi tanımlı değil."
                    };
                }

                var httpClient = _httpClientFactory.CreateClient("ExternalApi");
                httpClient.BaseAddress = new Uri(apiData.Data.ApiAdress);
                httpClient.Timeout = TimeSpan.FromSeconds(30);

                var login = new Login
                {
                    username = username,
                    password = Hashing.MD5Hash(Hashing.MD5Hash(password))
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(login),
                    Encoding.UTF8,
                    "application/json"
                );

                using var response = await httpClient.PostAsync("/security/login", content);

                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<LoginResult>>(responseContent);

                return desResponseContent ?? new ResultStatus<LoginResult>();

            }
            catch (HttpRequestException)
            {
                return new ResultStatus<LoginResult>();
            }
        }
    }
}
