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

            stationInfoControl.LastWashAkm = res.Message;
            stationInfoControl.LastWashCozunmusOksijen = res.Message;
            stationInfoControl.LastWashDebi = res.Message;
            stationInfoControl.LastWashDesarjDebi = res.Message;
            stationInfoControl.LastWashHariciDebi = res.Message;
            stationInfoControl.LastWashHariciDebi2 = res.Message;
            stationInfoControl.LastWashIletkenlik = res.Message;
            stationInfoControl.LastWashKoi = res.Message;
            stationInfoControl.LastWashPh = res.Message;
            stationInfoControl.LastWashSicaklik = res.Message;

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

            stationInfoControl.LastWashWeekAkm = res.Message;
            stationInfoControl.LastWashWeekCozunmusOksijen = res.Message;
            stationInfoControl.LastWashWeekDebi = res.Message;
            stationInfoControl.LastWashWeekDesarjDebi = res.Message;
            stationInfoControl.LastWashWeekHariciDebi = res.Message;
            stationInfoControl.LastWashWeekHariciDebi2 = res.Message;
            stationInfoControl.LastWashWeekIletkenlik = res.Message;
            stationInfoControl.LastWashWeekKoi = res.Message;
            stationInfoControl.LastWashWeekPh = res.Message;
            stationInfoControl.LastWashWeekSicaklik = res.Message;

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
            else
            {
                stationInfoControl.PhCalibration = $"     {resPh.Message}";
            }

            var resIletkenlik = StationStatementHelper.GetLastIletkenlikCalibration(calibrationManager);

            if (resIletkenlik.Success && resIletkenlik.Data != null)
            {
                string lastCalibrationIletkenlik = $"     {resIletkenlik.Data.TimeStamp:g}";

                stationInfoControl.IletkenlikCalibration = lastCalibrationIletkenlik;
            }
            else
            {
                stationInfoControl.IletkenlikCalibration = $"     {resPh.Message}";
            }

            if (deserializedResult.Success)
            {
                stationInfoControl.PhCalibrationImage = ImageAssigns.AssignImage(deserializedResult.Data);
                stationInfoControl.IletkenlikCalibrationImage = ImageAssigns.AssignImage(deserializedResult.Data);
            }
        }
    }
}
