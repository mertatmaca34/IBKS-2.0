using System.ComponentModel;

namespace IBKS_2._0.Components
{
    public partial class CalibrationStatusBarSpanControl : UserControl
    {
        [Description("Span Ref Değeri"), Category("IBKS")]
        public string SpanRef
        {
            get => LabelSpanRef.Text;
            set => LabelSpanRef.Text = value;
        }

        [Description("Span Meas Değeri"), Category("IBKS")]
        public string SpanMeas
        {
            get => LabelSpanMeas.Text;
            set => LabelSpanMeas.Text = value;
        }

        [Description("Span Diff Değeri"), Category("IBKS")]
        public string SpanDiff
        {
            get => LabelSpanDiff.Text;
            set => LabelSpanDiff.Text = value;
        }

        [Description("Span Std Değeri"), Category("IBKS")]
        public string SpanStd
        {
            get => LabelSpanStd.Text;
            set => LabelSpanStd.Text = value;
        }
        public CalibrationStatusBarSpanControl()
        {
            InitializeComponent();
        }
    }
}
