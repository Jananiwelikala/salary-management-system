namespace WinFormsApp1
{
    partial class employeeDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            backbtn = new Button();
            Addbtn = new Button();
            Editbtn = new Button();
            Deletebtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.Teal;
            backbtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backbtn.ForeColor = Color.White;
            backbtn.Location = new Point(12, 11);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(83, 40);
            backbtn.TabIndex = 0;
            backbtn.Text = "< Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Addbtn.AutoSize = true;
            Addbtn.BackColor = Color.Teal;
            Addbtn.Cursor = Cursors.Hand;
            Addbtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(841, 11);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(96, 40);
            Addbtn.TabIndex = 1;
            Addbtn.Text = "+Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // Editbtn
            // 
            Editbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Editbtn.BackColor = Color.Teal;
            Editbtn.Cursor = Cursors.Hand;
            Editbtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Editbtn.ForeColor = Color.White;
            Editbtn.Location = new Point(971, 11);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(87, 40);
            Editbtn.TabIndex = 2;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Deletebtn.BackColor = Color.Teal;
            Deletebtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.White;
            Deletebtn.Location = new Point(1084, 11);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(86, 40);
            Deletebtn.TabIndex = 3;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DarkSlateGray;
            dataGridView1.Location = new Point(12, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1158, 652);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // employeeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1182, 753);
            Controls.Add(dataGridView1);
            Controls.Add(Deletebtn);
            Controls.Add(Editbtn);
            Controls.Add(Addbtn);
            Controls.Add(backbtn);
            Cursor = Cursors.Hand;
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Location = new Point(10, 10);
            Name = "employeeDetails";
            Text = "employeeDetails";
            FormClosed += employeeDetails_FormClosed;
            Load += employeeDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
