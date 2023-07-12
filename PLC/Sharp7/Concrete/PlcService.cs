using Entities.Concrete;
using PLC.Sharp7.Utils;
using Sharp7;
using System.ComponentModel;

namespace PLC.Sharp7.Concrete
{
    public class PlcService
    {
        private static PlcService instance = null;
        public S7Client _client;
        BackgroundWorker _worker;
        Timer _timer;

        public byte[] _buffer41;

        public DB41 DB41 = new DB41();

        public PlcService()
        {
            _client = new S7Client();
            _worker = new BackgroundWorker();

            _timer = new Timer(new TimerCallback(TimerTick), null, 1000, 1000);

            _buffer41 = new byte[248];


            Connect();
        }

        private void TimerTick(object state)
        {
            ReadDB41();
        }

        public static PlcService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlcService();
                }
                return instance;
            }
        }

        public int Connect()
        {
            return _client.ConnectTo("10.33.2.253", 0, 1);
        }

        public void Disconnect()
        {
            if (_client != null)
            {
                int res = _client.Disconnect();

                _client = null;

                if (res == 0)
                {
                    Console.WriteLine($"Bağlantı kapatıldı!");
                }
            }
        }

        public void Reconnect()
        {
            if (_client == null)
            {
                _client = new S7Client();

                int res = _client.ConnectTo("10.33.2.253", 0, 1);

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
                    int res = _client.DBRead(41, 0, 248, _buffer41);

                    DB41.Akm = S7.GetRealAt(_buffer41, 56);
                    DB41.TesisDebi = Get.Real(_buffer41, 0, 60);
                    DB41.TesisGünlükDebi = Get.Real(_buffer41, 12, 60);
                    DB41.DesarjDebi = Get.Real(_buffer41, 60, 60); //Taşkan Debisi
                    DB41.HariciDebi = Get.Real(_buffer41, 52, 60); //Çıkış Terfi Merkezi Debisi
                    DB41.HariciDebi2 = Get.Real(_buffer41, 56, 60); //2. Kademe Çıkış Debisi
                    DB41.NumuneHiz = Get.Real(_buffer41, 4);
                    DB41.NumuneDebi = Get.Real(_buffer41, 8);
                    DB41.Ph = Get.Real(_buffer41, 16);
                    DB41.Iletkenlik = Get.Real(_buffer41, 20);
                    DB41.CozunmusOksijen = Get.Real(_buffer41, 24);
                    DB41.NumuneSicaklik = Get.Real(_buffer41, 28);
                    DB41.Koi = Get.Real(_buffer41, 32);
                    DB41.Akm = Get.Real(_buffer41, 36);
                    DB41.KabinNem = Get.Real(_buffer41, 44);
                    DB41.KabinSicaklik = Get.Real(_buffer41, 40);
                    DB41.Pompa1Hz = Get.Real(_buffer41, 140);
                    DB41.Pompa2Hz = Get.Real(_buffer41, 144);
                    DB41.UpsGirisVolt = Get.Real(_buffer41, 152);
                    DB41.UpsCikisVolt = Get.Real(_buffer41, 148);
                    DB41.UpsKapasite = Get.Real(_buffer41, 156);
                    DB41.UpsSicaklik = Get.Real(_buffer41, 160);
                    DB41.UpsYuk = Get.Real(_buffer41, 164);

                };
                _worker.RunWorkerAsync();
            }
        }
    }
}
