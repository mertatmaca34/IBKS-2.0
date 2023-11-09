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

            if (ChildForm.Name == "SimulationPage")
            {
                Main.WindowState = FormWindowState.Normal;
                Main.MaximumSize = new Size(1280, 720);

                Main.MaximizeBox = false;
            }
            else
            {
                Main.MaximumSize = new Size(0, 0);

                Main.MaximizeBox = true;
            }
        }
    }
}