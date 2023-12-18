using Business.Abstract;

namespace Business.Concrete
{
    public class HttpClientOperations : IHttpClientOperations
    {
        IApiService _apiManager;

        HttpClient _httpClient;

        public HttpClientOperations(HttpClient httpClient, IApiService apiService)
        {
            _httpClient = httpClient;
            _apiManager = apiService;

        }
        public void AssignBaseAddress()
        {
            var apiData = _apiManager.Get();

            if (apiData.Success)
            {
                var apiBaseUrl = apiData.Data.ApiAdress;

                _httpClient.BaseAddress = new Uri(apiBaseUrl);
            }
        }
    }
}
