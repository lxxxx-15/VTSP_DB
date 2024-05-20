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
    public partial class AdminProfile : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=;database=vt_db");
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void BtnAdminPersonalInfo_Click(object sender, EventArgs e)
        {
            AdminPersonalInfo adminpersonalifoForm = new AdminPersonalInfo();
            adminpersonalifoForm.Show();
            this.Hide();

        }

        private void BtnAdminMainForm_Click(object sender, EventArgs e)
        {
            AdMainForm adminmainForm = new AdMainForm();
            adminmainForm.Show();
            this.Hide();
        }

        private void BtnCashierLogout_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }

        private void ExitbtnAdminMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            
        }
        private void AdminArchivedData_Click(object sender, EventArgs e)
        {
            AdminArchiveForm adminarchiveForm = new AdminArchiveForm();
            adminarchiveForm.Show();
            this.Hide();
        }
    }
}
