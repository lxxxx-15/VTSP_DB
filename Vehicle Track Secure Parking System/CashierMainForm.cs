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
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=;database=vt_db");

        private DataTable dataTable;

        private int seconds = 0;

        private DateTime timeIn;
        private readonly string connectionString;

        public EventHandler TxtBxOthers_Leave { get; private set; }

        public CashierMainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT PlateNumber, VehicleType, VehicleModel, Payment, TimeIn, TimeOut, Duration FROM cashiers_form";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CashierDataGridView.DataSource = dataTable;

                    // Set up DataGridView columns
                    CashierDataGridView.Columns["PlateNumber"].HeaderText = "Plate Number";
                    CashierDataGridView.Columns["VehicleType"].HeaderText = "Type";
                    CashierDataGridView.Columns["VehicleModel"].HeaderText = "Model";
                    CashierDataGridView.Columns["Payment"].HeaderText = "Payment";
                    CashierDataGridView.Columns["TimeIn"].HeaderText = "Time In";
                    CashierDataGridView.Columns["TimeOut"].HeaderText = "Time Out";
                    CashierDataGridView.Columns["Duration"].HeaderText = "Duration";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error");
            }
        }

        private void InitializeComboBox()
        {
            CmbType.Items.Add("2 wheels");
            CmbType.Items.Add("3 wheels");
            CmbType.Items.Add("4 wheels");
            CmbType.Items.Add("6 or more wheels");
            CmbType.SelectedIndex = 0;
        }

        private void InitializeCustomComponents()
        {
            CmbModel.DropDownStyle = ComboBoxStyle.DropDownList; // Ensure the ComboBox is dropdown only

            // Attach event handlers
            CmbModel.SelectedIndexChanged += new EventHandler(CmbModel_SelectedIndexChanged);
            CheckComboBoxItems();

            // Set Timer interval to 1 second (1000 milliseconds)
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(LabelTimeIn_Tick);

            // Start the timer
            timer1.Start();

            // Update the label with the current time initially
            LabelTimeIn.Text = DateTime.Now.ToString("HH:mm:ss");

            PaymentBtn.Click += new EventHandler(PaymentBtn_Click);
        }

        private void CheckComboBoxItems()
        {
            if (CmbModel.Items.Count == 0)
            {
                // No items in ComboBox, allow typing in the TextBox
                TxtBxOthers.ReadOnly = false;
                TxtBxOthers.Enabled = true;
                TxtBxOthers.Text = string.Empty;
                TxtBxOthers.Focus();
            }
            else
            {
                // Items are present in ComboBox, disable typing in TextBox
                TxtBxOthers.ReadOnly = false;
                TxtBxOthers.Text = "";
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FName1_Click(object sender, EventArgs e)
        {

        }

        private static double GetRate(string vehicleType)
        {
            switch (vehicleType)
            {
                case "2 wheels":
                    return 25;
                case "3 wheels":
                    return 50;
                case "4 wheels":
                    return 75;
                case "6 or more wheels":
                    return 100;
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }

        private void TimeInBtnn_Click(object sender, EventArgs e)
        {

            try
            {
                // Capture current time
                string currentTime = DateTime.Now.ToString("HH:mm:ss");
                double rate = 0; // Define rate variable here

                // Check if a vehicle type is selected
                if (CmbType.SelectedItem != null)
                {
                    string selectedType = CmbType.SelectedItem.ToString();
                    rate = GetRate(selectedType); // Calculate rate if vehicle type is selected

                    // Update Payment button text
                    PaymentBtn.Text = $"₱ {rate:0.00}";
                }
                else
                {
                    MessageBox.Show("Please select a vehicle type.");
                    return; // Exit the method if no vehicle type is selected
                }

                // Add a new row to DataGridView
                int n = CashierDataGridView.Rows.Add();
                CashierDataGridView.Rows[n].Cells[0].Value = TxtBxPlate.Text;
                CashierDataGridView.Rows[n].Cells[1].Value = CmbType.SelectedItem?.ToString();
                CashierDataGridView.Rows[n].Cells[2].Value = CmbModel.SelectedItem?.ToString();
                CashierDataGridView.Rows[n].Cells["Payment"].Value = rate;
                CashierDataGridView.Rows[n].Cells["TimeInn"].Value = currentTime;

                // Insert data into the database
                string connectionString = "server=localhost;port=3307;username=root;password=;database=vt_db";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string iquery = "INSERT INTO cashiers_form (PlateNumber, VehicleType, VehicleModel, Payment, TimeIn)" +
                                    " VALUES (@platenumber, @vehicletype, @vehiclemodel, @payment, @timein)";
                    using (MySqlCommand cmd = new MySqlCommand(iquery, connection))
                    {
                        cmd.Parameters.AddWithValue("@platenumber", TxtBxPlate.Text);
                        cmd.Parameters.AddWithValue("@vehicletype", CmbType.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@vehiclemodel", CmbModel.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@payment", rate);
                        cmd.Parameters.AddWithValue("@timein", currentTime);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Clear input fields
                TxtBxPlate.Text = string.Empty;
                CmbType.SelectedIndex = -1;
                CmbModel.SelectedIndex = -1;
                TxtbxDuration.Text = string.Empty;
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
            CashiersProfile cashiersProfile = new CashiersProfile();
            cashiersProfile.Show();
            this.Close();
        }

        private void InsertLogoutTimeIntoDatabase(string logoutTime)
        {
            try
            {
                // Insert data into the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string iquery = "UPDATE cashiers_form SET TimeOut = @timeout WHERE PlateNumber = @platenumber";
                    using (MySqlCommand cmd = new MySqlCommand(iquery, connection))
                    {
                        cmd.Parameters.AddWithValue("@timeout", logoutTime);
                        cmd.Parameters.AddWithValue("@platenumber", CashierDataGridView.CurrentRow.Cells["PlateNumber"].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred while inserting data into the database: " + ex.Message, "Database Error");
            }
        }

        private void TimeOutbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (CashierDataGridView.CurrentRow != null)
                {
                    // Get the current logout time
                    string currentTime = DateTime.Now.ToString("HH:mm:ss");

                    // Insert the current logout time into the database
                    InsertLogoutTimeIntoDatabase(currentTime);

                    // Get the currently selected row
                    DataGridViewRow selectedRow = CashierDataGridView.CurrentRow;

                    selectedRow.Cells["TimeOut"].Value = currentTime;
                    string timeOut = selectedRow.Cells["TimeOut"].Value.ToString();
                }
                else
                {
                    // Inform the user that no row is selected
                    MessageBox.Show("Please select a row to log out.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void CashierMainForm_Load(object sender, EventArgs e)
        {

        }

        private void CmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbModel.Items.Count == 0)
            {
                // If no items in ComboBox, show TextBox and hide ComboBox
                CmbModel.Visible = true;
                TxtBxOthers.Visible = true;
                TxtBxOthers.Enabled = true;
                TxtBxOthers.Focus(); // Set focus to TextBox
            }

            if (CmbModel.SelectedIndex != -1)
            {
                TxtBxOthers.Text = "";
            }
            else
            {
                // If there are items, show ComboBox and hide TextBox
                CmbModel.Visible = true;
                CmbModel.Enabled = true;
                TxtBxOthers.Visible = true;
            }

        }


        private void TxtBxOthers_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelTimeIn_Tick(object sender, EventArgs e)
        {
            // Update the label with the current time
            LabelTimeIn.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            {
                string vehicleModel = TxtBxOthers.Text.Trim();

                // Check if the vehicle model is not empty
                if (!string.IsNullOrEmpty(vehicleModel))
                {
                    try
                    {
                        // Define the connection string and query
                        string query = "INSERT INTO vehicle_model (model) VALUES (@model)";

                        // Create MySqlConnection and MySqlCommand objects
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                // Add model parameter to the command
                                command.Parameters.AddWithValue("@model", vehicleModel);

                                // Open the connection and execute the command
                                connection.Open();
                                int result = command.ExecuteNonQuery();

                                // Check if the insertion was successful
                                if (result > 0)
                                {
                                    // Show success message
                                    MessageBox.Show("Vehicle model inserted successfully.");

                                    // Add the new model to the ComboBox
                                    CmbModel.Items.Add(vehicleModel);
                                }
                                else
                                {
                                    // Show failure message
                                    MessageBox.Show("Insertion failed.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show error message if an exception occurs
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    // Show message if the vehicle model is empty
                    MessageBox.Show("Please enter a vehicle model.");
                }
            }
        }

        private void Archive_Click(object sender, EventArgs e)
        {

        }
    }
}

