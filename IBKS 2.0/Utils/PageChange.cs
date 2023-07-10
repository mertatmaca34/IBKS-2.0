using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBKS_2._0.Utils
{
    static public class PageChange
    {
        static public void Change(Form Main, Form ChildForm)
        {
            ChildForm.MdiParent = Main;
            ChildForm.Show();
        }
    }
}
