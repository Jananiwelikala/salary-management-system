namespace WinFormsApp1
{
    partial class OTdetais
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            backbtn3 = new Button();
            AddOTbtn = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // backbtn3
            // 
            backbtn3.BackColor = Color.Teal;
            backbtn3.Cursor = Cursors.Hand;
            backbtn3.Font = new Font("Calibri", 12F);
            backbtn3.ForeColor = Color.White;
            backbtn3.Location = new Point(21, 27);
            backbtn3.Name = "backbtn3";
            backbtn3.Size = new Size(105, 50);
            backbtn3.TabIndex = 1;
            backbtn3.Text = "< Back";
            backbtn3.UseVisualStyleBackColor = false;
            backbtn3.Click += backbtn3_Click;
            // 
            // AddOTbtn
            // 
            AddOTbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddOTbtn.BackColor = Color.Teal;
            AddOTbtn.Cursor = Cursors.Hand;
            AddOTbtn.Font = new Font("Calibri", 12F);
            AddOTbtn.ForeColor = Color.White;
            AddOTbtn.Location = new Point(996, 27);
            AddOTbtn.Name = "AddOTbtn";
            AddOTbtn.Size = new Size(174, 50);
            AddOTbtn.TabIndex = 3;
            AddOTbtn.Text = "Add OT Details";
            AddOTbtn.UseVisualStyleBackColor = false;
            AddOTbtn.Click += AddOTbtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView2.GridColor = Color.DarkSlateGray;
            dataGridView2.Location = new Point(21, 155);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RightToLeft = RightToLeft.No;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1133, 586);
            dataGridView2.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Member id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Monthly Payments";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "OT Hours";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "OT Payments";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Full Payment";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(808, 27);
            button1.Name = "button1";
            button1.Size = new Size(127, 50);
            button1.TabIndex = 8;
            button1.Text = "Paid";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OTdetais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1182, 753);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(AddOTbtn);
            Controls.Add(backbtn3);
            Location = new Point(10, 10);
            Name = "OTdetais";
            Text = "OTdetais";
            FormClosed += OTdetais_FormClosed;
            Load += OTdetais_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backbtn3;
        private Button AddOTbtn;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button1;
    }
}