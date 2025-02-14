using Business.Abstract;
using Business.Concrete;
using Core.Utilities.TempLogs;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using PLC.Sharp7.Utils;
using Sharp7;
using System.ComponentModel;

namespace PLC.Sharp7.Services
{
    public class Sharp7Service
    {
        private static Sharp7Service instance = null;

        public S7Client? client = new S7Client();

        private readonly BackgroundWorker _worker = new();

        private readonly Timer _timer;

        public S71200 S71200 = new();

        public TimeSpan ConnectionTime = new(0, 0, 0);
        public TimeSpan DailyWashRemaining => new(S71200.DB43.DailyWashHour, S71200.DB43.Minute, S71200.DB43.Second);
        public TimeSpan WeeklyWashRemaining => new(S71200.DB43.WeeklyWashDay, S71200.DB43.WeeklyWashHour, S71200.DB43.Minute, S71200.DB43.Second);

        public static IPlcService? _plcManager;

        string _plcIP = "";

        public Sharp7Service(IPlcService plcManager)
        {
            client.ConnTimeout = 5000;

            _plcManager = plcManager;

            AssignPlcIp();

            _timer = new Timer(new TimerCallback(TimerTick), null, 1000, 1000);

            Connect();
        }

        public void AssignPlcIp()
        {
            var plcData = _plcManager!.Get();

            if (plcData.Data != null)
            {
                _plcIP = _plcManager.Get().Data.IpAdress;
            }
            else
            {
                _plcIP = "";
            }
        }

        private void TimerTick(object? state)
        {
            ReadDB41();

            if (client?.Connected == true)
            {
                ConnectionTime = ConnectionTime.Add(new TimeSpan(0, 0, 1));
            }
            else
            {
                ConnectionTime = new TimeSpan(0, 0, 0);
                
                Reconnect();
            }
        }

        public static Sharp7Service Instance
        {
            get
            {
                instance ??= new Sharp7Service(new PlcManager(new EfPlcDal()));

                return instance;
            }
        }

        public int? Connect()
        {
            return client?.ConnectTo(_plcIP, 0, 1);
        }

        public void Disconnect()
        {
            if (client != null)
            {
                int res = client.Disconnect();

                client = null;

                if (res == 0)
                {
                    TempLog.Write($"Bağlantı kapatıldı!");
                }
            }
        }

        public void Reconnect()
        {
            if (client == null)
            {
                client = new S7Client();

                int res = client.ConnectTo(_plcIP, 0, 1);

                if (res == 0)
                {
                    TempLog.Write($"Yeniden Bağlantı Kuruldu!");
                }
                else
                {
                    TempLog.Write($"Yeniden Bağlantı Kurulamadı!");
                }
            }
            else
            {
                Disconnect();
            }
        }

        //public void StartSample()
        //{
        //    byte[] bytes = new byte[30];

        //    // EBWrite ile veri okunur
        //    int result = client!.EBRead(0, 30, bytes);
        //    if (result == 0)
        //    {
        //        // Veri okuma başarılı

        //        // Belirli bitin değerini ayarla
        //        S7.SetBitAt(bytes, 28, 7, true);

        //        // Veriyi yaz
        //        result = client.EBWrite(0, 30, bytes);
        //        if (result == 0)
        //        {
        //            // Yazma işlemi başarılı
        //        }
        //        else
        //        {
        //            // Yazma işlemi başarısız
        //        }
        //    }
        //    else
        //    {
        //        // Veri okuma başarısız
        //    }
        //}

        public void StartSample()
        {
            if(client.Connected)
            {
                client.Connect();

                if(client.Connected)
                {
                    byte[] buffer = new byte[3];

                    client?.DBRead(42, 0, 3, buffer);

                    S7.SetBitAt(buffer, 2, 5, true);

                    var res = client?.DBWrite(42, 0, 3, buffer);
                }
            }
            
        }

        public void ReadDB41()
        {
            if (!_worker.IsBusy && client != null & client?.Connected == true)
            {
                _worker.DoWork += delegate
                {
                    int? res = client?.DBRead(41, 0, 248, S71200.Buffer41);

                    if (res == 0)
                    {
                        S71200.DB41.Akm = Get.Real(S71200.Buffer41, 36, 60);
                        S71200.DB41.TesisDebi = Get.Real(S71200.Buffer41, 0, 60);
                        S71200.DB41.TesisGünlükDebi = Get.Real(S71200.Buffer41, 12, 60);
                        S71200.DB41.DesarjDebi = Get.Real(S71200.Buffer41, 60, 60);  //Taşkan Debisi
                        S71200.DB41.HariciDebi = Get.Real(S71200.Buffer41, 52, 60);  //Çıkış Terfi Merkezi Debisi
                        S71200.DB41.HariciDebi2 = Get.Real(S71200.Buffer41, 56, 60); //2. Kademe Çıkış Debisi
                        S71200.DB41.NumuneHiz = Get.Real(S71200.Buffer41, 4);
                        S71200.DB41.NumuneDebi = Get.Real(S71200.Buffer41, 8);
                        S71200.DB41.Ph = Get.Real(S71200.Buffer41, 16);
                        S71200.DB41.Iletkenlik = Get.Real(S71200.Buffer41, 20);
                        S71200.DB41.CozunmusOksijen = Get.Real(S71200.Buffer41, 24);
                        S71200.DB41.NumuneSicaklik = Get.Real(S71200.Buffer41, 28);
                        S71200.DB41.Koi = Get.Real(S71200.Buffer41, 32);
                        S71200.DB41.Akm = Get.Real(S71200.Buffer41, 36);
                        S71200.DB41.KabinNem = Get.Real(S71200.Buffer41, 44);
                        S71200.DB41.KabinSicaklik = Get.Real(S71200.Buffer41, 40);
                        S71200.DB41.Pompa1Hz = Get.Real(S71200.Buffer41, 140);
                        S71200.DB41.Pompa2Hz = Get.Real(S71200.Buffer41, 144);
                        S71200.DB41.UpsGirisVolt = Get.Real(S71200.Buffer41, 152);
                        S71200.DB41.UpsCikisVolt = Get.Real(S71200.Buffer41, 148);
                        S71200.DB41.UpsKapasite = Get.Real(S71200.Buffer41, 156);
                        S71200.DB41.UpsSicaklik = Get.Real(S71200.Buffer41, 160);
                        S71200.DB41.UpsYuk = Get.Real(S71200.Buffer41, 164);

                        res = client?.DBRead(42, 0, 3, S71200.Buffer42);

                        S71200.DB42.Kabin_Oto                = Get.Bit(S71200.Buffer42, 0, 0);
                        S71200.DB42.Kabin_Bakim              = Get.Bit(S71200.Buffer42, 0, 1);
                        S71200.DB42.Kabin_Kalibrasyon        = Get.Bit(S71200.Buffer42, 0, 2);
                        S71200.DB42.Kabin_Duman              = Get.Bit(S71200.Buffer42, 0, 3);
                        S71200.DB42.Kabin_SuBaskini          = Get.Bit(S71200.Buffer42, 0, 4);
                        S71200.DB42.Kabin_KapiAcildi         = Get.Bit(S71200.Buffer42, 0, 5);
                        S71200.DB42.Kabin_EnerjiYok          = Get.Bit(S71200.Buffer42, 0, 6);
                        S71200.DB42.Kabin_AcilStopBasili     = Get.Bit(S71200.Buffer42, 0, 7);
                        S71200.DB42.Kabin_HaftalikYikamada   = Get.Bit(S71200.Buffer42, 1, 0);
                        S71200.DB42.Kabin_SaatlikYikamada    = Get.Bit(S71200.Buffer42, 1, 1);
                        S71200.DB42.Pompa1Termik             = Get.Bit(S71200.Buffer42, 1, 2);
                        S71200.DB42.Pompa2Termik             = Get.Bit(S71200.Buffer42, 1, 3);
                        S71200.DB42.Pompa3Termik             = Get.Bit(S71200.Buffer42, 1, 4);
                        S71200.DB42.TankDolu                 = Get.Bit(S71200.Buffer42, 1, 5);
                        S71200.DB42.Pompa1Calisiyor          = Get.Bit(S71200.Buffer42, 1, 6);
                        S71200.DB42.Pompa2Calisiyor          = Get.Bit(S71200.Buffer42, 1, 7);
                        S71200.DB42.Pompa3Calisiyor          = Get.Bit(S71200.Buffer42, 2, 0);
                        S71200.DB42.AkmTetik                 = Get.Bit(S71200.Buffer42, 2, 1);
                        S71200.DB42.KoiTetik                 = Get.Bit(S71200.Buffer42, 2, 2);
                        S71200.DB42.PhTetik                  = Get.Bit(S71200.Buffer42, 2, 3);
                        S71200.DB42.ManuelTetik              = Get.Bit(S71200.Buffer42, 2, 4);
                        S71200.DB42.SimNumuneTetik           = Get.Bit(S71200.Buffer42, 2, 5);

                        res = client?.DBRead(43, 0, 19, S71200.Buffer43);

                        S71200.DB43.SystemTime = Get.Time(S71200.Buffer43, 0);
                        S71200.DB43.WeeklyWashDay = Get.Byte(S71200.Buffer43, 14);
                        S71200.DB43.WeeklyWashHour = Get.Byte(S71200.Buffer43, 15);
                        S71200.DB43.DailyWashHour = Get.Byte(S71200.Buffer43, 16);
                        S71200.DB43.Minute = Get.Byte(S71200.Buffer43, 17);
                        S71200.DB43.Second = Get.Byte(S71200.Buffer43, 18);
                    }
                    else
                    {
                        Reconnect();

                        //TODO
                    }
                };
                _worker.RunWorkerAsync();
            }
        }
    }
}