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
        private readonly HttpClient? _httpClient;

        public LoginController(IApiService apiManager)
        {
            _apiManager = apiManager;

            if (_apiManager.Get().Success)
            {
                string apiBaseUrl = _apiManager.Get().Data.ApiAdress;

                _httpClient = new HttpClient { BaseAddress = new Uri(apiBaseUrl) };
                _httpClient.Timeout = TimeSpan.FromSeconds(15);
            }
        }

        [HttpPost]
        public async Task<ResultStatus<LoginResult>> Login([FromBody] string username, string password)
        {
            try
            {
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

                _httpClient?.Timeout.Add(TimeSpan.FromSeconds(15));

                var response = await _httpClient.PostAsync("/security/login", content);
                
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<LoginResult>?>(responseContent);

                Constants.Constants.TicketId = desResponseContent?.objects.TicketId;

                return desResponseContent!;

            }
            catch (HttpRequestException)
            {
                return new ResultStatus<LoginResult>();
            }
        }
    }
}
