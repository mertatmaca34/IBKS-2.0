using Business.Abstract;
using Entities.Concrete.API;
using Newtonsoft.Json;
using WebAPI.Abstract;

namespace WebAPI.Utils
{
    public class HttpClientAssign : IHttpClientAssign
    {
        public HttpClient? HttpClient { get; }

        readonly IApiService _apiManager;
        readonly ILogin _login;

        public HttpClientAssign(IApiService apiManager, ILogin login)
        {
            _apiManager = apiManager;
            _login = login;

            Assign().Wait();
        }

        public async Task Assign()
        {
            var apiData = _apiManager.Get();

            if (apiData.Success)
            {
                var apiBaseUrl = apiData.Data.ApiAdress;

                if (Constants.Constants.TicketId == null || Constants.Constants.TicketId.ToString() == "")
                {
                    Constants.Constants.HttpClient.BaseAddress = new Uri(apiBaseUrl);

                    var loginInfo = _apiManager.Get().Data;

                    await _login.Login(loginInfo.UserName, loginInfo.Password);

                    Constants.Constants.HttpClient.DefaultRequestHeaders.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = Constants.Constants.TicketId.ToString()! }));
                }
                else
                {
                    if (HttpClient?.DefaultRequestHeaders == null)
                    {
                        Constants.Constants.HttpClient.BaseAddress = new Uri(apiBaseUrl);
                        Constants.Constants.HttpClient.DefaultRequestHeaders.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = Constants.Constants.TicketId.ToString()! }));
                    }
                }
            }
        }

        public void AssignHttpClient()
        {
            
        }
    }
}
