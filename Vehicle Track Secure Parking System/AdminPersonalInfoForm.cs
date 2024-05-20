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
    public partial class AdminPersonalInfo : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=;database=vt_db");

        public AdminPersonalInfo()
        {
            InitializeComponent();
        }

        private void AdminPersonalInfoForm_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void FetchData()
        {
            throw new NotImplementedException();


        }

        private void BtnAdminLogout_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile();
            adminProfile.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void StartFormClose_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelLastName_Click(object sender, EventArgs e)
        {

        }

        private void LabelMidName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void LblMidName_Click(object sender, EventArgs e)
        {

        }

        private void LblUsername_Click(object sender, EventArgs e)
        {

        }

        private void LblEmail_Click(object sender, EventArgs e)
        {

        }

        private void LblBirthday_Click(object sender, EventArgs e)
        {

        }

        private void LblGender_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelEmail_Click(object sender, EventArgs e)
        {

        }

        private void LabelBirthday_Click(object sender, EventArgs e)
        {

        }

        private void LabelGender_Click(object sender, EventArgs e)
        {

        }

        private void LblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdminPersonalInfo_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnAdminMainForm_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdminHistory_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
