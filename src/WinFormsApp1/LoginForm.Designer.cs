namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Loginlbl = new Button();
            UNlbl = new Label();
            PWlbl = new Label();
            textUN = new TextBox();
            textPW = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            PWCheckbox = new CheckBox();
            loginLabel = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Loginlbl
            // 
            Loginlbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Loginlbl.BackColor = Color.Teal;
            Loginlbl.Cursor = Cursors.Hand;
            Loginlbl.Font = new Font("Calibri Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginlbl.ForeColor = SystemColors.ButtonFace;
            Loginlbl.Location = new Point(72, 552);
            Loginlbl.Name = "Loginlbl";
            Loginlbl.Size = new Size(421, 45);
            Loginlbl.TabIndex = 0;
            Loginlbl.Text = "Login";
            Loginlbl.UseVisualStyleBackColor = false;
            Loginlbl.Click += button1_Click;
            // 
            // UNlbl
            // 
            UNlbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UNlbl.AutoSize = true;
            UNlbl.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            UNlbl.ForeColor = Color.DarkSlateGray;
            UNlbl.Location = new Point(72, 273);
            UNlbl.Name = "UNlbl";
            UNlbl.Size = new Size(143, 35);
            UNlbl.TabIndex = 1;
            UNlbl.Text = "User Name";
            UNlbl.Click += UNlbl_Click;
            // 
            // PWlbl
            // 
            PWlbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PWlbl.AutoSize = true;
            PWlbl.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            PWlbl.ForeColor = Color.DarkSlateGray;
            PWlbl.Location = new Point(72, 365);
            PWlbl.Name = "PWlbl";
            PWlbl.Size = new Size(126, 35);
            PWlbl.TabIndex = 2;
            PWlbl.Text = "Password";
            PWlbl.Click += PWlbl_Click;
            // 
            // textUN
            // 
            textUN.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textUN.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUN.ForeColor = Color.DarkSlateGray;
            textUN.Location = new Point(228, 272);
            textUN.Name = "textUN";
            textUN.Size = new Size(290, 32);
            textUN.TabIndex = 3;
            textUN.TextChanged += textUN_TextChanged;
            // 
            // textPW
            // 
            textPW.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textPW.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPW.ForeColor = Color.DarkSlateGray;
            textPW.Location = new Point(228, 364);
            textPW.Name = "textPW";
            textPW.Size = new Size(290, 32);
            textPW.TabIndex = 4;
            textPW.UseSystemPasswordChar = true;
            textPW.TextChanged += textPW_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.Teal;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(46, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 671);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(PWCheckbox);
            panel2.Controls.Add(loginLabel);
            panel2.Controls.Add(Loginlbl);
            panel2.Controls.Add(textPW);
            panel2.Controls.Add(textUN);
            panel2.Controls.Add(UNlbl);
            panel2.Controls.Add(PWlbl);
            panel2.Location = new Point(536, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 671);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // PWCheckbox
            // 
            PWCheckbox.Anchor = AnchorStyles.Right;
            PWCheckbox.AutoSize = true;
            PWCheckbox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PWCheckbox.ForeColor = Color.DarkSlateGray;
            PWCheckbox.Location = new Point(357, 430);
            PWCheckbox.Name = "PWCheckbox";
            PWCheckbox.Size = new Size(161, 28);
            PWCheckbox.TabIndex = 6;
            PWCheckbox.Text = "Show Password";
            PWCheckbox.UseVisualStyleBackColor = true;
            PWCheckbox.CheckedChanged += PWCheckbox_CheckedChanged;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Calibri", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.LightSeaGreen;
            loginLabel.Location = new Point(72, 111);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(312, 54);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Login to System";
            loginLabel.Click += loginLabel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Location = new Point(100, 100);
            MinimumSize = new Size(1200, 800);
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Loginlbl;
        private Label UNlbl;
        private Label PWlbl;
        private TextBox textUN;
        private TextBox textPW;
        private Panel panel1;
        private Panel panel2;
        private Label loginLabel;
        private CheckBox PWCheckbox;

        private void UNlbl_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }

        private void PWlbl_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }
    }
}
