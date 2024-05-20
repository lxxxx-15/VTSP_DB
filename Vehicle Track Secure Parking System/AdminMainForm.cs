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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void TimerInBtn_Click(object sender, EventArgs e)
        {
             DateTime currentTime = DateTime.Now;
             TimeInLabel.Text = "Time In: " + currentTime.ToString("HH:mm:ss");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}



     