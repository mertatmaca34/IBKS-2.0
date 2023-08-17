using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebAPI.Abstract;
using WebAPI.Enums;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetMissingDatesController : ControllerBase, IGetMissingDatesController
    {
        readonly IHttpClientAssign _httpClientAssign;

        public GetMissingDatesController(IHttpClientAssign httpClientAssign)
        {
            _httpClientAssign = httpClientAssign;
        }

        [HttpPost]
        public async Task<IDataResult<ResultStatus>> GetMissingDates([FromBody] Guid stationId)
        {
            try
            {
                if (Constants.Constants.TicketId != null)
                {
                    var content = new StringContent(
                        JsonConvert.SerializeObject(stationId),
                        Encoding.UTF8,
                        "application/json"
                    );

                    var response = await Constants.Constants.HttpClient.PostAsync(StationType.SAIS.ToString() + "/GetMissingDates", content);

                    response.EnsureSuccessStatusCode();

                    var responseContent = await response.Content.ReadAsStringAsync();

                    var desResponseContent = JsonConvert.DeserializeObject<ResultStatus>(responseContent)!;

                    return new SuccessDataResult<ResultStatus>(desResponseContent, Messages.ApiSendDataSuccces);
                }
                else
                {
                    return new ErrorDataResult<ResultStatus>(null, Messages.ApiLoginFailed);
                }
            }
            catch (HttpRequestException)
            {
                return new ErrorDataResult<ResultStatus>(null, Messages.ApiSendDataFault);
            }
        }
    }
}
