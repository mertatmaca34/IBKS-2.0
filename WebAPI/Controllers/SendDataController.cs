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
        public async Task<IDataResult<SendDataResult>> SendData([FromBody] SendData data)
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

                    var desResponseContent = JsonConvert.DeserializeObject<SendDataResult>(responseContent)!;

                    return new SuccessDataResult<SendDataResult>(desResponseContent, Messages.ApiSendDataSuccces);
                }
                else
                {
                    return new ErrorDataResult<SendDataResult>(null, Messages.ApiLoginFailed);
                }
            }
            catch (HttpRequestException)
            {
                return new ErrorDataResult<SendDataResult>(null, Messages.ApiSendDataFault);
            }
        }

        [HttpGet(Name = "GetSendData")]
        public IEnumerable<SendData>? Get()
        {
            return null;
        }
    }
}
