using Business.Abstract;
using Entities.Concrete;

namespace ibks.Forms.Pages.Settings
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

            if (result.Data != null)
            {
                StationSettingsControlStationName.AyarDegeri = result.Data.StationName;
                StationSettingsControlStationId.AyarDegeri = result.Data.StationId.ToString();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Station station = new()
            {
                StationId = new Guid(StationSettingsControlStationId.AyarDegeri),
                StationName = StationSettingsControlStationName.AyarDegeri,
            };

            var res = _stationManager.Add(station);

            MessageBox.Show(res.Message);
        }
    }
}
