using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class OTdetais : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;database=project;uid=root;pwd=Admin123;";

        public OTdetais()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void OTdetais_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridView2.Rows.Clear();

            string query = @"
                SELECT m.MemberID, m.Name, od.MonthlyPayment, od.OTHours, od.OTPayment, od.FullPayment
                FROM members m
                LEFT JOIN ot_details od ON m.MemberID = od.MemberID
            ";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView2.Rows.Add(
                                reader["MemberID"].ToString(), // Display MemberID in the hidden column
                                reader["Name"].ToString(), // Display Name
                                reader["MonthlyPayment"].ToString(), // Display MonthlyPayment
                                reader["OTHours"].ToString(), // Display OTHours
                                reader["OTPayment"].ToString(), // Display OTPayment
                                reader["FullPayment"].ToString() // Display FullPayment
                            );
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

        private void AddOTbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected MemberID and Name from the DataGridView
                string memberID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();

                AddOTHours addOTHoursForm = new AddOTHours(memberID, name);
                addOTHoursForm.FormClosed += AddOTHoursForm_FormClosed;
                addOTHoursForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void AddOTHoursForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateDataGridView();
        }

        private void backbtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void OTdetais_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Paidbtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string memberID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                string query = @"
            UPDATE ot_details
            SET OTHours = 0, OTPayment = 0, FullPayment = 0
            WHERE MemberID = @MemberID
        ";

                try
                {
                    // Open connection and execute the command inside a using block
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@MemberID", memberID);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("OT details updated successfully.");
                                // Optionally, refresh the DataGridView
                                PopulateDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("No records updated.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

    }
}
