using Business.Abstract;
using Business.Constants;
using Entities.Concrete;

namespace ibks.Forms.Pages.Settings
{
    public partial class ApiSettingsPage : Form
    {
        private readonly IApiService _apiManager;

        public ApiSettingsPage(IApiService apiService)
        {
            _apiManager = apiService;

            InitializeComponent();
        }

        private void ApiSettingsPage_Load(object sender, EventArgs e)
        {
            var result = _apiManager.Get();

            if (result.Success)
            {
                SettingsControlApiUrl.AyarDegeri = result.Data.ApiAdress;
                SettingsControlUsername.AyarDegeri = result.Data.UserName;
                SettingsControlPassword.AyarDegeri = result.Data.Password;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Api api = new()
                {
                    ApiAdress = SettingsControlApiUrl.AyarDegeri,
                    UserName = SettingsControlUsername.AyarDegeri,
                    Password = SettingsControlPassword.AyarDegeri,
                };

                var res = _apiManager.Add(api);

                MessageBox.Show(res.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.CalibrationLimitIncompleteInfo);
            }
        }

    }
}