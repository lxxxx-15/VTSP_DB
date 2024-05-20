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
    public partial class CashierMainForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");

        private int seconds = 0;

        private DateTime timeIn;
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FName1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            TimeInBtnn.Text = timeSpan.ToString(@"hh\:mm\:ss");

            seconds++;
            UpdateTime();


            try
            {
                int n = CashierDataGridView.Rows.Add();
                CashierDataGridView.Rows[n].Cells[0].Value = TxtBxPlate.Text;
                CashierDataGridView.Rows[n].Cells[1].Value = CmbType.SelectedItem.ToString();
                CashierDataGridView.Rows[n].Cells[2].Value = CmbModel.SelectedItem.ToString();
                CashierDataGridView.Rows[n].Cells[3].Value = TimeInBtnn.Text;

                string connectionString = "server=localhost;port=3306;username=root;password=;database=vt_db";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string iquery = "INSERT INTO cashiers_form (PlateNumber, VehicleType, VehicleModel, TimeIn)" +
                                    " VALUES (@platenumber, @vehicletype, @vehiclemodel, @timein)";

                    using (MySqlCommand cmd = new MySqlCommand(iquery, connection))
                    {
                        cmd.Parameters.AddWithValue("@platenumber", TxtBxPlate.Text);
                        cmd.Parameters.AddWithValue("@vehicletype", CmbType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@vehiclemodel", CmbModel.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@timein", TimeInBtnn.Text);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data Added Successfully!", "Success");
                    TimeInBtnn.Text = string.Empty;
                    TxtBxPlate.Text = string.Empty;
                    CmbType.SelectedIndex = -1;
                    CmbModel.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message, "Error");
            }
        }

        private void CashierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Archive_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void CashierMainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
