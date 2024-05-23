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
using System.Windows.Forms.DataVisualization.Charting;


namespace Vehicle_Track_Secure_Parking_System
{
    public partial class AdminProfile : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=vt_db");
        public AdminProfile()
        {
            InitializeComponent();   
        }

        private void LoadChartData()
        {
            // Connection string to your database
            string connectionString = "server=localhost;port=3306;username=root;password=;database=vt_db";
            string query = "SELECT VehicleType, COUNT(*) as Count FROM cashiers_form GROUP BY VehicleType";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int totalCount = 0; // Declare total count variable
                foreach (DataRow row in dataTable.Rows)
                {
                    totalCount += Convert.ToInt32(row["Count"]);
                }

                // Clear existing series and chart areas
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                chart1.Titles.Clear();
                chart1.Legends.Clear();

                // Add a chart area
                ChartArea chartArea = new ChartArea();
                chart1.ChartAreas.Add(chartArea);

                // Set background color
                chart1.BackColor = Color.Cornsilk;
                chartArea.BackColor = Color.Cornsilk;

                // Customize chart area appearance
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;

                // Add a title
                Title title = new Title
                {
                    Text = "Vehicle Type Distribution",
                    Font = new Font("Copper Black", 20, FontStyle.Bold),
                    ForeColor = Color.OrangeRed,
                    Docking = Docking.Top
                    
                };
                chart1.Titles.Add(title);
                

                // Add a legend
                Legend legend = new Legend
                {
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    BackColor = Color.Cornsilk
                };
                chart1.Legends.Add(legend);

                // Add a series and set the chart type to Pie
                Series series = new Series
                {
                    Name = "VehicleTypeDistribution",
                    XValueMember = "VehicleType",
                    YValueMembers = "Count",
                    ChartType = SeriesChartType.Pie,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    LabelForeColor = Color.Black,
                    IsValueShownAsLabel = true,
                    BackSecondaryColor = Color.Cornsilk,
                    BackGradientStyle = GradientStyle.None,
                    IsVisibleInLegend = true // Hide legend inside the pie chart

                };

                chart1.Series.Add(series);
                chart1.DataSource = dataTable;
                chart1.DataBind();

                chart1.Palette = ChartColorPalette.SeaGreen;

                foreach (DataPoint point in series.Points)
                {
                    // Check if the label is "Point1" and rename it to "Null"
                    if (point.AxisLabel == "Point1")
                    {
                        point.Label = "Null";
                    }
                }
                 foreach (DataPoint point in series.Points)
                  {
                      int count = Convert.ToInt32(point.YValues[0]);
                      double percentage = (double)count / totalCount * 100;
                      point.Label = string.Format("{0}: {1} ({2:P1})", point.AxisLabel, count, percentage / 100);
                      point.Font = new Font("Segoe UI", 6, FontStyle.Regular);
                  }
                
            }
        }


        private void AdminProfile_Load(object sender, EventArgs e)
        {
            LoadChartData();
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

        private void AdminArchivedData_Click(object sender, EventArgs e)
        {
         
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
