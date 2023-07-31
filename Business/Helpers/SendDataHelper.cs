using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete.API;
using WebAPI.Controllers;

namespace Business.Helpers
{
    public static class SendDataHelper
    {
        private static SendDataController sendDataController = new SendDataController();

        private static int LastMinute { get; set; }

        public static IDataResult<SendDataResult> SendData(ISendDataService sendDataManager, IStationService stationManager)
        {
            if (LastMinute != DateTime.Now.Minute)
            {
                var mergedDataRes = DataProcessingHelper.MergedSendData(stationManager);

                if (mergedDataRes.Success)
                {
                    var apiRes = sendDataController.SendData(mergedDataRes.Data);

                    if (apiRes.IsCompleted)
                    {
                        if (apiRes.IsCompletedSuccessfully)
                        {
                            sendDataManager.Add(mergedDataRes.Data);

                            LastMinute = DateTime.Now.Minute;

                            return new SuccessDataResult<SendDataResult>(apiRes.Result!);
                        }
                    }

                    return new ErrorDataResult<SendDataResult>(apiRes.Exception.ToString());
                }

                return new ErrorDataResult<DeserializeResult>(mergedDataRes.Message);
            }

            return new ErrorDataResult<DeserializeResult>(Messages.SameMinuteData);
        }
    }
}
