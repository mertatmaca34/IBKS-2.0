using System.ComponentModel;

namespace ibks.Components
{
    public partial class DigitalSensorBar : UserControl
    {
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

        [Description("Sistem Durumu"), Category("IBKS")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color SystemStatementColor
        {
            get => TableLayoutPanelSystemStatement.BackColor;
            set => TableLayoutPanelSystemStatement.BackColor = value;
        }

        [Description("Sistem Durumu Açıklaması"), Category("IBKS")]
        public string SystemStatementText
        {
            get => LabelSystemStatementDescription.Text;
            set => LabelSystemStatementDescription.Text = value;
        }

        [Description("Sistem Durumu Başlığı Yazı Rengi"), Category("IBKS")]
        public Color SystemStatementTitleTextColor
        {
            get => LabelSystemStatementTitle.ForeColor;
            set => LabelSystemStatementTitle.ForeColor = value;
        }


        [Description("Sistem Durumu Açıklaması Yazı Rengi"), Category("IBKS")]
        public Color SystemStatementDescriptionTextColor
        {
            get => LabelSystemStatementDescription.ForeColor;
            set => LabelSystemStatementDescription.ForeColor = value;
        }


        public DigitalSensorBar()
        {
            InitializeComponent();
        }
    }
}
