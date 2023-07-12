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

        public double Akm { get; set; }
        public PlcService()
        {
            _client = new S7Client();
            _worker = new BackgroundWorker();

            _timer = new Timer(new TimerCallback(TimerTick), null, 1000, 1000);

            Connect();
        }

        private void TimerTick(object state)
        {
            ReadAkmValue();
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

        public void ReadAkmValue()
        {
            if(!_worker.IsBusy)
            {
                _worker.DoWork += delegate
                {
                    byte[] buffer41 = new byte[248];

                    int res = _client.DBRead(41, 0, 248, buffer41);

                    Akm = S7.GetRealAt(buffer41, 56);
                };
                _worker.RunWorkerAsync();
            }
        }
    }
}
