﻿using System;
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
    public partial class AdminArchiveForm : Form
    {
        public AdminArchiveForm()
        {
            InitializeComponent();
        }

        private void ArchiveBack_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile();
            adminProfile.Show();
            this.Hide();
        }

        private void ExitbtnAdminMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminArchiveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
