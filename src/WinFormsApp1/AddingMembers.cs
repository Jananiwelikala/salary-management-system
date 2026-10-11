using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddingMembers : Form
    {
        private const string connectionString = "server=localhost;database=project;uid=root;pwd=Admin123;"; // Replace with your actual connection string

        public AddingMembers()
        {
            InitializeComponent();
        }

        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string MobileNumbers { get; set; }
        public string Email { get; set; }
        public string IDNumber { get; set; }
        public string Gender { get; set; }
        public bool IsOvertimeEmployee { get; set; }
        public bool IsEditMode { get; set; } = false;

        private void AddingMembers_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                // Populate form fields with the passed data for editing
                Nametxtbox.Text = Name;
                Positiontxtbox.Text = Position;
                Addresstxtbox.Text = Address;
                Mobilenumberstxtbox.Text = MobileNumbers;
                Emailtxtbox.Text = Email;
                IDtxtbox.Text = IDNumber;
                if (Gender == "Male") Malecheckbox.Checked = true;
                else if (Gender == "Female") Femalecheckbox.Checked = true;
                
                Yescheckbox.Checked = IsOvertimeEmployee;
                Nocheckbox.Checked = !IsOvertimeEmployee;
            }
            else
            {
                // Clear form fields for adding new member
                ClearForm();
            }
        }

        private void backbtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeDetails employeeDetailsForm = new employeeDetails();
            employeeDetailsForm.Show();
        }

        private void AddingMembers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Close the application when AddingMembers form is closed
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string name = Nametxtbox.Text;
            string position = Positiontxtbox.Text;
            string address = Addresstxtbox.Text;
            string mobileNumbers = Mobilenumberstxtbox.Text;
            string email = Emailtxtbox.Text;
            string idNumber = IDtxtbox.Text;
            string gender = Malecheckbox.Checked ? "Male" : (Femalecheckbox.Checked ? "Female" : "Other");
            bool isOvertimeEmployee = Yescheckbox.Checked;

            string query;

            if (IsEditMode)
            {
                query = @"UPDATE members 
                         SET Name = @Name, Position = @Position, Address = @Address, MobileNumbers = @MobileNumbers, Email = @Email, 
                             IDNumber = @IDNumber, Gender = @Gender, IsOvertimeEmployee = @IsOvertimeEmployee
                         WHERE MemberID = @MemberID";
            }
            else
            {
                query = @"INSERT INTO members (Name, Position, Address, MobileNumbers, Email, IDNumber, Gender, IsOvertimeEmployee)
                         VALUES (@Name, @Position, @Address, @MobileNumbers, @Email, @IDNumber, @Gender, @IsOvertimeEmployee)";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@MobileNumbers", mobileNumbers);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@IDNumber", idNumber);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@IsOvertimeEmployee", isOvertimeEmployee);

                    if (IsEditMode)
                    {
                        command.Parameters.AddWithValue("@MemberID", MemberID);
                    }

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully!");
                        this.Hide();
                        employeeDetails employeeDetailsForm = new employeeDetails();
                        employeeDetailsForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void ClearForm()
        {
            Nametxtbox.Clear();
            Positiontxtbox.Clear();
            Addresstxtbox.Clear();
            Mobilenumberstxtbox.Clear();
            Emailtxtbox.Clear();
            IDtxtbox.Clear();
            Malecheckbox.Checked = false;
            Femalecheckbox.Checked = false;
            
            Yescheckbox.Checked = false;
            Nocheckbox.Checked = false;
        }

        private void Yescheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Yescheckbox.Checked)
            {
                Nocheckbox.Checked = false;
            }
        }

        private void Nocheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Nocheckbox.Checked)
            {
                Yescheckbox.Checked = false;
            }
        }

        private void Malecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Malecheckbox.Checked)
            {
                Femalecheckbox.Checked=false;
            }
        }

        private void Femalecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(Femalecheckbox.Checked)
            {
                Malecheckbox.Checked = false;
            }
        }
    }
}
