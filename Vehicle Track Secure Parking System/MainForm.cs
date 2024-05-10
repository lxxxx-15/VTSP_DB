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

    public partial class AdminMainForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DataGridViewMainForm.Rows.Count > 0)
            {
                DataGridViewMainForm.Rows.RemoveAt(DataGridViewMainForm.CurrentRow.Index);
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void RegDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime intime = DateTime.Parse(DtpTimeIn.Text);
                DateTime outtime = DateTime.Parse(dateTimePicker1.Text);

                double duration = (outtime - intime).TotalMinutes;

                TimeSpan span = TimeSpan.FromMinutes(duration);

                int hours = (int)span.TotalHours;
                int minutes = span.Minutes;

                TbDuration.Text = string.Format("{0:D2}:{1:D2}", hours, minutes);

                if (duration <= 30)
                {
                    TbPayment.Text = "0.00";
                }
                else
                {
                    double payment = Math.Ceiling(duration / 60) * 5;
                    TbPayment.Text = "" + payment.ToString("0.00");
                }

                int n = DataGridViewMainForm.Rows.Add();
                DataGridViewMainForm.Rows[n].Cells[0].Value = TbVId.Text;
                DataGridViewMainForm.Rows[n].Cells[1].Value = VehicleType.Text;
                DataGridViewMainForm.Rows[n].Cells[2].Value = Model1.Text;
                DataGridViewMainForm.Rows[n].Cells[3].Value = TbDuration.Text;
                DataGridViewMainForm.Rows[n].Cells[4].Value = TbPayment.Text;

                string connectionString = "server=localhost;port=3306;username=root;password=;database=vt_db";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string iquery = "INSERT INTO main_form (VehicleId, Type, Model, TimeIn, TimeOut, Duration, Payment)" +
                                    " VALUES (@vehicleid, @type, @model, @timein, @timeout, @duration, @payment)";

                    using (MySqlCommand cmd = new MySqlCommand(iquery, connection))
                    {
                        cmd.Parameters.AddWithValue("@vehicleid", TbVId.Text);
                        cmd.Parameters.AddWithValue("@type", VehicleType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@model", Model1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@timein", intime.ToString("HH:mm:ss")); 
                        cmd.Parameters.AddWithValue("@timeout", outtime.ToString("HH:mm:ss")); 
                        cmd.Parameters.AddWithValue("@duration", TbDuration.Text);
                        cmd.Parameters.AddWithValue("@payment", TbPayment.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data Added Successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message, "Error");
            }
        }



        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AdminProfile form = new AdminProfile();
            form.Show();
            this.Close();
        }

        private void StartFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtpTimeOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=;database=vt_db";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string iquery = "INSERT INTO main_form (VehicleId, Type, Model, TimeIn, TimeOut, Duration, Payment)" +
                                " VALUES (@vehicleid, @type, @model, @timein, @timeout, @duration, @payment)";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(iquery, connection))
                    {
                        cmd.Parameters.AddWithValue("@vehicleid", TbVId.Text);
                        cmd.Parameters.AddWithValue("@type", VehicleType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@model", Model1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@timein", DateTime.Parse(DtpTimeIn.Text).ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@timeout", DateTime.Parse(dateTimePicker1.Text).ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@duration", TbDuration.Text);
                        cmd.Parameters.AddWithValue("@payment", TbPayment.Text);

                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Data Inserted Successfully Into the Database!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving data to the database: " + ex.Message, "Error");
                }

                {
                    DataGridViewMainForm.Rows.Add(TbVId.Text, VehicleType.Text, Model1.Text, TbDuration, TbPayment);

                    SaveDataToDatabase(TbVId.Text, VehicleType.Text, Model1.Text, DtpTimeIn.Text, dateTimePicker1.Text, TbDuration.Text, TbPayment.Text);

                    MessageBox.Show("Data added successfully and saved to the database!", "Success");
                }
            }

        }

        private void SaveDataToDatabase(string text1, string text2, string text3, object intime, object outtime, object formattedDuration, object payment)
        {
            throw new NotImplementedException();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

    }
}


     