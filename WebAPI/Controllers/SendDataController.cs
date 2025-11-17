using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.TempLogs;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using WebAPI;
using WebAPI.Abstract;
using WebAPI.Enums;
using WebAPI.Services;

[ApiController]
[Route("[controller]")]
public class SendDataController : ControllerBase, ISendDataController
{
    private readonly IApiHttpClientFactory _httpClientFactory;

    public SendDataController(IApiHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpPost]
    public async Task<IDataResult<ResultStatus<SendDataResult>>> SendData([FromBody] SendData data)
    {
        try
        {
            var httpClient = await _httpClientFactory.CreateClientAsync();

            var content = new StringContent(
                JsonConvert.SerializeObject(data),
                Encoding.UTF8,
                "application/json");

            var response = await httpClient.PostAsync(StationType.SAIS + "/SendData", content);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                TempLog.Write(DateTime.Now + ": Hata kodu:" + response.StatusCode);
                return new ErrorDataResult<ResultStatus<SendDataResult>>(null, Messages.ApiSendDataFault);
            }

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                TempLog.Write(DateTime.Now + ": Hata kodu:" + response.StatusCode);
                return new ErrorDataResult<ResultStatus<SendDataResult>>(null, Messages.ApiSendDataFault);
            }

            var responseContent = await response.Content.ReadAsStringAsync();

            var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<SendDataResult>>(responseContent)!;

            if (desResponseContent.message == "Bu saatin datası daha önce kayıt edilmiştir.")
            {
                return new SuccessDataResult<ResultStatus<SendDataResult>>(desResponseContent, "zaten kayıtlı");
            }

            return new SuccessDataResult<ResultStatus<SendDataResult>>(desResponseContent, Messages.ApiSendDataSuccces);
        }
        catch (HttpRequestException ex)
        {
            TempLog.Write(DateTime.Now + ": " + ex.Message);
            return new ErrorDataResult<ResultStatus<SendDataResult>>(null, Messages.ApiSendDataFault);
        }
        catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
        {
            TempLog.Write(DateTime.Now + ": " + ex.Message);
            return new ErrorDataResult<ResultStatus<SendDataResult>>(null, Messages.ApiSendDataFault);
        }
        catch (Exception ex)
        {
            TempLog.Write(DateTime.Now + ": An unexpected error occurred - " + ex.Message);
            return new ErrorDataResult<ResultStatus<SendDataResult>>(null, "An unexpected error occurred");
        }
    }

    [HttpGet(Name = "GetSendData")]
    public IEnumerable<SendData>? Get(DateTime start, DateTime end)
    {
        ISendDataService _sendDataManager = Program.Services.GetRequiredService<ISendDataService>();

        return _sendDataManager.GetAll(x => x.Readtime > start && x.Readtime < end).Data;
    }
}
