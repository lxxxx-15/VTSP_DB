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
    public partial class AdminPersonalInfoForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");

        public AdminPersonalInfoForm()
        {
            InitializeComponent();
        }

        private void AdminPersonalInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdminPersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void AdminProfileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdminLogout_Click(object sender, EventArgs e)
        {
            AdminProfile form = new AdminProfile();
            form.Show();
            this.Hide();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
