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
    public partial class CashiersProfile : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");

        public CashiersProfile()
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
            CashiersPersonalInfo form = new CashiersPersonalInfo();
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
            CashierMainForm cashiermainForm = new CashierMainForm();
            this.Hide();
            cashiermainForm.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDataInNewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Define your connection string(update with your actual connection string)
         string connectionString = "server=localhost;port=3306;username=root;password=;database=vt_db";

            // Create a new DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Initialize the connection
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                // Open the connection
                mySqlConnection.Open();

                // Define the SQL query to retrieve all input data
                string query = "SELECT * FROM cahsiers_form";

                // Create a new MySqlCommand object
                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    // Create a MySqlDataAdapter to fill the DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        // Fill the DataTable with data from the database
                        adapter.Fill(dataTable);
                    }
                }

                // Close the connection
                mySqlConnection.Close();
            }

            // Create a new form to display the data
            Form dataForm = new Form();
            dataForm.Text = "Data Display Form";

            // Create a new DataGridView to display the data
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;

            // Add the DataGridView to the form
            dataForm.Controls.Add(dataGridView);

            // Set the DataSource property of the DataGridView to the DataTable
            dataGridView.DataSource = dataTable;

            // Show the form
            dataForm.ShowDialog();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
