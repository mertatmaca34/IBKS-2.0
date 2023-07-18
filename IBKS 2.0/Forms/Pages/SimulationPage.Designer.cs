namespace IBKS_2._0.Forms.Pages
{
    partial class SimulationPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PanelDoor = new Panel();
            TimerSimulation = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // PanelDoor
            // 
            PanelDoor.BackColor = Color.Transparent;
            PanelDoor.BackgroundImage = Properties.Resources.door_closed;
            PanelDoor.BackgroundImageLayout = ImageLayout.None;
            PanelDoor.Location = new Point(947, 616);
            PanelDoor.Name = "PanelDoor";
            PanelDoor.Size = new Size(127, 63);
            PanelDoor.TabIndex = 0;
            // 
            // TimerSimulation
            // 
            TimerSimulation.Enabled = true;
            TimerSimulation.Interval = 1000;
            TimerSimulation.Tick += TimerSimulation_Tick;
            // 
            // SimulationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.system_auto1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1170, 677);
            Controls.Add(PanelDoor);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SimulationPage";
            Text = "SimulationPage";
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDoor;
        private System.Windows.Forms.Timer TimerSimulation;
    }
}