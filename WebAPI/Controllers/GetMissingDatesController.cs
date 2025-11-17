using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using WebAPI.Abstract;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class GetMissingDatesController : ControllerBase, IGetMissingDatesController
    {
        private readonly IApiHttpClientFactory _httpClientFactory;

        public GetMissingDatesController(IApiHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        public async Task<IDataResult<ResultStatus<MissingDate>>> GetMissingDates([FromQuery] Guid stationId)
        {
            try
            {
                var httpClient = await _httpClientFactory.CreateClientAsync();

                var url = $"SAIS/GetMissingDates?stationId={stationId:D}";
                using var response = await httpClient.PostAsync(url, new StringContent(string.Empty, Encoding.UTF8, "application/json"));
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return new ErrorDataResult<ResultStatus<MissingDate>>(null, $"HTTP {(int)response.StatusCode}: {responseContent}");

                var deserialized = JsonConvert.DeserializeObject<ResultStatus<MissingDate>>(responseContent)!;
                return new SuccessDataResult<ResultStatus<MissingDate>>(deserialized, Messages.ApiSendDataSuccces);
            }
            catch (HttpRequestException)
            {
                return new ErrorDataResult<ResultStatus<MissingDate>>(null, Messages.ApiSendDataFault);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ResultStatus<MissingDate>>(null, ex.Message);
            }
        }
    }
}
