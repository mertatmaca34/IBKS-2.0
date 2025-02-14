using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete.API;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebAPI.Abstract;
using WebAPI.Enums;
using Core.Utilities.TempLogs;

[ApiController]
[Route("[controller]")]
public class SendDataController : ControllerBase, ISendDataController
{
    private readonly IApiService _apiManager;
    private readonly ILogin _login;

    public SendDataController(IApiService apiManager, ILogin login)
    {
        _apiManager = apiManager;
        _login = login;
    }

    [HttpPost]
    public async Task<IDataResult<ResultStatus<SendDataResult>>> SendData([FromBody] SendData data)
    {
        try
        {
            var apiData = _apiManager.Get();

            if(apiData.Data != null)
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(apiData.Data.ApiAdress);

                    var loginRes = await _login.Login(apiData.Data.UserName, apiData.Data.Password);

                    if (loginRes != null && loginRes.objects != null)
                    {
                        httpClient.DefaultRequestHeaders.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = loginRes.objects.TicketId.ToString() }));

                        var content = new StringContent(
                            JsonConvert.SerializeObject(data),
                            Encoding.UTF8,
                            "application/json");

                        var response = await httpClient.PostAsync(StationType.SAIS.ToString() + "/SendData", content);
                        response.EnsureSuccessStatusCode();

                        var responseContent = await response.Content.ReadAsStringAsync();

                        var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<SendDataResult>>(responseContent)!;

                        TempLog.Write(DateTime.Now + ": " + Messages.ApiSendDataSuccces);

                        return new SuccessDataResult<ResultStatus<SendDataResult>>(desResponseContent, Messages.ApiSendDataSuccces);
                    }
                    else
                    {
                        TempLog.Write(DateTime.Now + ": LoginRes or LoginRes.objects is null");
                        // Handle the case where loginRes or loginRes.objects is null
                        return new ErrorDataResult<ResultStatus<SendDataResult>>(null, "LoginRes or LoginRes.objects is null");
                    }
                }
            }
            else
            {
                return new ErrorDataResult<ResultStatus<SendDataResult>>(null, "LoginRes or LoginRes.objects is null");
            }
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
    public IEnumerable<SendData>? Get()
    {
        return null;
    }
}
