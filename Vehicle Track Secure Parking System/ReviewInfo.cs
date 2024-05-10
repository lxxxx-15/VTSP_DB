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
            ReviewGender.Text = RegForm.gender;
            ReviewBirthday.Text = RegForm.birthday;
            ReviewEmail.Text = RegForm.email;
            ReviewUsername.Text = RegForm.username;
        }

        private void ReviewInfoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReviewFullName_Click(object sender, EventArgs e)
        {

        }

        private void ReviewInfo_Load(object sender, EventArgs e)
        {

        }

        private void ReviewOkButton_Click(object sender, EventArgs e)
        {
            RegForm frm2 = new RegForm();
            frm2.Show();
            this.Hide();
        }
    }
}
