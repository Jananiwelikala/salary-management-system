using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class employeeDetails : Form
    {
        private const string connectionString = "server=localhost;database=project;uid=root;pwd=Admin123;"; // Replace with your actual connection string

        public employeeDetails()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingMembers addingMembersForm = new AddingMembers();
            addingMembersForm.Show();
        }

        private void employeeDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM members";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void employeeDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Close the application when employeeDetails form is closed
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell content click events if needed
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                AddingMembers addingMembersForm = new AddingMembers
                {
                    MemberID = selectedRow.Cells["MemberID"].Value.ToString(),
                    Name = selectedRow.Cells["Name"].Value.ToString(),
                    Position = selectedRow.Cells["Position"].Value.ToString(),
                    Address = selectedRow.Cells["Address"].Value.ToString(),
                    MobileNumbers = selectedRow.Cells["MobileNumbers"].Value.ToString(),
                    Email = selectedRow.Cells["Email"].Value.ToString(),
                    IDNumber = selectedRow.Cells["IDNumber"].Value.ToString(),
                    Gender = selectedRow.Cells["Gender"].Value.ToString(),
                    IsOvertimeEmployee = Convert.ToBoolean(selectedRow.Cells["IsOvertimeEmployee"].Value),
                    IsEditMode = true
                };

                this.Hide();
                addingMembersForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string memberId = selectedRow.Cells["MemberID"].Value.ToString();

                // Delete related rows in ot_details first
                string deleteOTQuery = "DELETE FROM ot_details WHERE MemberID = @MemberID";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand(deleteOTQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MemberID", memberId);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            // Proceed to delete from members only if rows in ot_details were successfully deleted
                            if (rowsAffected >= 0)
                            {
                                // Now delete from members table
                                string deleteMemberQuery = "DELETE FROM members WHERE MemberID = @MemberID";

                                using (MySqlCommand deleteMemberCommand = new MySqlCommand(deleteMemberQuery, connection))
                                {
                                    deleteMemberCommand.Parameters.AddWithValue("@MemberID", memberId);

                                    int membersRowsAffected = deleteMemberCommand.ExecuteNonQuery();

                                    if (membersRowsAffected > 0)
                                    {
                                        MessageBox.Show("Member deleted successfully.");
                                        LoadData(); // Refresh the data grid view
                                    }
                                    else
                                    {
                                        MessageBox.Show("No member found with the specified ID.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete related OT details.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

    }

}
