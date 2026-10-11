namespace WinFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Companynamelbl = new Label();
            OTbtn = new Button();
            Basicbtn = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Companynamelbl
            // 
            Companynamelbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Companynamelbl.Font = new Font("Calibri", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Companynamelbl.ForeColor = Color.CadetBlue;
            Companynamelbl.Location = new Point(93, 348);
            Companynamelbl.Margin = new Padding(4, 0, 4, 0);
            Companynamelbl.Name = "Companynamelbl";
            Companynamelbl.Size = new Size(1000, 235);
            Companynamelbl.TabIndex = 3;
            Companynamelbl.Text = "Public Administration Salary Managment System";
            Companynamelbl.TextAlign = ContentAlignment.MiddleCenter;
            Companynamelbl.Click += label1_Click;
            // 
            // OTbtn
            // 
            OTbtn.Anchor = AnchorStyles.None;
            OTbtn.BackColor = Color.Teal;
            OTbtn.Cursor = Cursors.Hand;
            OTbtn.FlatStyle = FlatStyle.Popup;
            OTbtn.Font = new Font("Segoe UI", 12F);
            OTbtn.ForeColor = SystemColors.ButtonHighlight;
            OTbtn.Location = new Point(832, 631);
            OTbtn.Margin = new Padding(4, 3, 4, 3);
            OTbtn.Name = "OTbtn";
            OTbtn.Size = new Size(318, 79);
            OTbtn.TabIndex = 1;
            OTbtn.Text = "OT details";
            OTbtn.UseVisualStyleBackColor = false;
            OTbtn.Click += OTbtn_Click;
            // 
            // Basicbtn
            // 
            Basicbtn.Anchor = AnchorStyles.None;
            Basicbtn.BackColor = Color.Teal;
            Basicbtn.Cursor = Cursors.Hand;
            Basicbtn.FlatStyle = FlatStyle.Popup;
            Basicbtn.Font = new Font("Segoe UI", 12F);
            Basicbtn.ForeColor = SystemColors.ButtonHighlight;
            Basicbtn.Location = new Point(434, 622);
            Basicbtn.Margin = new Padding(4, 3, 4, 3);
            Basicbtn.Name = "Basicbtn";
            Basicbtn.Size = new Size(324, 88);
            Basicbtn.TabIndex = 0;
            Basicbtn.Text = "Manage employees details";
            Basicbtn.UseVisualStyleBackColor = false;
            Basicbtn.Click += Basicbtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(25, 627);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(318, 79);
            button1.TabIndex = 4;
            button1.Text = "Search Employee Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(button1);
            Controls.Add(OTbtn);
            Controls.Add(Basicbtn);
            Controls.Add(Companynamelbl);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            ForeColor = SystemColors.ButtonHighlight;
            Location = new Point(200, 200);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            Text = "Home form";
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label Companynamelbl;
        private Button OTbtn;
        private Button Basicbtn;
        private Button button1;
        private PictureBox pictureBox1;
    }
}