using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Track_Secure_Parking_System
{
    public partial class ReviewInfo : Form
    { 
        public ReviewInfo()
        {
            InitializeComponent();

            ReviewFName.Text = RegForm.firstName;
            ReviewMidName.Text = RegForm.midName;
            ReviewLName.Text = RegForm.lastName;
            ReviewRole.Text = RegForm.role;
            ReviewGender.Text = RegForm.gender;
            ReviewBirthday.Text = RegForm.birthday;
            ReviewEmail.Text = RegForm.email;
            ReviewUsername.Text = RegForm.username;
        }

        private void ReviewFullName_Click(object sender, EventArgs e)
        {

        }

        private void ReviewInfo_Load(object sender, EventArgs e)
        {

        }

        private void ReviewOkButton_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReviewLName_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReviewLabelGender_Click(object sender, EventArgs e)
        {

        }
    }
}
