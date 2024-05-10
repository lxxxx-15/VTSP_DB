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
    public partial class AdminProfile : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");

        public AdminProfile()
        {
            InitializeComponent();
        }

        private void StartFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdminPersonalInfo_Click(object sender, EventArgs e)
        {
            AdminPersonalInfoForm form = new AdminPersonalInfoForm();
            this.Hide();
            form.Show();
        }

        private void BtnAdminLogout_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            this.Hide();
            form.Show();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdminMainForm_Click(object sender, EventArgs e)
        {
            AdminMainForm form = new AdminMainForm();
            this.Hide();
            form.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
