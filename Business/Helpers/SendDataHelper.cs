using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete.API;
using Newtonsoft.Json;
using WebAPI.Controllers;

namespace Business.Helpers
{
    public static class SendDataHelper
    {
        private static SendDataController sendDataController = new SendDataController();

        private static int LastMinute { get; set; }
        
        public static IDataResult<DeserializeResult> SendData(ISendDataService sendDataManager, IStationService stationManager)
        {
            if (LastMinute != DateTime.Now.Minute)
            {
                var mergedDataRes = DataProcessingHelper.MergedSendData(stationManager);

                if (mergedDataRes.Success)
                {
                    //var apiRes = sendDataController.Post(mergedDataRes.Data);

                    /*if (apiRes.result)
                    {*/
                        /*string apiObject = apiRes.objects.ToString()!;

                        var deserializededObject = JsonConvert.DeserializeObject<DeserializeResult>(apiObject);*/

                        sendDataManager.Add(mergedDataRes.Data);

                        LastMinute = DateTime.Now.Minute;

                        //return new SuccessDataResult<DeserializeResult>(deserializededObject!);
                    /*}*/

                    //return new ErrorDataResult<DeserializeResult>(apiRes.message);
                }

                return new ErrorDataResult<DeserializeResult>(mergedDataRes.Message);
            }

            return new ErrorDataResult<DeserializeResult>(Messages.SameMinuteData);
        }
    }
}
