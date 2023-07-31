using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendDataController : ControllerBase
    {
        private Guid? TicketId { get; set; }

        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://entegrationsais.csb.gov.tr";

        Task<ResultStatus<LoginResult>> _loginTask;

        public SendDataController()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(ApiBaseUrl) };

            _loginTask = new LoginController().Login("istanbul_pasakoy", "1q2w3e");
        }

        [HttpPost]
        public async Task<IActionResult> SendData([FromBody] SendData jsonData)
        {
            try
            {
                _loginTask.Result.objects.TicketId.ToString();

                // JSON verisini dönüştürme ve HTTP içeriği ayarlama
                var content = new StringContent(
                    JsonConvert.SerializeObject(jsonData),
                    Encoding.UTF8,
                    "application/json"
                );

                // API'ye POST isteği gönderme
                var response = await _httpClient.PostAsync("/SendData", content);

                // İsteğin başarı durumunu kontrol edin (isteğe göre yapılabilir)
                response.EnsureSuccessStatusCode();

                // API'den dönen cevabı alın
                var responseContent = await response.Content.ReadAsStringAsync();

                return Ok(responseContent);
            }
            catch (HttpRequestException ex)
            {
                // İstisna durumları yönetme (isteğe göre yapılabilir)
                // Hata durumunda nasıl bir davranış sergileyeceğinize karar verin
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(Name = "GetSendData")]
        public IEnumerable<SendData> Get()
        {
            return null;
        }
    }
}
