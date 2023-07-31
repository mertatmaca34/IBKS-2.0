using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebAPI.Utils;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://entegrationsais.csb.gov.tr";

        public LoginController()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(ApiBaseUrl) };
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

                return JsonConvert.DeserializeObject<ResultStatus<LoginResult>>(responseContent);

                /*var result = JsonConvert.DeserializeObject<LoginResult>(desResponseContent.objects.ToString());

                var ticketId = result.TicketId.ToString();*/

            }
            catch (HttpRequestException ex)
            {
                // İstisna durumları yönetme (isteğe göre yapılabilir)
                // Hata durumunda nasıl bir davranış sergileyeceğinize karar verin
                return new ResultStatus<LoginResult>();
            }
        }
    }
}
