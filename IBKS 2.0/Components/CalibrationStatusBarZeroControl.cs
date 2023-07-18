using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBKS_2._0.Components
{
    public partial class CalibrationStatusBarZeroControl : UserControl
    {
        [Description("Zero Ref Değeri"), Category("IBKS")]
        public string ZeroRef
        {
            get => LabelZeroRef.Text;
            set => LabelZeroRef.Text = value;
        }

        [Description("Zero Meas Değeri"), Category("IBKS")]
        public string ZeroMeas
        {
            get => LabelZeroMeas.Text;
            set => LabelZeroMeas.Text = value;
        }

        [Description("Zero Diff Değeri"), Category("IBKS")]
        public string ZeroDiff
        {
            get => LabelZeroDiff.Text;
            set => LabelZeroDiff.Text = value;
        }

        [Description("Zero Std Değeri"), Category("IBKS")]
        public string ZeroStd
        {
            get => LabelZeroStd.Text;
            set => LabelZeroStd.Text = value;
        }

        public CalibrationStatusBarZeroControl()
        {
            InitializeComponent();
        }
    }
}
