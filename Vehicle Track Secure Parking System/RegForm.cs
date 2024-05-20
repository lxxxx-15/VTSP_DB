﻿using System;
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
    public partial class RegForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=;database=vt_db");
       
        private readonly bool userExists;

        public static string role = "";
        public static string firstName = "";
        public static string midName = "";
        public static string lastName = "";
        public static string gender = "";
        public static string birthday = "";
        public static string email = "";
        public static string username = "";
        public RegForm()
        {
            InitializeComponent();
            RegDateTimePicker.MaxDate = DateTime.Today;
            RegDateTimePicker.MinDate = DateTime.Today.AddYears(-60);
        }
   
        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void RegButton_Click_1(object sender, EventArgs e)
        {
            GenderCmb.Items.Add("Female");
            GenderCmb.Items.Add("Male");
            RoleCmb.Items.Add("Admin");
            RoleCmb.Items.Add("Cashier");

            if (RegPass1.Text != RegRTPass1.Text)
            {
                MessageBox.Show("Password Doesn't Match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(RoleCmb.Text) || string.IsNullOrEmpty(RegFName.Text) || string.IsNullOrEmpty(RegMidName.Text) || string.IsNullOrEmpty(RegLName.Text) ||
                string.IsNullOrEmpty(GenderCmb.Text) || string.IsNullOrEmpty(RegEmail1.Text) || string.IsNullOrEmpty(EnterUsername1.Text) ||
                string.IsNullOrEmpty(RegPass1.Text) || string.IsNullOrEmpty(RegRTPass1.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

           
            connection.Open();

            try
            {
                if (!(userExists))
                {
                    using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;username=root;password=;database=vt_db"))
                    {
                        conn.Open();
                        string iquery = "INSERT INTO vt_db.personal_info (Role,FirstName, MiddleName, LastName, Gender, Birthday, EMail, Username, Password)" +
                                        " VALUES (@Role, @FirstName, @MiddleName, @LastName, @Gender, @Birthday, @EMail, @Username, @Password)";

                        MySqlCommand command = new MySqlCommand(iquery, conn);
                        command.Parameters.AddWithValue("@Role", RoleCmb.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@FirstName", RegFName.Text);
                        command.Parameters.AddWithValue("@MiddleName", RegMidName.Text);
                        command.Parameters.AddWithValue("@LastName", RegLName.Text);
                        command.Parameters.AddWithValue("@Gender", GenderCmb.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Birthday", RegDateTimePicker.Value.ToString("MM-dd-yyyy"));
                        command.Parameters.AddWithValue("@EMail", RegEmail1.Text);
                        command.Parameters.AddWithValue("@Username", EnterUsername1.Text);
                        command.Parameters.AddWithValue("@Password", RegPass1.Text);

                        command.ExecuteNonQuery();
                    }
                }
            }

            finally
            {
                MessageBox.Show("Account Creation Successful!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                connection.Close();
            }

        }

        private void BtnAdminHistory_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ReviewInfoBtn_Click(object sender, EventArgs e)
        {
            role = RoleCmb.Text;
            firstName = RegFName.Text;
            midName = RegMidName.Text;
            lastName = RegLName.Text;
            gender = GenderCmb.Text;
            birthday = RegDateTimePicker.Text;
            email = RegEmail1.Text;
            username = EnterUsername1.Text;

            ReviewInfo reviewInfo = new ReviewInfo();
            reviewInfo.Show();
           
        }

        private void RegDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime selectedDate = RegDateTimePicker.Value;
            DateTime today = DateTime.Today;
            DateTime minimumDate = today.AddYears(-12);

            if (selectedDate > today)
            {
                MessageBox.Show("The selected date cannot be in the future. Please select an appropriate date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegDateTimePicker.Value = today;
            }
            else if (selectedDate > minimumDate)
            {
                MessageBox.Show("The selected date indicates the age is less than 12 years. Please select an appropriate date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegDateTimePicker.Value = minimumDate;
            }
        
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }  
}
