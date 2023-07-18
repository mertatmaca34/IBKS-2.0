using IBKS_2._0.Properties;

namespace IBKS_2._0.Forms.Pages
{
    public partial class SimulationPage : Form
    {
        Bitmap _autoFrame, _autoFrame2;
        public SimulationPage()
        {
            InitializeComponent();

            _autoFrame = Resources.system_auto1;
            _autoFrame2 = Resources.system_auto2;

            this.BackgroundImage = _autoFrame;
        }

        private void TimerSimulation_Tick(object sender, EventArgs e)
        {
            if (this.BackgroundImage == _autoFrame)
            {
                this.BackgroundImage = _autoFrame2;
            }
            else
            {
                this.BackgroundImage = _autoFrame;
            }
        }
    }
}
