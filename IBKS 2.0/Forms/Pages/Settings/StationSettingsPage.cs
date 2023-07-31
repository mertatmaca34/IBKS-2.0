using Business.Abstract;
using Business.Constants;
using Entities.Concrete;

namespace IBKS_2._0.Forms.Pages.Settings
{
    public partial class StationSettingsPage : Form
    {
        readonly IStationService _stationManager;

        public StationSettingsPage(IStationService stationManager)
        {
            InitializeComponent();

            _stationManager = stationManager;
        }

        private void StationSettingsPage_Load(object sender, EventArgs e)
        {
            var result = _stationManager.Get();

            if (result.Success)
            {
                StationSettingsControlStationName.AyarDegeri = result.Data.StationName;
                StationSettingsControlStationId.AyarDegeri = result.Data.StationId.ToString();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Station station = new()
                {
                    StationId = new Guid(StationSettingsControlStationName.AyarDegeri),
                    StationName = StationSettingsControlStationId.AyarDegeri,
                };

                var res = _stationManager.Add(station);

                MessageBox.Show(res.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.CalibrationLimitIncompleteInfo);
            }
        }
    }
}
