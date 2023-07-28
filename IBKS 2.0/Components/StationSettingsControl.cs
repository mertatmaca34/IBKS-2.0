using System.ComponentModel;

namespace IBKS_2._0.Components
{
    public partial class StationSettingsControl : UserControl
    {
        [Description("Ayar Adı"), Category("IBKS")]
        public string Parameter
        {
            get => LabelParameter.Text;
            set => LabelParameter.Text = value;
        }

        [Description("Ayar Değeri"), Category("IBKS")]
        public string AyarDegeri
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public StationSettingsControl()
        {
            InitializeComponent();
        }
    }
}
