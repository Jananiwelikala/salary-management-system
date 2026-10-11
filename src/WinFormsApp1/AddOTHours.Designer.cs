namespace WinFormsApp1
{
    partial class AddOTHours
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.2000008F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(98, 138);
            label1.Name = "label1";
            label1.Size = new Size(245, 28);
            label1.TabIndex = 0;
            label1.Text = "Monthly Payments (Rs.):";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 10.2F);
            textBox1.ForeColor = Color.DarkSlateGray;
            textBox1.Location = new Point(374, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 28);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.2000008F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(98, 201);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 2;
            label2.Text = "OT Hours :";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 10.2F);
            textBox2.ForeColor = Color.DarkSlateGray;
            textBox2.Location = new Point(374, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 28);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.2000008F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(98, 266);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 5;
            label4.Text = "OT Payments (Rs.):";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 10.2F);
            textBox3.ForeColor = Color.DarkSlateGray;
            textBox3.Location = new Point(374, 268);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(404, 28);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(230, 397);
            button1.Name = "button1";
            button1.Size = new Size(364, 46);
            button1.TabIndex = 8;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 10.2F);
            textBox4.ForeColor = Color.DarkSlateGray;
            textBox4.Location = new Point(374, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(404, 28);
            textBox4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.2000008F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(98, 82);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 10;
            label3.Text = "Name :";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 10.2F);
            textBox5.ForeColor = Color.DarkSlateGray;
            textBox5.Location = new Point(374, 323);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(404, 28);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.2000008F, FontStyle.Bold);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(98, 321);
            label5.Name = "label5";
            label5.Size = new Size(181, 28);
            label5.TabIndex = 12;
            label5.Text = "fullPayment (Rs.):";
            // 
            // AddOTHours
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(862, 472);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Calibri", 10.2F);
            Location = new Point(10, 10);
            Name = "AddOTHours";
            Text = "AddOTHours";
            Load += AddOTHours_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Label label5;
    }
}