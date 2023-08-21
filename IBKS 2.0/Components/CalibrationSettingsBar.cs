using System.Collections.Specialized;
using System.ComponentModel;

namespace ibks.Components
{
    public partial class CalibrationSettingsBar : UserControl
    {
        [Description("Parametre"), Category("IBKS")]
        public string Parameter
        {
            get => LabelParameter.Text;
            set => LabelParameter.Text = value;
        }

        [Description("Zero Referans Değeri"), Category("IBKS")]
        public string ZeroRef
        {
            get => ComboBoxZeroRef.Text;
            set => ComboBoxZeroRef.Text = value;
        }

        [Description("Zero Süre Değeri"), Category("IBKS")]
        public string ZeroTime
        {
            get => ComboBoxZeroTime.Text;
            set => ComboBoxZeroTime.Text = value;
        }

        [Description("Span Referans Değeri"), Category("IBKS")]
        public string SpanRef
        {
            get => ComboBoxSpanRef.Text;
            set => ComboBoxSpanRef.Text = value;
        }

        [Description("Span Süre Değeri"), Category("IBKS")]
        public string SpanTime
        {
            get => ComboBoxSpanTime.Text;
            set => ComboBoxSpanTime.Text = value;
        }

        public CalibrationSettingsBar()
        {
            InitializeComponent();
        }
    }
}
