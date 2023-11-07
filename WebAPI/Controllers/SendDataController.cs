using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
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
    public class SendDataController : ControllerBase, ISendDataController
    {
        readonly IHttpClientAssign _httpClientAssign;

        public SendDataController(IHttpClientAssign httpClientAssign)
        {
            _httpClientAssign = httpClientAssign;
        }

        [HttpPost]
        public async Task<IDataResult<ResultStatus<SendDataResult>>> SendData([FromBody] SendData data)
        {
            try
            {
                if (Constants.Constants.TicketId != null)
                {
                    var content = new StringContent(
                        JsonConvert.SerializeObject(data),
                        Encoding.UTF8,
                        "application/json"
                    );

                    var response = await Constants.Constants.HttpClient.PostAsync(StationType.SAIS.ToString() + "/SendData", content);

                    response.EnsureSuccessStatusCode();

                    var responseContent = await response.Content.ReadAsStringAsync();

                    var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<SendDataResult>>(responseContent)!;

                    return new SuccessDataResult<ResultStatus<SendDataResult>>(desResponseContent, Messages.ApiSendDataSuccces);
                }
                else
                {
                    await _httpClientAssign.Assign();

                    return new ErrorDataResult<ResultStatus<SendDataResult>>(null, Messages.ApiLoginFailed);
                }
            }
            catch (HttpRequestException ex)
            {
                await _httpClientAssign.Assign();

                return new ErrorDataResult<ResultStatus<SendDataResult>>(null, Messages.ApiSendDataFault);
            }
            catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
            {
                await _httpClientAssign.Assign();

                return new ErrorDataResult<ResultStatus<SendDataResult>>(null, Messages.ApiSendDataFault);
            }
        }

        [HttpGet(Name = "GetSendData")]
        public IEnumerable<SendData>? Get()
        {
            return null;
        }
    }
}
