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

namespace Vehicle_Track_Secure_Parking_System
{
    public partial class LoginForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");

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
            RegForm form = new RegForm();
            form.Show();
            this.Hide();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
           
           if (string.IsNullOrEmpty(LoginUsername.Text) || string.IsNullOrEmpty(LoginPassword.Text))
                {
                    MessageBox.Show("Please input Username and Password", "Error");
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
                                        MessageBox.Show("Login Successful!");
                                        this.Hide();
                                        AdminProfile form = new AdminProfile();
                                        form.Show();
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
            this.Close();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    }


