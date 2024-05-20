using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Vehicle_Track_Secure_Parking_System
{
    public partial class LoginForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void RegLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private bool IsValidUsername(string username)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-z0-9]+$");
        }

        private string DetermineRole(string role)
        {
            if (role.Equals("cashier", StringComparison.OrdinalIgnoreCase))
            {
                return "Cashier";
            }
            else
            {
                return "Admin";
            }
        }

        private void OpenFormsForRole(string role)
        {
            switch (role.ToLower())
            {
                case "admin":
                    OpenAdminForm();
                    break;
                case "cashier":
                    OpenCashierForm();
                    break;
                default:
                    MessageBox.Show("Role not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void OpenAdminForm()
        {
            AdminProfile adminForm = new AdminProfile();
            adminForm.Show();
        }

        private void OpenCashierForm()
        {
            CashiersProfile cashierForm = new CashiersProfile();
            cashierForm.Show();
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            // Check if username and password fields are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate username
            if (IsValidUsername(username))
            {
                lblMessage.Text = "Username is valid!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Invalid username! Only lowercase letters and numbers are allowed.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Check credentials against the database
            try
            {
                string selectQuery = "SELECT Role FROM vt_db.personal_info WHERE Username = @Username AND Password = @Password";
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=;database=vt_db"))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["Role"].ToString();
                                this.Hide();
                                string userRole = DetermineRole(role);
                                MessageBox.Show($"Welcome, {userRole}!", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OpenFormsForRole(userRole);
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Login Information! Try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }

}


