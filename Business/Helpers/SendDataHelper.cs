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
        private static int LastMinute { get; set; }

        public static IDataResult<DeserializeResult> SendData(ISendDataService sendDataManager, IStationService stationManager, IApiConnection apiConnection)
        {
            if (LastMinute != DateTime.Now.Minute)
            {
                var mergedDataRes = DataProcessingHelper.MergedSendData(stationManager);

                if (mergedDataRes.Success)
                {
                    var apiRes = apiConnection.SendData(mergedDataRes.Data);

                    if (apiRes.result)
                    {
                        string apiObject = apiRes.objects.ToString()!;

                        var deserializededObject = JsonConvert.DeserializeObject<DeserializeResult>(apiObject);

                        sendDataManager.Add(mergedDataRes.Data);

                        LastMinute = DateTime.Now.Minute;

                        return new SuccessDataResult<DeserializeResult>(deserializededObject!);
                    }

                    return new ErrorDataResult<DeserializeResult>(apiRes.message);
                }

                return new ErrorDataResult<DeserializeResult>(mergedDataRes.Message);
            }

            return new ErrorDataResult<DeserializeResult>(Messages.SameMinuteData);
        }
    }
}
