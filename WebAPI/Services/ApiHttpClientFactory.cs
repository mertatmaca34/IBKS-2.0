using System.Net.Http;
using System.Threading;
using Business.Abstract;
using Entities.Concrete.API;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using WebAPI.Abstract;

namespace WebAPI.Services
{
    public class ApiHttpClientFactory : IApiHttpClientFactory
    {
        private const string TicketCacheKey = "ExternalApiTicket";

        private static readonly SemaphoreSlim TicketSemaphore = new(1, 1);

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IApiService _apiService;
        private readonly ILogin _login;
        private readonly IMemoryCache _cache;

        public ApiHttpClientFactory(
            IHttpClientFactory httpClientFactory,
            IApiService apiService,
            ILogin login,
            IMemoryCache cache)
        {
            _httpClientFactory = httpClientFactory;
            _apiService = apiService;
            _login = login;
            _cache = cache;
        }

        public async Task<HttpClient> CreateClientAsync(CancellationToken cancellationToken = default)
        {
            var apiData = _apiService.Get();

            if (apiData?.Data == null || !apiData.Success)
                throw new InvalidOperationException("API bilgileri alınamadı.");

            if (string.IsNullOrWhiteSpace(apiData.Data.ApiAdress))
                throw new InvalidOperationException("API adresi boş olamaz.");

            var httpClient = _httpClientFactory.CreateClient("ExternalApi");
            httpClient.BaseAddress = new Uri(apiData.Data.ApiAdress);

            var ticket = await EnsureTicketAsync(
                apiData.Data.UserName,
                apiData.Data.Password,
                cancellationToken);

            httpClient.DefaultRequestHeaders.Remove("AToken");
            httpClient.DefaultRequestHeaders.Add(
                "AToken",
                JsonConvert.SerializeObject(new AToken { TicketId = ticket.TicketId }));

            return httpClient;
        }

        private async Task<TicketInfo> EnsureTicketAsync(
            string? username,
            string? password,
            CancellationToken cancellationToken)
        {
            if (TryGetValidTicket(out var cachedTicket))
            {
                return cachedTicket!;
            }

            await TicketSemaphore.WaitAsync(cancellationToken);

            try
            {
                if (TryGetValidTicket(out cachedTicket))
                {
                    return cachedTicket!;
                }

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                    throw new InvalidOperationException("API kullanıcı bilgileri eksik.");

                var loginResult = await _login.Login(username, password);

                if (loginResult?.objects?.TicketId == null)
                    throw new InvalidOperationException("TicketId alınamadı.");

                var ticket = new TicketInfo
                {
                    TicketId = loginResult.objects.TicketId.Value,
                    ExpiresAt = DateTimeOffset.UtcNow.AddMinutes(30)
                };

                _cache.Set(TicketCacheKey, ticket, ticket.ExpiresAt);

                return ticket;
            }
            finally
            {
                TicketSemaphore.Release();
            }
        }

        private bool TryGetValidTicket(out TicketInfo? ticket)
        {
            if (_cache.TryGetValue<TicketInfo>(TicketCacheKey, out ticket))
            {
                if (ticket!.ExpiresAt > DateTimeOffset.UtcNow)
                {
                    return true;
                }

                _cache.Remove(TicketCacheKey);
                ticket = null;
            }

            return false;
        }

        private sealed class TicketInfo
        {
            public Guid? TicketId { get; set; }
            public DateTimeOffset ExpiresAt { get; set; }
        }
    }
}
