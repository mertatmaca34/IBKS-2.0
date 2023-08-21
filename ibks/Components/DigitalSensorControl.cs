using System.ComponentModel;

namespace ibks.Components
{
    public partial class DigitalSensorControl : UserControl
    {
        [Description("Kanal adı"), Category("IBKS")]
        public string SensorName
        {
            get => LabelSensorName.Text;
            set => LabelSensorName.Text = value;
        }

        [Description("Kanal Açıklaması"), Category("IBKS")]
        public string SensorDescription
        {
            get => LabelSensorDescription.Text;
            set => LabelSensorDescription.Text = value;
        }

        [Description("Kanal Durumu"), Category("IBKS")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color SensorStatement
        {
            get => PanelSensorStatement.BackColor;
            set => PanelSensorStatement.BackColor = value;
        }
        public DigitalSensorControl()
        {
            InitializeComponent();
        }
    }
}
