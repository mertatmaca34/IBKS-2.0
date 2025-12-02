using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using WebAPI.Enums;
using WebAPI.Utils;

namespace WebAPI.Infrastructure.RemoteApi;

public class RemoteApiClient(IApiService apiService) : IRemoteApiClient
{
    public AToken Token = new();
    public HttpClient httpClient = new();

    public StringContent PrepareStringContent(object data)
    {
        return new StringContent(
            JsonConvert.SerializeObject(data),
            Encoding.UTF8,
            "application/json"
        );
    }

    private async Task SetValidTicketAsync()
    {
        if (Token.Expiration > DateTime.Now.AddMinutes(5))
        {
            return;
        }

        var res = await Login();

        if (res.result)
        {
            httpClient.DefaultRequestHeaders.Remove("AToken");
            httpClient.DefaultRequestHeaders.Add(
                "AToken",
                JsonConvert.SerializeObject(new AToken { TicketId = res.objects.TicketId }));
        }
        else
        {
            throw new Exception(res.message);
        }
    }

    public async Task<ResultStatus<T>> PostData<T>(object data, string url)
    {
        var content = PrepareStringContent(data);

        await SetValidTicketAsync();

        var response = await httpClient.PostAsync(StationType.SAIS + url, content);

        if (response.StatusCode != HttpStatusCode.OK)
        {
            await SetValidTicketAsync();

            response.Dispose();

            response = await httpClient.PostAsync(StationType.SAIS + url, content);
        }
        else if (response.StatusCode == HttpStatusCode.Conflict)
        {
            return new ResultStatus<T>
            {
                result = false,
                message = "Bu saatin datası daha önce kayıt edilmiştir.",
            };
        }

        var responseContent = await response.Content.ReadAsStringAsync();

        var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<T>>(responseContent)!;

        return desResponseContent;
    }

    public async Task<ResultStatus<SendDataResult>> SendData(SendData data) => await PostData<SendDataResult>(data, "/SendData");

    public async Task<ResultStatus<SendCalibrationResult>> SendCalibration(SendCalibration data) => await PostData<SendCalibrationResult>(data, "/SendCalibration");

    public async Task<ResultStatus<LoginResult>> Login()
    {
        var resApiService = apiService.Get();

        if (resApiService.Success && resApiService.Data != null)
        {
            var login = new Login
            {
                username = resApiService.Data.UserName,
                password = Hashing.MD5Hash(Hashing.MD5Hash(resApiService.Data.Password))
            };

            var content = PrepareStringContent(login);

            httpClient.Timeout = TimeSpan.FromSeconds(30);
            httpClient.BaseAddress = new Uri(resApiService.Data.ApiAdress);

            using var response = await httpClient.PostAsync("/security/login", content);

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();

            var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<LoginResult>>(responseContent);

            Token.TicketId = desResponseContent?.objects.TicketId;
            Token.DeviceId = desResponseContent?.objects.DeviceId;
            Token.Expiration = DateTime.Now.AddMinutes(25);

            return desResponseContent ?? new ResultStatus<LoginResult>();
        }

        return new ResultStatus<LoginResult>
        {
            result = false,
            message = "API bilgileri alınamadı."
        };
    }
}
