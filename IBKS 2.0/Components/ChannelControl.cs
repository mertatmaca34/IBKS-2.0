using System.ComponentModel;

namespace IBKS_2._0.Components
{
    public partial class ChannelControl : UserControl
    {
        [Description("Anlık değer verisi"), Category("IBKS")]
        public string InstantData
        {
            get => LabelInstantData.Text;
            set => LabelInstantData.Text = value;
        }

        [Description("60 dakikalık ortalama değer verisi"), Category("IBKS")]
        public string AvgDataOf60Min
        {
            get => LabelAvgOf60Min.Text;
            set => LabelAvgOf60Min.Text = value;
        }

        [Description("Kanal adı"), Category("IBKS")]
        public string ChannelName
        {
            get => LabelChannelName.Text;
            set => LabelChannelName.Text = value;
        }

        [Description("Kanal Açıklaması"), Category("IBKS")]
        public string ChannelDescription
        {
            get => LabelChannelDescription.Text;
            set => LabelChannelDescription.Text = value;
        }

        [Description("Kanal Durumu"), Category("IBKS")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color ChannelStatement
        {
            get => PanelStatement.BackColor;
            set => PanelStatement.BackColor = value;
        }

        [Description("1. Ayraç"), Category("IBKS")]
        [DefaultValue(typeof(bool), "true")]
        public bool PanelSplit1Visible
        {
            get => PanelSplit1.Visible;
            set => PanelSplit1.Visible = value;
        }

        [Description("2. Ayraç"), Category("IBKS")]
        [DefaultValue(typeof(bool), "true")]
        public bool PanelSplit2Visible
        {
            get => PanelSplit2.Visible;
            set => PanelSplit2.Visible = value;
        }

        public ChannelControl()
        {
            InitializeComponent();
        }
    }
}
