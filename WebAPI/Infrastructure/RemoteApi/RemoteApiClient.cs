using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Net;
using System.Text;
using WebAPI.Enums;
using WebAPI.Utils;

namespace WebAPI.Infrastructure.RemoteApi;

public class RemoteApiClient : IRemoteApiClient
{
    public AToken Token = new();
    public HttpClient httpClient = new();
    private readonly IApiService _apiService;

    public RemoteApiClient(IApiService apiService)
    {
        _apiService = apiService;

        var res = _apiService.Get();

        if (res.Success && res.Data != null)
        {
            httpClient.Timeout = TimeSpan.FromSeconds(30);
            httpClient.BaseAddress = new Uri(res.Data.ApiAdress);
        }
    }

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

    public async Task<ResultStatus<T>> PostData<T>(object data, string url, CancellationToken ct = default)
    {
        var content = PrepareStringContent(data);

        await SetValidTicketAsync();

        try
        {
            var response = await httpClient.PostAsync(StationType.SAIS + url, content, ct);

            if (response.StatusCode != HttpStatusCode.OK && Token.Expiration < DateTime.Now.AddMinutes(5))
            {
                await SetValidTicketAsync();

                Log.Write(Serilog.Events.LogEventLevel.Warning, "Token süresi dolmuş, yenileniyor.");

                response.Dispose();

                response = await httpClient.PostAsync(StationType.SAIS + url, content, ct);
            }
            else if (response.StatusCode == HttpStatusCode.Conflict)
            {
                return new ResultStatus<T>
                {
                    result = false,
                    message = "Bu saatin datası daha önce kayıt edilmiştir.",
                };
            }

            var responseContent = await response.Content.ReadAsStringAsync(ct);

            var desResponseContent = JsonConvert.DeserializeObject<ResultStatus<T>>(responseContent)!;

            return desResponseContent;
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message, ex.StackTrace, ex.InnerException);

            return new ResultStatus<T>
            {
                result = false,
                message = "API ile iletişim kurulamadı: " + ex.Message
            };
        }
    }

    public async Task<ResultStatus<SendDataResult>> SendData(SendData data, CancellationToken ct = default) => await PostData<SendDataResult>(data, "/SendData", ct);

    public async Task<ResultStatus<SendCalibrationResult>> SendCalibration(SendCalibration data, CancellationToken ct = default) => await PostData<SendCalibrationResult>(data, "/SendCalibration", ct);

    public async Task<ResultStatus<LoginResult>> Login(CancellationToken ct = default)
    {
        var resApiService = _apiService.Get();

        if (resApiService.Success && resApiService.Data != null)
        {
            var login = new Login
            {
                username = resApiService.Data.UserName,
                password = Hashing.MD5Hash(Hashing.MD5Hash(resApiService.Data.Password))
            };

            var content = PrepareStringContent(login);

            var res = await httpClient.PostAsync("/security/login", content, ct);

            var responseContent = await res.Content.ReadAsStringAsync(ct);

            var deserializedResponse = JsonConvert.DeserializeObject<ResultStatus<LoginResult>>(responseContent);

            if (deserializedResponse != null && deserializedResponse.result)
            {
                Token.TicketId = deserializedResponse?.objects.TicketId;
                Token.DeviceId = deserializedResponse?.objects.DeviceId;
                Token.Expiration = DateTime.Now.AddMinutes(25);

                Log.Information("API'ye başarılı bir şekilde giriş yapıldı ve ticket yenilendi", Token.TicketId);
            }
            else
            {
                Log.Error("API'ye giriş yapılamadı: " + deserializedResponse.message);
            }

            return deserializedResponse ?? new ResultStatus<LoginResult>();
        }

        return new ResultStatus<LoginResult>
        {
            result = false,
            message = "API bilgileri alınamadı."
        };
    }
}