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
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");

        public AdMainForm()
        {
            InitializeComponent();
 
            TimerIn.Interval = 1000;
            TimerOut.Interval = 1000;
            
            

            TimerIn.Tick += (sender, e) =>
            {
                TimeInLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            TimerOut.Tick += delegate (object sender, EventArgs e)
            {
                TimeOutLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            };


            TimerIn.Start();
            TimerOut.Start();



        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimerInBtn.Visible = true;
            TimerOutBtn.Visible = true;
        }

        private void ArchiveBtn_Click(object sender, EventArgs e)
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
            /**
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
                DataGridViewMainForm.Rows[n].Cells[2].Value = vModel1.Text;
                DataGridViewMainForm.Rows[n].Cells[3].Value = TbDuration.Text;
                DataGridViewMainForm.Rows[n].Cells[4].Value = TbPayment.Text;

                string connectionString = "server=localhost;port=3306;username=root;password=;database=vt_db";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string iquery = "INSERT INTO main_form (PlateNumber, Type, Model, TimerIn, TimeOut, Duration, Payment)" +
                                    " VALUES (@platenumber, @type, @model, @timein, @timeout, @duration, @payment)";

                    using (MySqlCommand cmd = new MySqlCommand(iquery, connection))
                    {
                        cmd.Parameters.AddWithValue("@platenumber", TbVId.Text);
                        cmd.Parameters.AddWithValue("@type", VehicleType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@model", vModel1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@timerin", intime.ToString("HH:mm:ss")); 
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
            **/
        }

        

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CashiersProfile form = new CashiersProfile();
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

        private void SaveDataToDatabase(string text1, string text2, string text3, object intime, object outtime, object formattedDuration, object payment)
        {
            throw new NotImplementedException();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void PlateNumber_Click(object sender, EventArgs e)
        {

        }


        private void TimerOutBtn_Click(object sender, EventArgs e)
        {
            
        }

 

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdminMainForm_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void VModel_Click(object sender, EventArgs e)
        {

        }

        private void VType_Click(object sender, EventArgs e)
        {

        }

        private void Duration_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Click(object sender, EventArgs e)
        {

        }

        private void TbVId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Model1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimeInLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void TimeInLabel_Click_1(object sender, EventArgs e)
        {
            TimeInLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void UpdateTimeInLabel()
        {
            TimeInLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void TimeOutLabel_Click(object sender, EventArgs e)
        {
            TimeOutLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void UpdateTimeOutLabel()
        {
            TimeOutLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void TimerInBtn_Click(object sender, EventArgs e)
        {
             DateTime currentTime = DateTime.Now;
             TimeInLabel.Text = "Time In: " + currentTime.ToString("HH:mm:ss");
        }

        private void TimerOutBtn_Click_1(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimeOutLabel.Text = "Time Out: " + currentTime.ToString("HH:mm:ss");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}



     