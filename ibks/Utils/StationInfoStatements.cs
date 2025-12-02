using Business.Abstract;
using Business.Constants;
using Business.Helpers;
using Core.Utilities.Results;
using Entities.Concrete.API;
using ibks.Components;

namespace ibks.Utils
{
    public static class StationInfoStatements
    {
        public static void AssignLastWashStatements(ResultStatus<SendDataResult> deserializedResult, ISendDataService sendDataManager, StationInfoControl stationInfoControl)
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

            if (deserializedResult.result)
            {
                stationInfoControl.LastWashAkmImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashCozunmusOksijenImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashDebiImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashDesarjDebiImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashIletkenlikImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashKoiImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashPhImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashSicaklikImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashHariciDebiImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashHariciDebi2Image = ImageAssigns.AssignImage(deserializedResult.objects);
            }
        }

        public static void AssignLastWashWeekStatements(ResultStatus<SendDataResult> deserializedResult, ISendDataService sendDataManager, StationInfoControl stationInfoControl)
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

            if (deserializedResult.result)
            {
                stationInfoControl.LastWashWeekAkmImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekCozunmusOksijenImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekDebiImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekDesarjDebiImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekIletkenlikImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekKoiImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekPhImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekSicaklikImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekHariciDebiImage = ImageAssigns.AssignImage(deserializedResult.objects);
                stationInfoControl.LastWashWeekHariciDebi2Image = ImageAssigns.AssignImage(deserializedResult.objects);
            }
        }

        public static string AssignCalibrationStatements(ICalibrationService calibrationManager, string parameter)
        {
            if (parameter == "Ph")
            {
                var resPh = StationStatementHelper.GetLastPhCalibration(calibrationManager);

                if (resPh.Success && resPh.Data != null)
                {
                    string lastCalibrationPh = $"     {resPh.Data.TimeStamp:g}";

                    return lastCalibrationPh;
                }
                else
                {
                    return $"     {resPh.Message}";
                }
            }
            else if (parameter == "Iletkenlik")
            {
                var resIletkenlik = StationStatementHelper.GetLastIletkenlikCalibration(calibrationManager);

                if (resIletkenlik.Success && resIletkenlik.Data != null)
                {
                    string lastCalibrationIletkenlik = $"     {resIletkenlik.Data.TimeStamp:g}";

                    return lastCalibrationIletkenlik;
                }
                else
                {
                    return $"     {resIletkenlik.Message}";
                }
            }
            else if (parameter == "Akm")
            {
                var resAkm = StationStatementHelper.GetLastAkmCalibration(calibrationManager);

                if (resAkm.Success && resAkm.Data != null)
                {
                    string lastCalibrationIletkenlik = $"     {resAkm.Data.TimeStamp:g}";

                    return lastCalibrationIletkenlik;
                }
                else
                {
                    return $"     {resAkm.Message}";
                }
            }
            else if (parameter == "Koi")
            {
                var resKoi = StationStatementHelper.GetLastKoiCalibration(calibrationManager);

                if (resKoi.Success && resKoi.Data != null)
                {
                    string lastCalibrationIletkenlik = $"     {resKoi.Data.TimeStamp:g}";

                    return lastCalibrationIletkenlik;
                }
                else
                {
                    return $"     {resKoi.Message}";
                }
            }
            else
            {
                return $"     {Messages.DataNotFound}";
            }
        }

        public static void AssignCalibrationImage(ResultStatus<SendDataResult> deserializedResult, Control control)
        {
            if (deserializedResult.result)
            {
                if (control is StationInfoControl)
                {
                    ((StationInfoControl)control).PhCalibrationImage = ImageAssigns.AssignImage(deserializedResult.objects);
                    ((StationInfoControl)control).IletkenlikCalibrationImage = ImageAssigns.AssignImage(deserializedResult.objects);
                }
                else
                {
                    ((Label)control).Image = ImageAssigns.AssignImage(deserializedResult.objects);
                }
            }
        }
    }
}
