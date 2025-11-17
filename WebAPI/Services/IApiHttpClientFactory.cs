using System.Net.Http;

namespace WebAPI.Services
{
    /// <summary>
    /// Provides HttpClient instances that are configured with the external API base address
    /// and an up-to-date authentication ticket.
    /// </summary>
    public interface IApiHttpClientFactory
    {
        Task<HttpClient> CreateClientAsync(CancellationToken cancellationToken = default);
    }
}
