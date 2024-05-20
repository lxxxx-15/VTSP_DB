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
        private readonly string[] cashierUsernames = { "jiii", "kat123"};
        private readonly string[] adminUsernames = { "larra123", "jov123"};

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
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

        private void OkBtn_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidUsername(string username)
        {
            string pattern = "^[a-z0-9]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(username);
        }

        private string DetermineRole(string username)
        {
            if (username.StartsWith("jiii"))
            {
                return "Cashier";
            }
            else
            {
                return "Admin";
            }

            if (username.StartsWith("kat123"))
            {
                return "Cashier";
            }
            else
            {
                return "Admin";
            }

            if (username.StartsWith("larra123"))
            {
                return "Admin";
            }
            else
            {
                return "Cashier";
            }
            if (username.StartsWith("jov123"))
            {
                return "Admin";
            }
            else
            {
                return "Cashier";
            }

        }

        private void OpenFormsForRole(string role)
        {
            if (role == "Admin")
            {
                AdMainForm adminmainForm = new AdMainForm();
                adminmainForm.Show();
                this.Hide();

                AdminPersonalInfo adminpersonalInfo = new AdminPersonalInfo();
                adminpersonalInfo.Show();
                this.Hide();

                AdminProfile adminProfile = new AdminProfile();
                adminProfile.Show();
                this.Hide();

                AdminArchiveForm adminarchiveForm = new AdminArchiveForm();
                adminarchiveForm.Show();
                this.Hide();
            }
            else if (role == "Cashier")
            {
                CashierMainForm cashierForm = new CashierMainForm();
                cashierForm.Show();
                this.Hide();

                CashiersProfile cashiersProfile = new CashiersProfile();
                cashiersProfile.Show();
                this.Hide();

                CashiersPersonalInfo cashiersersonalInfo = new CashiersPersonalInfo();
                cashiersersonalInfo.Show();
                this.Hide();
            }
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            {
                string text = LoginUsername.Text;
                string username = text;

                if (IsValidUsername(username))
                {
                    lblMessage.Text = "Username is valid!";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMessage.Text = "Invalid username! Only lowercase letters and numbers are allowed.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            string Username = LoginUsername.Text;

            if (IsValidUsername(Username))
            {
                string role = DetermineRole(Username);
                MessageBox.Show($"Welcome, {role}! ", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenFormsForRole(role);
            }
            else
            {
                MessageBox.Show("Invalid username! Only lowercase letters and numbers are allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (string.IsNullOrEmpty(LoginUsername.Text) || string.IsNullOrEmpty(LoginPassword.Text))
                {
                    MessageBox.Show("Please input Username or Password", "Error");
                }
           else
                {
                    try
                    {
                        string selectQuery = "SELECT * FROM vt_db.personal_info WHERE Username = @Username AND Password = @Password";
                        using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db"))
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Username", LoginUsername.Text);
                                command.Parameters.AddWithValue("@Password", LoginPassword.Text);

                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        this.Hide();    
                                }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Login Information! Try again.");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error");

                    }
                }
            }


        private void LogClose_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

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


