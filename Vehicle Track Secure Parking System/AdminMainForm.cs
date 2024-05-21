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

    public partial class AdMainForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=;database=vt_db");

        public AdMainForm()
        {
            InitializeComponent();
         }

        private void MainForm_Load(object sender, EventArgs e)
        {
        
        }       

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CashiersProfile form = new CashiersProfile();
            form.Show();
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



     