using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.API;
using ibks.Components;
using PLC.Sharp7.Services;
using System.Windows.Forms.DataVisualization.Charting;
using WebAPI.Abstract;
using Timer = System.Windows.Forms.Timer;

namespace ibks.Utils
{
    public class CalibrationOps
    {
        readonly Sharp7Service sharp7Service = Sharp7Service.Instance;

        public bool isCalibrationInProgress;
        readonly double _tolerance = 1.10;

        Calibration _calibration = new Calibration();

        readonly IStationService _stationManager;
        readonly ICalibrationService _calibrationManager;
        readonly IApiService _apiManager;
        readonly ISendCalibrationController _sendCalibrationController;

        Station stationInfo = new Station();

        public CalibrationOps(IStationService stationManager, ICalibrationService calibrationManager, IApiService apiManager, ISendCalibrationController sendCalibrationController)
        {
            _stationManager = stationManager;
            _calibrationManager = calibrationManager;
            _apiManager = apiManager;
            _sendCalibrationController = sendCalibrationController;

            var stationData = stationManager.Get();

            if (stationData.Data != null)
            {
                stationInfo.StationId = _stationManager.Get().Data.StationId;
            }
        }

        private async void SendCalibration(SendCalibration data)
        {
            var res = await _sendCalibrationController.SendCalibration(data);

            MessageBox.Show(res.Message);
        }

        public void StartCalibration(string calibrationName, string calibrationType, int calibrationTime, List<Control> controls)
        {
            if (!isCalibrationInProgress)
            {
                isCalibrationInProgress = true;

                if (calibrationType == "Zero")
                {
                    StartZeroCalibration(calibrationName, calibrationTime, controls);
                }
                else
                {
                    StartSpanCalibration(calibrationName, calibrationTime, controls);
                }
            }
            else
            {
                return;
            }
        }

        public void StartZeroCalibration(string calibrationName, int calibrationTime, List<Control> controls)
        {
            List<double> measValues = new List<double>();

            TitleBarControl labelTimeStamp = (TitleBarControl)controls.FirstOrDefault(c => c.Name == "TitleBarControlTimeRemain")!;
            Chart ChartCalibration = (Chart)controls.FirstOrDefault(c => c.Name == "ChartCalibration")!;
            TitleBarControl labelActiveCalibration = (TitleBarControl)controls.FirstOrDefault(c => c.Name == "TitleBarControlActiveCalibration")!;

            ChartCalibration.Series["Kalibrasyon Değeri"].Points.Clear();
            ChartCalibration.Series["Referans Değeri"].Points.Clear();

            switch (calibrationName)
            {
                case "AKM":
                    _calibration.ZeroMeas = sharp7Service.S71200.DB41.Akm;
                    _calibration.ZeroRef = 0;
                    _calibration.Parameter = "Akm";
                    labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: Akm";
                    break;
                case "KOi":
                    _calibration.ZeroMeas = sharp7Service.S71200.DB41.Koi;
                    _calibration.ZeroRef = 0;
                    _calibration.Parameter = "Koi";
                    labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: Koi";
                    break;
                case "pH":
                    _calibration.ZeroMeas = sharp7Service.S71200.DB41.Ph;
                    _calibration.ZeroRef = 7;
                    _calibration.Parameter = "pH";
                    labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: pH";
                    break;
                case "Iletkenlik":
                    _calibration.ZeroMeas = sharp7Service.S71200.DB41.Iletkenlik;
                    _calibration.ZeroRef = 0;
                    _calibration.Parameter = "Iletkenlik";
                    labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: İletkenlik";
                    break;
                default:
                    _calibration.ZeroMeas = 0;
                    _calibration.ZeroRef = 0;
                    break;
            }

            System.Windows.Forms.Timer timerCalibration = new System.Windows.Forms.Timer
            {
                Interval = 1000,
                Enabled = true
            };

            timerCalibration.Tick += delegate
            {
                //Kalibrasyon süresi 0 olduğunda bitecek
                if (calibrationTime >= 0)
                {
                    RefreshData(calibrationName, "Zero");

                    labelTimeStamp.TitleBarText = calibrationTime.ToString();

                    ChartCalibration.Series["Kalibrasyon Değeri"].Points.AddXY(sharp7Service.S71200.DB4.SystemTime.ToString("hh:mm:ss"), _calibration.ZeroMeas);
                    ChartCalibration.Series["Referans Değeri"].Points.AddXY(sharp7Service.S71200.DB4.SystemTime.ToString("hh:mm:ss"), _calibration.ZeroRef);

                    measValues.Add(_calibration.ZeroMeas);

                    CalculateCalibrationParameters(measValues, "Zero");
                    AssignLabels(controls, "Zero");

                    if (_calibration.ZeroMeas >= _calibration.ZeroRef / _tolerance && _calibration.ZeroMeas <= _calibration.ZeroRef * _tolerance)
                    {
                        ChartCalibration.Series["Kalibrasyon Değeri"].Color = Color.Lime;
                    }
                    else
                    {
                        ChartCalibration.Series["Kalibrasyon Değeri"].Color = Color.Red;
                    }
                    calibrationTime--;
                }
                else
                {
                    timerCalibration.Enabled = false;
                    isCalibrationInProgress = false;

                    //Kalibrasyon geçerlilik kontrolü
                    if (ChartCalibration.Series["Kalibrasyon Değeri"].Color == Color.Lime)
                    {
                        _calibration.IsItValid = true;
                    }
                    else
                    {
                        _calibration.IsItValid = false;
                    }

                    if (calibrationName == "AKM" || calibrationName == "KOi")
                    {
                        _calibration.TimeStamp = DateTime.Now;

                        //TODO API BAĞLAN 
                        _calibration.ResultFactor = 1;

                        SendCalibration data = new SendCalibration
                        {
                            CalibrationDate = _calibration.TimeStamp,
                            Stationid = stationInfo.StationId,
                            DBColumnName = calibrationName,
                            ZeroRef = _calibration.ZeroRef,
                            ZeroMeas = _calibration.ZeroMeas,
                            ZeroDiff = _calibration.ZeroDiff,
                            ZeroSTD = _calibration.ZeroStd,
                            SpanRef = _calibration.SpanRef,
                            SpanMeas = _calibration.SpanMeas,
                            SpanDiff = _calibration.SpanDiff,
                            SpanSTD = _calibration.SpanStd,
                            ResultFactor = _calibration.ResultFactor,
                            ResultZero = _calibration.IsItValid,
                            ResultSpan = _calibration.IsItValid,
                        };

                        //TODO KALİBRASYONU GÖNDER
                        labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: -";
                        SendCalibration(data);

                        //Kalibrasyonu kaydet
                        _calibration.TimeStamp = DateTime.Now;
                        _calibrationManager.Add(_calibration);

                        //Nesneyi resetle
                        _calibration = new Calibration();

                        //Label'lardaki değerleri resetle
                        AssignLabels(controls, "reset");
                    }

                    ChartCalibration.Series["Kalibrasyon Değeri"].Points.Clear();
                    ChartCalibration.Series["Referans Değeri"].Points.Clear();
                    labelTimeStamp.TitleBarText = "Kalan Süre:";
                }
            };
        }

        public void StartSpanCalibration(string calibrationName, int calibrationTime, List<Control> controls)
        {
            List<double> measValues = new List<double>();

            TitleBarControl labelTimeStamp = (TitleBarControl)controls.FirstOrDefault(c => c.Name == "TitleBarControlTimeRemain")!;
            Chart ChartCalibration = (Chart)controls.FirstOrDefault(c => c.Name == "ChartCalibration")!;
            TitleBarControl labelActiveCalibration = (TitleBarControl)controls.FirstOrDefault(c => c.Name == "TitleBarControlActiveCalibration")!;

            switch (calibrationName)
            {
                case "AKM":
                    _calibration.ZeroMeas = sharp7Service.S71200.DB41.Akm;
                    _calibration.ZeroRef = 0;
                    _calibration.Parameter = "Akm";
                    labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: Akm";
                    break;
                case "KOi":
                    _calibration.ZeroMeas = sharp7Service.S71200.DB41.Koi;
                    _calibration.ZeroRef = 0;
                    _calibration.Parameter = "Koi";
                    labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: Koi";
                    break;
                case "pH":
                    _calibration.SpanMeas = sharp7Service.S71200.DB41.Ph;
                    _calibration.SpanRef = 4;
                    _calibration.Parameter = "Ph";
                    labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: pH";
                    break;
                case "Iletkenlik":
                    _calibration.SpanMeas = sharp7Service.S71200.DB41.Iletkenlik;
                    _calibration.SpanRef = 1413;
                    _calibration.Parameter = "Iletkenlik";
                    labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: İletkenlik";
                    break;
                default:
                    _calibration.ZeroMeas = 0;
                    _calibration.ZeroRef = 0;
                    break;
            }

            Timer timerCalibration = new Timer
            {
                Interval = 1000,
                Enabled = true
            };

            timerCalibration.Tick += delegate
            {
                //Kalibrasyon süresi 0 olduğunda bitecek
                if (calibrationTime >= 0)
                {
                    RefreshData(calibrationName, "Span");

                    labelTimeStamp.TitleBarText = calibrationTime.ToString();

                    ChartCalibration.Series["Kalibrasyon Değeri"].Points.AddXY(sharp7Service.S71200.DB4.SystemTime.ToString("hh:mm:ss"), _calibration.SpanMeas);
                    ChartCalibration.Series["Referans Değeri"].Points.AddXY(sharp7Service.S71200.DB4.SystemTime.ToString("hh:mm:ss"), _calibration.SpanRef);

                    measValues.Add(_calibration.SpanMeas);

                    CalculateCalibrationParameters(measValues, "Span");
                    AssignLabels(controls, "Span");

                    if (_calibration.SpanMeas >= _calibration.SpanRef / _tolerance && _calibration.SpanMeas <= _calibration.SpanRef * _tolerance)
                    {
                        ChartCalibration.Series["Kalibrasyon Değeri"].Color = Color.Lime;
                    }
                    else
                    {
                        ChartCalibration.Series["Kalibrasyon Değeri"].Color = Color.Red;
                    }
                    calibrationTime--;
                }
                else
                {
                    timerCalibration.Enabled = false;
                    isCalibrationInProgress = false;

                    //Kalibrasyon geçerlilik kontrolü
                    if (ChartCalibration.Series["Kalibrasyon Değeri"].Color == Color.Lime)
                    {
                        _calibration.IsItValid = true;
                    }
                    else
                    {
                        _calibration.IsItValid = false;
                    }

                    _calibration.TimeStamp = sharp7Service.S71200.DB4.SystemTime;

                    //TODO APIYE BAĞLAN
                    if (calibrationName == "pH" || calibrationName == "Iletkenlik")
                    {
                        _calibration.TimeStamp = DateTime.Now;

                        //TODO API BAĞLAN 
                        _calibration.ResultFactor = 1;

                        SendCalibration data = new SendCalibration
                        {
                            CalibrationDate = _calibration.TimeStamp,
                            Stationid = stationInfo.StationId,
                            DBColumnName = calibrationName,
                            ZeroRef = _calibration.ZeroRef,
                            ZeroMeas = _calibration.ZeroMeas,
                            ZeroDiff = _calibration.ZeroDiff,
                            ZeroSTD = _calibration.ZeroStd,
                            SpanRef = _calibration.SpanRef,
                            SpanMeas = _calibration.SpanMeas,
                            SpanDiff = _calibration.SpanDiff,
                            SpanSTD = _calibration.SpanStd,
                            ResultFactor = _calibration.ResultFactor,
                            ResultZero = _calibration.IsItValid,
                            ResultSpan = _calibration.IsItValid,
                        };

                        //TODO KALİBRASYONU GÖNDER
                        labelActiveCalibration.TitleBarText = "Aktif Kalibrasyon: -";
                        SendCalibration(data);

                        //Kalibrasyonu kaydet
                        _calibration.TimeStamp = DateTime.Now;
                        _calibrationManager.Add(_calibration);

                        //Nesneyi resetle
                        _calibration = new Calibration();

                        //Label'lardaki değerleri resetle
                        AssignLabels(controls, "reset");
                    }

                    ChartCalibration.Series["Kalibrasyon Değeri"].Points.Clear();
                    ChartCalibration.Series["Referans Değeri"].Points.Clear();
                    labelTimeStamp.TitleBarText = "Kalan Süre:";
                }
            };
        }

        public void RefreshData(string calibrationName, string calibrationType)
        {
            switch (calibrationName)
            {
                case "Akm":
                    _calibration.ZeroMeas = sharp7Service.S71200.DB41.Akm;
                    break;
                case "Koi":
                    _calibration.ZeroMeas = sharp7Service.S71200.DB41.Koi;
                    break;
                case "Ph":
                    if (calibrationType == "Zero")
                        _calibration.ZeroMeas = sharp7Service.S71200.DB41.Ph;
                    else
                        _calibration.SpanMeas = sharp7Service.S71200.DB41.Ph;
                    break;
                case "Iletkenlik":
                    if (calibrationType == "Zero")
                        _calibration.ZeroMeas = sharp7Service.S71200.DB41.Iletkenlik;
                    else
                        _calibration.SpanMeas = sharp7Service.S71200.DB41.Iletkenlik;
                    break;
                default:
                    _calibration.ZeroMeas = 0;
                    _calibration.ZeroRef = 0;
                    break;
            }
        }
        public void CalculateCalibrationParameters(List<double> measValues, string calibrationType)
        {
            if (calibrationType == "Zero")
            {
                _calibration.ZeroDiff = Math.Round(_calibration.ZeroMeas - _calibration.ZeroRef, 2);
                _calibration.ZeroStd = Math.Round(CalculateStandardDeviation(measValues), 2);
                _calibration.ResultFactor = Math.Round((_calibration.ZeroMeas - _calibration.ZeroRef) / _calibration.ZeroDiff, 2);
            }
            else
            {
                _calibration.SpanDiff = Math.Round(_calibration.SpanMeas - _calibration.SpanRef, 2);
                _calibration.SpanStd = Math.Round(CalculateStandardDeviation(measValues), 2);
                _calibration.ResultFactor = Math.Round((_calibration.SpanMeas - _calibration.SpanRef) / _calibration.SpanDiff, 2);
            }
        }

        public double CalculateStandardDeviation(List<double> data)
        {
            double sum = 0;
            double mean;
            double stdDev = 0;

            if (data.Count > 1)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    sum += data[i];
                }
                mean = sum / data.Count;

                for (int i = 0; i < data.Count; i++)
                {
                    stdDev += Math.Pow(data[i] - mean, 2);
                }
                stdDev = Math.Sqrt(stdDev / (data.Count - 1));

                return stdDev;
            }
            else
            {
                return stdDev;
            }
        }
        public void AssignLabels(List<Control> controls, string calibrationType)
        {
            CalibrationStatusBarZeroControl calibrationStatusBarZero = (CalibrationStatusBarZeroControl)controls.FirstOrDefault(c => c.Name == "CalibrationStatusBarZero")!;
            CalibrationStatusBarSpanControl calibrationStatusBarSpan = (CalibrationStatusBarSpanControl)controls.FirstOrDefault(c => c.Name == "CalibrationStatusBarSpan")!;

            if (calibrationType == "Zero")
            {
                calibrationStatusBarZero.ZeroRef = _calibration.ZeroRef.ToString();
                calibrationStatusBarZero.ZeroMeas = _calibration.ZeroMeas.ToString();
                calibrationStatusBarZero.ZeroDiff = _calibration.ZeroDiff.ToString();
                calibrationStatusBarZero.ZeroStd = _calibration.ZeroStd.ToString();
            }
            else if (calibrationType == "reset")
            {
                calibrationStatusBarZero.ZeroRef = _calibration.ZeroRef.ToString();
                calibrationStatusBarZero.ZeroMeas = _calibration.ZeroMeas.ToString();
                calibrationStatusBarZero.ZeroDiff = _calibration.ZeroDiff.ToString();
                calibrationStatusBarZero.ZeroStd = _calibration.ZeroStd.ToString();
                calibrationStatusBarSpan.SpanRef = _calibration.SpanRef.ToString();
                calibrationStatusBarSpan.SpanMeas = _calibration.SpanMeas.ToString();
                calibrationStatusBarSpan.SpanDiff = _calibration.SpanDiff.ToString();
                calibrationStatusBarSpan.SpanStd = _calibration.SpanStd.ToString();
            }
            else
            {
                calibrationStatusBarSpan.SpanRef = _calibration.SpanRef.ToString();
                calibrationStatusBarSpan.SpanMeas = _calibration.SpanMeas.ToString();
                calibrationStatusBarSpan.SpanDiff = _calibration.SpanDiff.ToString();
                calibrationStatusBarSpan.SpanStd = _calibration.SpanStd.ToString();
            }
        }
    }
}
