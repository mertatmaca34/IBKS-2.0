using IBKS_2._0.Properties;

namespace IBKS_2._0.Forms.Pages
{
    public partial class SimulationPage : Form
    {
        private readonly Bitmap _autoFrame2, _autoFrame;
        private readonly Bitmap _doorClosed, _doorOpened;

        public SimulationPage()
        {
            InitializeComponent();

            _autoFrame = Resources.system_auto1;
            _autoFrame2 = Resources.system_auto2;

            _doorClosed = Resources.door_closed;
            _doorOpened = Resources.door_opened;

            this.BackgroundImage = _autoFrame;
            PanelDoor.BackgroundImage = _doorClosed;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
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
