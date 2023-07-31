using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using WebAPI.Enums;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendDataController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://entegrationsais.csb.gov.tr";

        readonly Task<ResultStatus<LoginResult>> _loginTask;

        public SendDataController()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(ApiBaseUrl) };

            _loginTask = new LoginController().Login("istanbul_pasakoy", "1q2w3e");
        }

        [HttpPost]
        public async Task<IDataResult<SendDataResult>> SendData([FromBody] SendData data)
        {
            try
            {
                // JSON verisini dönüştürme ve HTTP içeriği ayarlama
                var content = new StringContent(
                    JsonConvert.SerializeObject(data),
                    Encoding.UTF8,
                    "application/json"
                );

                // API'ye POST isteği gönderme
                _httpClient.BaseAddress = new Uri(ApiBaseUrl); // Set the base address
                _httpClient.DefaultRequestHeaders.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = Constants.Constants.TicketId.ToString()!}));

                var response = await _httpClient.PostAsync(StationType.SAIS.ToString() + "/SendData", content);

                // İsteğin başarı durumunu kontrol edin (isteğe göre yapılabilir)
                response.EnsureSuccessStatusCode();

                // API'den dönen cevabı alın
                var responseContent = await response.Content.ReadAsStringAsync();

                var desResponseContent = JsonConvert.DeserializeObject<SendDataResult>(responseContent);

                return new SuccessDataResult<SendDataResult>(desResponseContent,Messages.ApiSendDataSuccces);

            }
            catch (HttpRequestException ex)
            {
                // İstisna durumları yönetme (isteğe göre yapılabilir)
                // Hata durumunda nasıl bir davranış sergileyeceğinize karar verin
                return new ErrorDataResult<SendDataResult>(null,Messages.ApiSendDataFault);
            }
        }

        [HttpGet(Name = "GetSendData")]
        public IEnumerable<SendData> Get()
        {
            return null;
        }
    }
}
