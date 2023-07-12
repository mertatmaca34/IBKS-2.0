using Entities.Concrete;
using PLC.Sharp7.Utils;
using Sharp7;
using System.ComponentModel;

namespace PLC.Sharp7.Concrete
{
    public class PlcService
    {
        private static PlcService instance = null;

        public S7Client client = new();
        public DB41 DB41 = new();

        private readonly BackgroundWorker _worker = new();
        private readonly byte[] buffer41 = new byte[248];

        private readonly Timer _timer;

        public PlcService()
        {
            _timer = new Timer(new TimerCallback(TimerTick), null, 1000, 1000);

            Connect();
        }

        private void TimerTick(object? state)
        {
            ReadDB41();
        }

        public static PlcService Instance
        {
            get
            {
                instance ??= new PlcService();

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
        }

        public void ReadDB41()
        {
            if (!_worker.IsBusy)
            {
                _worker.DoWork += delegate
                {
                    int res = client.DBRead(41, 0, 248, buffer41);

                    DB41.Akm = S7.GetRealAt(buffer41, 56);
                    DB41.TesisDebi = Get.Real(buffer41, 0, 60);
                    DB41.TesisGünlükDebi = Get.Real(buffer41, 12, 60);
                    DB41.DesarjDebi = Get.Real(buffer41, 60, 60); //Taşkan Debisi
                    DB41.HariciDebi = Get.Real(buffer41, 52, 60); //Çıkış Terfi Merkezi Debisi
                    DB41.HariciDebi2 = Get.Real(buffer41, 56, 60); //2. Kademe Çıkış Debisi
                    DB41.NumuneHiz = Get.Real(buffer41, 4);
                    DB41.NumuneDebi = Get.Real(buffer41, 8);
                    DB41.Ph = Get.Real(buffer41, 16);
                    DB41.Iletkenlik = Get.Real(buffer41, 20);
                    DB41.CozunmusOksijen = Get.Real(buffer41, 24);
                    DB41.NumuneSicaklik = Get.Real(buffer41, 28);
                    DB41.Koi = Get.Real(buffer41, 32);
                    DB41.Akm = Get.Real(buffer41, 36);
                    DB41.KabinNem = Get.Real(buffer41, 44);
                    DB41.KabinSicaklik = Get.Real(buffer41, 40);
                    DB41.Pompa1Hz = Get.Real(buffer41, 140);
                    DB41.Pompa2Hz = Get.Real(buffer41, 144);
                    DB41.UpsGirisVolt = Get.Real(buffer41, 152);
                    DB41.UpsCikisVolt = Get.Real(buffer41, 148);
                    DB41.UpsKapasite = Get.Real(buffer41, 156);
                    DB41.UpsSicaklik = Get.Real(buffer41, 160);
                    DB41.UpsYuk = Get.Real(buffer41, 164);

                };
                _worker.RunWorkerAsync();
            }
        }
    }
}
