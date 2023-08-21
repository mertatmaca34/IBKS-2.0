using System.ComponentModel;

namespace ibks.Components
{
    public partial class SettingsBarControl : UserControl
    {
        [Description("Ayar Adı"), Category("IBKS")]
        public string AyarAdi
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

        public SettingsBarControl()
        {
            InitializeComponent();
        }
    }
}
