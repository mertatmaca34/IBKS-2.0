namespace IBKS_2._0.Forms
{
    partial class LoginForm
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
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            TextBoxEMail = new TextBox();
            TextBoxPassword = new TextBox();
            ButtonLogin = new Button();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(TextBoxEMail, 0, 1);
            tableLayoutPanel4.Controls.Add(TextBoxPassword, 0, 2);
            tableLayoutPanel4.Controls.Add(ButtonLogin, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(8);
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 270F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.Size = new Size(800, 450);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.male_user_256px;
            pictureBox1.Location = new Point(11, 38);
            pictureBox1.Margin = new Padding(3, 30, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(778, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TextBoxEMail
            // 
            TextBoxEMail.Anchor = AnchorStyles.None;
            TextBoxEMail.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxEMail.Location = new Point(257, 288);
            TextBoxEMail.Name = "TextBoxEMail";
            TextBoxEMail.PlaceholderText = "Email";
            TextBoxEMail.Size = new Size(286, 29);
            TextBoxEMail.TabIndex = 0;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Anchor = AnchorStyles.None;
            TextBoxPassword.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(257, 338);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PlaceholderText = "Şifre";
            TextBoxPassword.Size = new Size(286, 29);
            TextBoxPassword.TabIndex = 1;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Anchor = AnchorStyles.None;
            ButtonLogin.BackColor = Color.FromArgb(0, 131, 200);
            ButtonLogin.FlatAppearance.BorderColor = Color.FromArgb(235, 235, 235);
            ButtonLogin.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            ButtonLogin.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(254, 390);
            ButtonLogin.Margin = new Padding(8);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(291, 39);
            ButtonLogin.TabIndex = 4;
            ButtonLogin.Text = "Giriş Yap";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox1;
        private TextBox TextBoxEMail;
        private Button ButtonLogin;
        private TextBox TextBoxPassword;
    }
}