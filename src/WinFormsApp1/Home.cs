using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            // Set form to open at specific location
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 200); // Set your desired x, y coordinates

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Basicbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeDetails employeeDetailsForm = new employeeDetails();
            employeeDetailsForm.Show();
        }

        private void OTbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OTdetais otDetailsForm = new OTdetais();
            otDetailsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchEmployees DetailForm = new SearchEmployees();
            DetailForm.Show();
        }
    }
}
