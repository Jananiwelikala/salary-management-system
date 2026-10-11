using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private Image backgroundImage;

        public LoginForm()
        {
            InitializeComponent();
            InitializeBackgroundImage();
            SetDoubleBuffering();

            // Set form to open at specific location
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100); // Set your desired x, y coordinates

            // Add event handler for the checkbox
            PWCheckbox.CheckedChanged += new EventHandler(CheckBoxShowPassword_CheckedChanged);
        }

        private void InitializeBackgroundImage()
        {
            try
            {
                // Load the background image from resources
                backgroundImage = Properties.Resources.background; // Ensure 'background' matches the resource name
                panel1.BackgroundImage = backgroundImage;
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading background image: " + ex.Message);
            }
        }

        private void SetDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textUN.Text;
            string passWord = textPW.Text;

            // Database connection string (update with your database details)
            string connectionString = "server=localhost;database=project;uid=root;pwd=Admin123;";

            // Query to check the username and password
            string query = "SELECT COUNT(1) FROM users WHERE Username=@UserName AND Password=@Password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", passWord);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        // Hide the login form
                        this.Hide();

                        // Open the home form
                        Home obj = new Home();
                        obj.StartPosition = FormStartPosition.Manual;
                        obj.Location = new Point(200, 200); // Set your desired x, y coordinates
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login not successful");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the password field's UseSystemPasswordChar property
            textPW.UseSystemPasswordChar = !PWCheckbox.Checked;
        }

        private void textUN_TextChanged(object sender, EventArgs e)
        {
            // This can be left empty or used for additional logic
        }

        private void textPW_TextChanged(object sender, EventArgs e)
        {
            // This can be left empty or used for additional logic
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Perform any necessary loading actions here
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting logic can be added here
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting logic can be added here
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            // Event handler for label click if needed
        }

        private void PWCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Event handler for checkbox changed if needed
        }
    }
}
