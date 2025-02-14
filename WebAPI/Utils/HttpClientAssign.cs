using Business.Abstract;
using Entities.Concrete.API;
using Newtonsoft.Json;
using WebAPI.Abstract;

namespace WebAPI.Utils
{
    public class HttpClientAssign : IHttpClientAssign
    {
        private readonly IApiService _apiManager;
        private readonly ILogin _login;

        public HttpClientAssign(IApiService apiManager, ILogin login)
        {
            _apiManager = apiManager;
            _login = login;
        }

        public async Task Assign()
        {
            Constants.Constants.HttpClient = new HttpClient();

            var apiData = _apiManager.Get();

            if (apiData == null || !apiData.Success || apiData.Data == null)
                throw new Exception("API bilgileri alınamadı");

            var apiBaseUrl = apiData.Data.ApiAdress;

            if (string.IsNullOrEmpty(apiBaseUrl))
                throw new Exception("API base URL boş.");

            // TicketId null kontrolü
            if (Constants.Constants.TicketId == null || string.IsNullOrEmpty(Constants.Constants.TicketId.ToString()))
            {
                Constants.Constants.HttpClient.BaseAddress = new Uri(apiBaseUrl);

                var loginInfo = apiData.Data;

                if (string.IsNullOrEmpty(loginInfo.UserName) || string.IsNullOrEmpty(loginInfo.Password))
                    throw new Exception("Login için kullanıcı adı veya şifre eksik.");

                var loginRes = await _login.Login(loginInfo.UserName, loginInfo.Password);

                if (loginRes == null || loginRes.objects == null)
                    throw new Exception("Login başarısız veya TicketId alınamadı.");

                Constants.Constants.TicketId = loginRes.objects.TicketId;

                Constants.Constants.HttpClient.DefaultRequestHeaders.Add("AToken",
                    JsonConvert.SerializeObject(new AToken { TicketId = Constants.Constants.TicketId.ToString() }));
            }
            else
            {
                if (Constants.Constants.HttpClient.DefaultRequestHeaders != null)
                {
                    Constants.Constants.HttpClient.BaseAddress = new Uri(apiBaseUrl);
                    Constants.Constants.HttpClient.DefaultRequestHeaders.Add("AToken",
                        JsonConvert.SerializeObject(new AToken { TicketId = Constants.Constants.TicketId.ToString() }));
                }
            }
        }

        public void AssignHttpClient()
        {
            // Gerekirse buraya başka ayarlar eklenebilir
        }
    }
}
