namespace IBKS_2._0.Utils
{
    static public class PageChange
    {
        static public void Change(Form Main, Form ChildForm)
        {
            ChildForm.MdiParent = Main;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.Show();
        }
    }
}