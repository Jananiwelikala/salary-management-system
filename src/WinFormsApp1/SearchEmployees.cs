using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class SearchEmployees : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;database=project;uid=root;pwd=Admin123;";

        public SearchEmployees()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            button1.Click += new EventHandler(SearchButton_Click);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string idNumber = textBox1.Text.Trim(); // Changed from MemberID to IDNumber

            if (string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("Please enter an ID Number.");
                return;
            }

            string query = @"
                SELECT m.Name, m.Position, m.Address, m.MobileNumbers, m.IDNumber, od.MonthlyPayment, od.FullPayment
                FROM members m
                LEFT JOIN ot_details od ON m.MemberID = od.MemberID
                WHERE m.IDNumber = @IDNumber
            ";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDNumber", idNumber);
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox2.Text = reader["Name"].ToString();
                            textBox5.Text = reader["Position"].ToString();
                            textBox3.Text = reader["Address"].ToString();
                            textBox4.Text = reader["MobileNumbers"].ToString();
                            textBox6.Text = reader["IDNumber"].ToString();
                            textBox7.Text = reader["MonthlyPayment"].ToString();
                            textBox8.Text = reader["FullPayment"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No records found for the provided ID Number.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Detail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // You can add code here if you need to handle text changes in textBox4.
        }

        private void backbtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }
    }
}
