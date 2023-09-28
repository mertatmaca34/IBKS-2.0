using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        private readonly HttpClient _httpClient;

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

                // JSON verisini dönüştürme ve HTTP içeriği ayarlama
                var content = new StringContent(
                    JsonConvert.SerializeObject(login),
                    Encoding.UTF8,
                    "application/json"
                );

                // API'ye POST isteği gönderme
                var response = await _httpClient.PostAsync("/security/login", content);

                // İsteğin başarı durumunu kontrol edin (isteğe göre yapılabilir)
                response.EnsureSuccessStatusCode();

                // API'den dönen cevabı alın
                var responseContent = await response.Content.ReadAsStringAsync();

                var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<LoginResult>?>(responseContent);

                Constants.Constants.TicketId = desResponseContent?.objects.TicketId;

                return desResponseContent!;

                /*var result = JsonConvert.DeserializeObject<LoginResult>(desResponseContent.objects.ToString());

                var ticketId = result.TicketId.ToString();*/

            }
            catch (HttpRequestException)
            {
                // İstisna durumları yönetme (isteğe göre yapılabilir)
                // Hata durumunda nasıl bir davranış sergileyeceğinize karar verin
                return new ResultStatus<LoginResult>();
            }
        }
    }
}
