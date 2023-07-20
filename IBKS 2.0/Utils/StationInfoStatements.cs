using API.Models;
using Business.Abstract;
using Business.Concrete;
using Business.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
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

        public static void AssignLastWashWeekStatements(IDataResult<DeserializeResult> deserializedResult, ISendDataService sendDataManager, StationInfoControl stationInfoControl)
        {
            var res = StationStatementHelper.GetLastWashWeekTime(sendDataManager);

            if (res.Success && res.Data != null)
            {
                string lastWeekWashTime = $"     {res.Data.Readtime:g}";

                stationInfoControl.LastWashWeekAkm = lastWeekWashTime;
                stationInfoControl.LastWashWeekCozunmusOksijen = lastWeekWashTime;
                stationInfoControl.LastWashWeekDebi = lastWeekWashTime;
                stationInfoControl.LastWashWeekDesarjDebi = lastWeekWashTime;
                stationInfoControl.LastWashWeekHariciDebi = lastWeekWashTime;
                stationInfoControl.LastWashWeekHariciDebi2 = lastWeekWashTime;
                stationInfoControl.LastWashWeekIletkenlik = lastWeekWashTime;
                stationInfoControl.LastWashWeekKoi = lastWeekWashTime;
                stationInfoControl.LastWashWeekPh = lastWeekWashTime;
                stationInfoControl.LastWashWeekSicaklik = lastWeekWashTime;
            }

            if (deserializedResult.Success)
            {
                stationInfoControl.LastWashWeekAkmImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekCozunmusOksijenImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekDesarjDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekIletkenlikImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekKoiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekPhImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekSicaklikImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekHariciDebiImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.LastWashWeekHariciDebi2Image = ImageAssigns.AssignImage(deserializedResult.Data);
            }
        }

        public static void AssignCalibrationStatements(IDataResult<DeserializeResult> deserializedResult, ICalibrationService calibrationManager, StationInfoControl stationInfoControl)
        {
            var resPh = StationStatementHelper.GetLastPhCalibration(calibrationManager);

            if (resPh.Success && resPh.Data != null)
            {
                string lastCalibrationPh = $"     {resPh.Data.TimeStamp:g}";

                stationInfoControl.PhCalibration = lastCalibrationPh;
            }

            var resIletkenlik = StationStatementHelper.GetLastIletkenlikCalibration(calibrationManager);

            if (resIletkenlik.Success && resIletkenlik.Data != null)
            {
                string lastCalibrationIletkenlik = $"     {resIletkenlik.Data.TimeStamp:g}";

                stationInfoControl.PhCalibration = lastCalibrationIletkenlik;
            }

            if (deserializedResult.Success)
            {
                stationInfoControl.PhCalibrationImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.IletkenlikCalibrationImage = ImageAssigns.AssignImage(deserializedResult.Data);
            }
        }
    }
}
