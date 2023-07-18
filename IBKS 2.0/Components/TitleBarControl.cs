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
    public partial class TitleBarControl : UserControl
    {
        [Description("Title Bar Text"), Category("IBKS")]
        public string TitleBarText
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public TitleBarControl()
        {
            InitializeComponent();
        }
    }
}
