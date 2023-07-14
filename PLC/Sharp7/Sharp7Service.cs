using Entities.Concrete;
using PLC.Sharp7.Utils;
using Sharp7;
using System.ComponentModel;

namespace PLC.Sharp7
{
    public class Sharp7Service
    {
        private static Sharp7Service instance = null;

        public S7Client client = new();

        private readonly BackgroundWorker _worker = new();

        private readonly Timer _timer;

        public S71200 S71200 = new();

        public TimeSpan ConnectionTime = new(0, 0, 0);

        public Sharp7Service()
        {
            _timer = new Timer(new TimerCallback(TimerTick), null, 1000, 1000);

            Connect();
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
                instance ??= new Sharp7Service();

                return instance;
            }
        }

        public int Connect()
        {
            return client.ConnectTo("10.33.2.253", 0, 1);
        }

        public void Disconnect()
        {
            if (client != null)
            {
                int res = client.Disconnect();

                client = null;

                if (res == 0)
                {
                    Console.WriteLine($"Bağlantı kapatıldı!");
                }
            }
        }

        public void Reconnect()
        {
            if (client == null)
            {
                client = new S7Client();

                int res = client.ConnectTo("10.33.2.253", 0, 1);

                if (res == 0)
                {
                    Console.WriteLine($"Bağlantı başarılı!");
                }
            }
            else
            {
                Disconnect();
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

                        res = client?.DBRead(4, 0, 12, S71200.Buffer4);

                        S71200.DB4.SystemTime = Get.Time(S71200.Buffer4, 0);
                        res = client?.DBRead(12, 0, 28, S71200.Buffer12);

                        S71200.DB12.HaftaGunu = Get.Byte(S71200.Buffer12, 4);
                        S71200.DB12.HaftaGunuSaat = Get.Byte(S71200.Buffer12, 5);
                        S71200.DB12.HaftaGunuDakika = Get.Byte(S71200.Buffer12, 6);
                        S71200.DB12.GunlukYikamaSaat = Get.Byte(S71200.Buffer12, 25);
                        S71200.DB12.GunlukYikamaDakika = Get.Byte(S71200.Buffer12, 26);

                        res = client?.EBRead(0, 30, S71200.InputTagsBuffer);

                        S71200.InputTags.ReadTime = S71200.DB4.SystemTime;
                        S71200.InputTags.Kapi = Get.Input(S71200.InputTagsBuffer, 25, 5);
                        S71200.InputTags.Duman = Get.Input(S71200.InputTagsBuffer, 1, 1);
                        S71200.InputTags.SuBaskini = Get.Input(S71200.InputTagsBuffer, 0, 7);
                        S71200.InputTags.AcilStop = Get.Input(S71200.InputTagsBuffer, 25, 7);
                        S71200.InputTags.Pompa1Termik = Get.Input(S71200.InputTagsBuffer, 27, 3);
                        S71200.InputTags.Pompa2Termik = Get.Input(S71200.InputTagsBuffer, 27, 6);
                        S71200.InputTags.TemizSuTermik = Get.Input(S71200.InputTagsBuffer, 28, 2);
                        S71200.InputTags.YikamaTanki = Get.Input(S71200.InputTagsBuffer, 28, 3);
                        S71200.InputTags.Enerji = Get.Input(S71200.InputTagsBuffer, 25, 6);
                        S71200.InputTags.Pompa1CalisiyorMu = Get.Input(S71200.InputTagsBuffer, 27, 4);
                        S71200.InputTags.Pompa2CalisiyorMu = Get.Input(S71200.InputTagsBuffer, 27, 7);

                        res = client?.MBRead(0, 102, S71200.MBTagsBuffer);

                        S71200.MBTags.ReadTime = S71200.DB4.SystemTime;
                        S71200.MBTags.YikamaVarMi = Get.MB(S71200.MBTagsBuffer, 24, 1);
                        S71200.MBTags.HaftalikYikamaVarMi = Get.MB(S71200.MBTagsBuffer, 24, 2);
                        S71200.MBTags.ModAutoMu = Get.MB(S71200.MBTagsBuffer, 10, 6);
                        S71200.MBTags.ModBakimMi = Get.MB(S71200.MBTagsBuffer, 10, 4);
                        S71200.MBTags.ModKalibrasyonMu = Get.MB(S71200.MBTagsBuffer, 10, 5);
                        S71200.MBTags.AkmTetik = Get.MB(S71200.MBTagsBuffer, 101, 1);
                        S71200.MBTags.KoiTetik = Get.MB(S71200.MBTagsBuffer, 101, 2);
                        S71200.MBTags.PhTetik = Get.MB(S71200.MBTagsBuffer, 101, 3);
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
