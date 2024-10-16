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
            Assign().Wait(); // Burada async-await kullanımı uygun değil
        }

        public async Task Assign()
        {
            Constants.Constants.HttpClient = new HttpClient();

            var apiData = _apiManager.Get();

            if (apiData.Success)
            {
                var apiBaseUrl = apiData.Data.ApiAdress;

                if (string.IsNullOrEmpty(Constants.Constants.TicketId.ToString()))
                {
                    Constants.Constants.HttpClient.BaseAddress = new Uri(apiBaseUrl);

                    var loginInfo = _apiManager.Get().Data;

                    var loginRes = await _login.Login(loginInfo.UserName, loginInfo.Password);

                    Constants.Constants.TicketId = loginRes.objects.TicketId;

                    Constants.Constants.HttpClient.DefaultRequestHeaders.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = Constants.Constants.TicketId.ToString() }));
                }
                else
                {
                    if (Constants.Constants.HttpClient.DefaultRequestHeaders != null)
                    {
                        Constants.Constants.HttpClient.BaseAddress = new Uri(apiBaseUrl);
                        Constants.Constants.HttpClient.DefaultRequestHeaders.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = Constants.Constants.TicketId.ToString() }));
                    }
                }
            }
        }

        public void AssignHttpClient()
        {
            // AssignHttpClient metodu için implementasyon
        }
    }
}