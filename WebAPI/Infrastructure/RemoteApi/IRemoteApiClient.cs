using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Infrastructure.RemoteApi;

public interface IRemoteApiClient
{
    Task<ResultStatus<SendDataResult>> SendData(SendData data, CancellationToken ct = default);
    Task<ResultStatus<SendCalibrationResult>> SendCalibration(SendCalibration data, CancellationToken ct = default);
}
