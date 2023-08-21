namespace ibks.Utils
{
    static public class PageChange
    {
        static public void Change(Panel panel, Form Main, Form ChildForm)
        {
            ChildForm.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(ChildForm);
            ChildForm.Show();

            foreach (Form activeForm in panel.Controls)
            {
                activeForm.Size = panel.Size;
            }
        }
    }
}