using API.Models;
using Business.Abstract;
using Business.Helpers;
using Core.Utilities.Results;
using IBKS_2._0.Components;

namespace IBKS_2._0.Utils
{
    public static class StationInfoStatements
    {
        public static void AssignLastWashStatements(IDataResult<DeserializeResult> deserializedResult, ISendDataService sendDataManager, StationInfoControl stationInfoControl)
        {
            var res = StationStatementHelper.GetLastWashTime(sendDataManager);

            if (res.Success && res.Data != null)
            {
                string lastWashTime = $"     {res.Data.Readtime:t}";

                stationInfoControl.LastWashAkm = lastWashTime;
                stationInfoControl.LastWashCozunmusOksijen = lastWashTime;
                stationInfoControl.LastWashDebi = lastWashTime;
                stationInfoControl.LastWashDesarjDebi = lastWashTime;
                stationInfoControl.LastWashHariciDebi = lastWashTime;
                stationInfoControl.LastWashHariciDebi2 = lastWashTime;
                stationInfoControl.LastWashIletkenlik = lastWashTime;
                stationInfoControl.LastWashKoi = lastWashTime;
                stationInfoControl.LastWashPh = lastWashTime;
                stationInfoControl.LastWashSicaklik = lastWashTime;
            }

            if (deserializedResult.Success)
            {
                stationInfoControl.LastWashAkmImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashCozunmusOksijenImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashDesarjDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashIletkenlikImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashKoiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashPhImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashSicaklikImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashHariciDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashHariciDebi2Image = ImageAssigns.AssignImage(deserializedResult.Data);
            }
        }

        public static void AssignLastWeekWashStatements(IDataResult<DeserializeResult> deserializedResult, ISendDataService sendDataManager, StationInfoControl stationInfoControl)
        {
            var res = StationStatementHelper.GetLastWashTime(sendDataManager);

            if (res.Success && res.Data != null)
            {
                string lastWashTime = $"     {res.Data.Readtime:t}";

                stationInfoControl.LastWashAkm = lastWashTime;
                stationInfoControl.LastWashCozunmusOksijen = lastWashTime;
                stationInfoControl.LastWashDebi = lastWashTime;
                stationInfoControl.LastWashDesarjDebi = lastWashTime;
                stationInfoControl.LastWashHariciDebi = lastWashTime;
                stationInfoControl.LastWashHariciDebi2 = lastWashTime;
                stationInfoControl.LastWashIletkenlik = lastWashTime;
                stationInfoControl.LastWashKoi = lastWashTime;
                stationInfoControl.LastWashPh = lastWashTime;
                stationInfoControl.LastWashSicaklik = lastWashTime;
            }

            if (deserializedResult.Success)
            {
                stationInfoControl.LastWashAkmImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashCozunmusOksijenImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashDesarjDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashIletkenlikImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashKoiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashPhImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashSicaklikImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashHariciDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashHariciDebi2Image = ImageAssigns.AssignImage(deserializedResult.Data);
            }
        }
    }
}
