using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.API;
using ibks.Utils;
using WebAPI.Abstract;

namespace ibks.Forms.Pages
{
    public partial class CalibrationPage : Form
    {
        private readonly ICalibrationService _calibrationManager;
        private readonly ICalibrationLimitService _calibrationLimitManager;
        private readonly IStationService _stationManager;
        private readonly IApiService _apiManager;
        private readonly ISendCalibrationController _sendCalibrationController;

        readonly CalibrationOps _calibrationOps;

        readonly List<Control> _controls;

        public CalibrationPage(ICalibrationService calibrationManager, IStationService stationManager, ICalibrationLimitService calibrationLimitManager, IApiService apiManager, ISendCalibrationController sendCalibrationController)
        {
            _calibrationManager = calibrationManager;
            _stationManager = stationManager;
            _calibrationLimitManager = calibrationLimitManager;
            _sendCalibrationController = sendCalibrationController;
            _controls = new List<Control>();

            InitializeComponent();
            _apiManager = apiManager;

            _calibrationOps = new CalibrationOps(_stationManager, _calibrationManager, _sendCalibrationController, _calibrationLimitManager);
        }

        private void CalibrationPage_Load(object sender, EventArgs e)
        {
            AssignLastCalibrations();
            AssignRandomStartValues();

            _controls.Add(CalibrationStatusBarZero);
            _controls.Add(CalibrationStatusBarSpan);
            _controls.Add(ChartCalibration);
            _controls.Add(TitleBarControlActiveCalibration);
            _controls.Add(TitleBarControlTimeRemain);
        }

        private void AssignLastCalibrations()
        {
            LabelPhLastCalibration.Text = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Ph");
            LabelIletkenlikLastCalibration.Text = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Iletkenlik");
            LabelAkmLastCalibration.Text = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Akm");
            LabelKoiLastCalibration.Text = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Koi");
        }

        private void AssignRandomStartValues()
        {
            Random random = new();

            for (double x = 0; x <= 3; x += 0.5)
            {
                double calibrationValue = Math.Sin(x) + random.NextDouble();
                double referenceValue = 0;

                ChartCalibration.Series["Kalibrasyon Değeri"].Points.AddXY(x, calibrationValue);
                ChartCalibration.Series["Referans Değeri"].Points.AddXY(x, referenceValue);
            }
        }

        private void ButtonAkmZero_Click(object sender, EventArgs e)
        {
            var getHaziranCalibration = _calibrationManager.GetAll().Data;

            var stationId = _stationManager.Get().Data.StationId;
            foreach (var item in getHaziranCalibration)
            {
                SendCalibration data = new SendCalibration
                {
                    CalibrationDate = item.TimeStamp,
                    Stationid = stationId,
                    DBColumnName = item.Parameter,
                    ZeroRef = item.ZeroRef,
                    ZeroMeas = item.ZeroMeas,
                    ZeroDiff = item.ZeroDiff,
                    ZeroSTD = item.ZeroStd,
                    SpanRef = item.ZeroRef,
                    SpanMeas = item.ZeroMeas,
                    SpanDiff = item.ZeroDiff,
                    SpanSTD = item.ZeroStd,
                    ResultFactor = item.ResultFactor,
                    ResultZero = item.IsItValid,
                    ResultSpan = item.IsItValid,
                };

                var res = _sendCalibrationController.SendCalibration(data);
            }

            var calibrationLimits = _calibrationLimitManager.Get(x => x.Parameter == "Akm");

            if (calibrationLimits != null)
            {
                //_calibrationOps.StartCalibration("AKM", "Zero", calibrationLimits.Data.ZeroTimeStamp, _controls);
            }
        }

        private void ButtonKoiZero_Click(object sender, EventArgs e)
        {
            var calibrationLimits = _calibrationLimitManager.Get(x => x.Parameter == "Koi");

            if (calibrationLimits != null)
            {
                _calibrationOps.StartCalibration("KOi", "Zero", calibrationLimits.Data.ZeroTimeStamp, _controls);
            }
        }

        private void ButtonPhZero_Click(object sender, EventArgs e)
        {
            var calibrationLimits = _calibrationLimitManager.Get(x => x.Parameter == "Ph");

            if (calibrationLimits != null)
            {
                _calibrationOps.StartCalibration("pH", "Zero", calibrationLimits.Data.ZeroTimeStamp, _controls);
            }
        }

        private void ButtonPhSpan_Click(object sender, EventArgs e)
        {
            var calibrationLimits = _calibrationLimitManager.Get(x => x.Parameter == "Ph");

            if (calibrationLimits != null)
            {
                _calibrationOps.StartCalibration("pH", "Span", calibrationLimits.Data.SpanTimeStamp, _controls);
            }
        }

        private void ButtonIletkenlikZero_Click(object sender, EventArgs e)
        {
            var calibrationLimits = _calibrationLimitManager.Get(x => x.Parameter == "Iletkenlik");

            if (calibrationLimits != null)
            {
                _calibrationOps.StartCalibration("Iletkenlik", "Zero", calibrationLimits.Data.ZeroTimeStamp, _controls);
            }
        }

        private void ButtonIletkenlikSpan_Click(object sender, EventArgs e)
        {
            var calibrationLimits = _calibrationLimitManager.Get(x => x.Parameter == "Iletkenlik");

            if (calibrationLimits != null)
            {
                _calibrationOps.StartCalibration("Iletkenlik", "Span", calibrationLimits.Data.SpanTimeStamp, _controls);
            }
        }

    }
}