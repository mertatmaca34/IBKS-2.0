using API.Abstract;
using API.Models;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Newtonsoft.Json;

namespace Business.Helpers
{
    public static class SendDataHelper
    {
        private static int _lastMinute = DateTime.Now.Minute;

        public static IDataResult<DeserializeResult> SendData(IStationService stationManager, IApiConnection apiConnection)
        {
            if (_lastMinute != DateTime.Now.Minute)
            {
                var mergedDataRes = DataProcessingHelper.MergedSendData(stationManager);

                if (mergedDataRes.Success)
                {
                    var apiRes = apiConnection.SendData(mergedDataRes.Data);

                    if (apiRes.result)
                    {
                        string apiObject = apiRes.objects.ToString()!;

                        var deserialiedObject = JsonConvert.DeserializeObject<DeserializeResult>(apiObject);

                        return new SuccessDataResult<DeserializeResult>(deserialiedObject!);
                    }

                    return new ErrorDataResult<DeserializeResult>(apiRes.message);
                }

                return new ErrorDataResult<DeserializeResult>(mergedDataRes.Message);
            }

            return new ErrorDataResult<DeserializeResult>(Messages.SameMinuteData);
        }
    }
}
