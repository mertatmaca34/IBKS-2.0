using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using PLC.Sharp7.Services;

namespace PLC.Sharp7.Helpers
{
    public static class DataProcessingHelper
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public static IDataResult<SendData> MergedSendData(IStationService stationManager)
        {
            if (stationManager.Get().Success && _sharp7Service.client?.Connected == true)
            {
                var _status = GetSystemStatus.GetStatus();

                return new SuccessDataResult<SendData>(new SendData
                {
                    Stationid = stationManager.Get().Data.StationId,
                    AkisHizi = _sharp7Service.S71200.DB41.NumuneHiz,
                    AkisHizi_Status = _status,
                    AKM = _sharp7Service.S71200.DB41.Akm,
                    AKM_Status = _status,
                    CozunmusOksijen = _sharp7Service.S71200.DB41.CozunmusOksijen,
                    CozunmusOksijen_Status = _status,
                    Debi = _sharp7Service.S71200.DB41.TesisDebi,
                    Debi_Status = _status,
                    DesarjDebi = _sharp7Service.S71200.DB41.DesarjDebi,
                    DesarjDebi_Status = _status,
                    HariciDebi = _sharp7Service.S71200.DB41.HariciDebi,
                    HariciDebi_Status = _status,
                    HariciDebi2 = _sharp7Service.S71200.DB41.HariciDebi2,
                    HariciDebi2_Status = _status,
                    Iletkenlik = _sharp7Service.S71200.DB41.Iletkenlik,
                    Iletkenlik_Status = _status.ToString(),
                    KOi = _sharp7Service.S71200.DB41.Koi,
                    KOi_Status = _status,
                    Period = 1,
                    pH = _sharp7Service.S71200.DB41.Ph,
                    pH_Status = _status,
                    Readtime = _sharp7Service.S71200.DB4.SystemTime,
                    Sicaklik = _sharp7Service.S71200.DB41.KabinSicaklik,
                    Sicaklik_Status = _status,
                    SoftwareVersion = "1.0.0"
                });
            }
            else
            {
                return new ErrorDataResult<SendData>(Messages.StationIsNotDefined);
            }
        }
    }
}
