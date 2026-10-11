using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class AddOTHours : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;database=project;uid=root;pwd=Admin123;";
        private string memberID;

        public AddOTHours(string memberID, string name)
        {
            InitializeComponent();
            textBox4.Text = name; // Displaying Name in the TextBox
            this.memberID = memberID;
            connection = new MySqlConnection(connectionString);
            LoadOTDetails();
            // Attach event handlers to the textboxes
            textBox1.TextChanged += textBox1_TextChanged;
            textBox3.TextChanged += textBox3_TextChanged;
        }

        private void LoadOTDetails()
        {
            string query = "SELECT MonthlyPayment, OTHours, OTPayment, FullPayment FROM ot_details WHERE MemberID = @MemberID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);

                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["MonthlyPayment"].ToString();
                            textBox2.Text = reader["OTHours"].ToString();
                            textBox3.Text = reader["OTPayment"].ToString();
                            // Calculate and display FullPayment based on retrieved values
                            CalculateFullPayment();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateFullPayment();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalculateFullPayment();
        }

        private void CalculateFullPayment()
        {
            string monthlyPaymentText = textBox1.Text.Trim();
            string otPaymentText = textBox3.Text.Trim();

            decimal monthlyPaymentValue = !string.IsNullOrEmpty(monthlyPaymentText) ? decimal.Parse(monthlyPaymentText) : 0;
            decimal otPaymentValue = !string.IsNullOrEmpty(otPaymentText) ? decimal.Parse(otPaymentText) : 0;

            decimal fullPayment = monthlyPaymentValue + otPaymentValue;
            textBox5.Text = fullPayment.ToString(); // Display calculated FullPayment
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string monthlyPayment = textBox1.Text.Trim();
            string otHours = textBox2.Text.Trim();
            string otPayment = textBox3.Text.Trim();
            string fullPayment = textBox5.Text.Trim(); // Use textBox5 for FullPayment

            decimal monthlyPaymentValue = !string.IsNullOrEmpty(monthlyPayment) ? decimal.Parse(monthlyPayment) : 0;
            int otHoursValue = !string.IsNullOrEmpty(otHours) ? int.Parse(otHours) : 0;
            decimal otPaymentValue = !string.IsNullOrEmpty(otPayment) ? decimal.Parse(otPayment) : 0;
            decimal fullPaymentValue = !string.IsNullOrEmpty(fullPayment) ? decimal.Parse(fullPayment) : 0;

            // Determine whether to INSERT or UPDATE based on whether the record exists
            if (RecordExists(memberID))
            {
                // Update existing record
                UpdateOTDetails(memberID, monthlyPaymentValue, otHoursValue, otPaymentValue, fullPaymentValue);
            }
            else
            {
                // Insert new record
                InsertOTDetails(memberID, monthlyPaymentValue, otHoursValue, otPaymentValue, fullPaymentValue);
            }
        }

        private bool RecordExists(string memberID)
        {
            string query = "SELECT COUNT(*) FROM ot_details WHERE MemberID = @MemberID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        private void UpdateOTDetails(string memberID, decimal monthlyPayment, int otHours, decimal otPayment, decimal fullPayment)
        {
            string query = @"
                UPDATE ot_details
                SET
                    MonthlyPayment = @MonthlyPayment,
                    OTHours = @OTHours,
                    OTPayment = @OTPayment,
                    FullPayment = @FullPayment
                WHERE MemberID = @MemberID
            ";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.Parameters.AddWithValue("@MonthlyPayment", monthlyPayment);
                    command.Parameters.AddWithValue("@OTHours", otHours);
                    command.Parameters.AddWithValue("@OTPayment", otPayment);
                    command.Parameters.AddWithValue("@FullPayment", fullPayment);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Data updated successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void InsertOTDetails(string memberID, decimal monthlyPayment, int otHours, decimal otPayment, decimal fullPayment)
        {
            string query = @"
                INSERT INTO ot_details (MemberID, Name, MonthlyPayment, OTHours, OTPayment, FullPayment)
                VALUES (@MemberID, @Name, @MonthlyPayment, @OTHours, @OTPayment, @FullPayment)
            ";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.Parameters.AddWithValue("@Name", textBox4.Text); // Ensure Name is passed correctly
                    command.Parameters.AddWithValue("@MonthlyPayment", monthlyPayment);
                    command.Parameters.AddWithValue("@OTHours", otHours);
                    command.Parameters.AddWithValue("@OTPayment", otPayment);
                    command.Parameters.AddWithValue("@FullPayment", fullPayment);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddOTHours_Load(object sender, EventArgs e)
        {

        }

        

    }
}
