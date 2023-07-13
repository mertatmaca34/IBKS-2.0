using Business.Abstract;
using Entities.Concrete;
using PLC.Sharp7;

namespace Business.Concrete
{
    public static class DataProcessingService
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public static int _status = Status;

        public static SendData MergedSendData(IStationService stationManager, IApiService apiManager) => new SendData
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
            Iletkenlik_Status = _status,
            KOi = _sharp7Service.S71200.DB41.Koi,
            KOi_Status = _status,
            Period = 1,
            pH = _sharp7Service.S71200.DB41.Ph,
            pH_Status = _status,
            Readtime = _sharp7Service.S71200.DB4.SystemTime,
            Sicaklik = _sharp7Service.S71200.DB41.KabinSicaklik,
            Sicaklik_Status = _status,
            SoftwareVersion = "1.0.0"
        };

        public static int Status => _sharp7Service.S71200.MBTags.YikamaVarMi ? 23
            : _sharp7Service.S71200.MBTags.HaftalikYikamaVarMi  ? 24
            : _sharp7Service.S71200.MBTags.ModAutoMu ? 1
            : _sharp7Service.S71200.MBTags.ModBakimMi ? 25
            : _sharp7Service.S71200.MBTags.ModKalibrasyonMu ? 9
            : 0;
    }
}
