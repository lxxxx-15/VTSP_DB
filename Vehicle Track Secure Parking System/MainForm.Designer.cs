
namespace Vehicle_Track_Secure_Parking_System
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MainClose = new Guna.UI2.WinForms.Guna2Button();
            this.VId = new System.Windows.Forms.Label();
            this.TbVId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.VType = new System.Windows.Forms.Label();
            this.VModel = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TimeIn = new System.Windows.Forms.Label();
            this.TimeOut = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Label();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DtpTimeIn = new System.Windows.Forms.DateTimePicker();
            this.Model1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.VehicleType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TbPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbDuration = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewMainForm = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OkBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdminMainForm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MainClose
            // 
            this.MainClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MainClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MainClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MainClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MainClose.FillColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.MainClose, "MainClose");
            this.MainClose.ForeColor = System.Drawing.Color.White;
            this.MainClose.Name = "MainClose";
            this.MainClose.Click += new System.EventHandler(this.StartFormClose_Click);
            // 
            // VId
            // 
            resources.ApplyResources(this.VId, "VId");
            this.VId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.VId.Name = "VId";
            // 
            // TbVId
            // 
            resources.ApplyResources(this.TbVId, "TbVId");
            this.TbVId.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.TbVId.BorderRadius = 15;
            this.TbVId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbVId.DefaultText = "";
            this.TbVId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbVId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbVId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbVId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbVId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbVId.ForeColor = System.Drawing.Color.Navy;
            this.TbVId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbVId.Name = "TbVId";
            this.TbVId.PasswordChar = '\0';
            this.TbVId.PlaceholderText = "";
            this.TbVId.SelectedText = "";
            // 
            // guna2PictureBox1
            // 
            resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.TabStop = false;
            // 
            // VType
            // 
            resources.ApplyResources(this.VType, "VType");
            this.VType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.VType.Name = "VType";
            // 
            // VModel
            // 
            resources.ApplyResources(this.VModel, "VModel");
            this.VModel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.VModel.Name = "VModel";
            // 
            // guna2PictureBox3
            // 
            resources.ApplyResources(this.guna2PictureBox3, "guna2PictureBox3");
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // guna2PictureBox4
            // 
            resources.ApplyResources(this.guna2PictureBox4, "guna2PictureBox4");
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.Click += new System.EventHandler(this.guna2PictureBox4_Click);
            // 
            // guna2PictureBox5
            // 
            resources.ApplyResources(this.guna2PictureBox5, "guna2PictureBox5");
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.TabStop = false;
            // 
            // guna2PictureBox6
            // 
            resources.ApplyResources(this.guna2PictureBox6, "guna2PictureBox6");
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.TabStop = false;
            // 
            // TimeIn
            // 
            resources.ApplyResources(this.TimeIn, "TimeIn");
            this.TimeIn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TimeIn.Name = "TimeIn";
            // 
            // TimeOut
            // 
            resources.ApplyResources(this.TimeOut, "TimeOut");
            this.TimeOut.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TimeOut.Name = "TimeOut";
            // 
            // Duration
            // 
            resources.ApplyResources(this.Duration, "Duration");
            this.Duration.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Duration.Name = "Duration";
            // 
            // Payment
            // 
            resources.ApplyResources(this.Payment, "Payment");
            this.Payment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Payment.Name = "Payment";
            // 
            // guna2PictureBox7
            // 
            resources.ApplyResources(this.guna2PictureBox7, "guna2PictureBox7");
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.TabStop = false;
            // 
            // guna2PictureBox8
            // 
            resources.ApplyResources(this.guna2PictureBox8, "guna2PictureBox8");
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.TabStop = false;
            // 
            // guna2PictureBox9
            // 
            resources.ApplyResources(this.guna2PictureBox9, "guna2PictureBox9");
            this.guna2PictureBox9.ImageRotate = 0F;
            this.guna2PictureBox9.Name = "guna2PictureBox9";
            this.guna2PictureBox9.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.dateTimePicker1);
            this.guna2GradientPanel1.Controls.Add(this.DtpTimeIn);
            this.guna2GradientPanel1.Controls.Add(this.Model1);
            this.guna2GradientPanel1.Controls.Add(this.VehicleType);
            this.guna2GradientPanel1.Controls.Add(this.TbPayment);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox9);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox8);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox7);
            this.guna2GradientPanel1.Controls.Add(this.TbDuration);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox6);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox5);
            this.guna2GradientPanel1.Controls.Add(this.TbVId);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox4);
            this.guna2GradientPanel1.Controls.Add(this.Payment);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox3);
            this.guna2GradientPanel1.Controls.Add(this.TimeOut);
            this.guna2GradientPanel1.Controls.Add(this.Duration);
            this.guna2GradientPanel1.Controls.Add(this.VId);
            this.guna2GradientPanel1.Controls.Add(this.TimeIn);
            this.guna2GradientPanel1.Controls.Add(this.VType);
            this.guna2GradientPanel1.Controls.Add(this.VModel);
            resources.ApplyResources(this.guna2GradientPanel1, "guna2GradientPanel1");
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            // 
            // DtpTimeIn
            // 
            resources.ApplyResources(this.DtpTimeIn, "DtpTimeIn");
            this.DtpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpTimeIn.Name = "DtpTimeIn";
            this.DtpTimeIn.ShowUpDown = true;
            // 
            // Model1
            // 
            this.Model1.BackColor = System.Drawing.Color.Transparent;
            this.Model1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Model1.BorderRadius = 15;
            this.Model1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Model1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Model1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Model1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Model1, "Model1");
            this.Model1.ForeColor = System.Drawing.Color.Navy;
            this.Model1.Items.AddRange(new object[] {
            resources.GetString("Model1.Items"),
            resources.GetString("Model1.Items1"),
            resources.GetString("Model1.Items2"),
            resources.GetString("Model1.Items3"),
            resources.GetString("Model1.Items4"),
            resources.GetString("Model1.Items5"),
            resources.GetString("Model1.Items6"),
            resources.GetString("Model1.Items7"),
            resources.GetString("Model1.Items8"),
            resources.GetString("Model1.Items9"),
            resources.GetString("Model1.Items10"),
            resources.GetString("Model1.Items11"),
            resources.GetString("Model1.Items12"),
            resources.GetString("Model1.Items13"),
            resources.GetString("Model1.Items14"),
            resources.GetString("Model1.Items15"),
            resources.GetString("Model1.Items16"),
            resources.GetString("Model1.Items17"),
            resources.GetString("Model1.Items18"),
            resources.GetString("Model1.Items19"),
            resources.GetString("Model1.Items20"),
            resources.GetString("Model1.Items21"),
            resources.GetString("Model1.Items22"),
            resources.GetString("Model1.Items23"),
            resources.GetString("Model1.Items24"),
            resources.GetString("Model1.Items25"),
            resources.GetString("Model1.Items26"),
            resources.GetString("Model1.Items27"),
            resources.GetString("Model1.Items28"),
            resources.GetString("Model1.Items29"),
            resources.GetString("Model1.Items30"),
            resources.GetString("Model1.Items31"),
            resources.GetString("Model1.Items32")});
            this.Model1.Name = "Model1";
            // 
            // VehicleType
            // 
            this.VehicleType.BackColor = System.Drawing.Color.Transparent;
            this.VehicleType.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.VehicleType.BorderRadius = 15;
            this.VehicleType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.VehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VehicleType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.VehicleType, "VehicleType");
            this.VehicleType.ForeColor = System.Drawing.Color.Navy;
            this.VehicleType.Items.AddRange(new object[] {
            resources.GetString("VehicleType.Items"),
            resources.GetString("VehicleType.Items1"),
            resources.GetString("VehicleType.Items2"),
            resources.GetString("VehicleType.Items3")});
            this.VehicleType.Name = "VehicleType";
            // 
            // TbPayment
            // 
            resources.ApplyResources(this.TbPayment, "TbPayment");
            this.TbPayment.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.TbPayment.BorderRadius = 15;
            this.TbPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbPayment.DefaultText = "";
            this.TbPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPayment.Name = "TbPayment";
            this.TbPayment.PasswordChar = '\0';
            this.TbPayment.PlaceholderText = "";
            this.TbPayment.SelectedText = "";
            this.TbPayment.TextChanged += new System.EventHandler(this.guna2TextBox7_TextChanged);
            // 
            // TbDuration
            // 
            resources.ApplyResources(this.TbDuration, "TbDuration");
            this.TbDuration.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.TbDuration.BorderRadius = 15;
            this.TbDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbDuration.DefaultText = "";
            this.TbDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbDuration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbDuration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbDuration.ForeColor = System.Drawing.Color.Navy;
            this.TbDuration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbDuration.Name = "TbDuration";
            this.TbDuration.PasswordChar = '\0';
            this.TbDuration.PlaceholderText = "";
            this.TbDuration.SelectedText = "";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnDelete, "BtnDelete");
            this.BtnDelete.BorderColor = System.Drawing.Color.AliceBlue;
            this.BtnDelete.BorderRadius = 15;
            this.BtnDelete.BorderThickness = 1;
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnUpdate, "BtnUpdate");
            this.BtnUpdate.BorderColor = System.Drawing.Color.AliceBlue;
            this.BtnUpdate.BorderRadius = 15;
            this.BtnUpdate.BorderThickness = 1;
            this.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdate.FillColor = System.Drawing.Color.LimeGreen;
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.BorderColor = System.Drawing.Color.AliceBlue;
            this.BtnSave.BorderRadius = 15;
            this.BtnSave.BorderThickness = 1;
            this.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSave.FillColor = System.Drawing.Color.Navy;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Button4, "guna2Button4");
            this.guna2Button4.BorderColor = System.Drawing.Color.AliceBlue;
            this.guna2Button4.BorderRadius = 15;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // DataGridViewMainForm
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewMainForm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMainForm.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridViewMainForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMainForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.DataGridViewMainForm, "DataGridViewMainForm");
            this.DataGridViewMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewMainForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.Model,
            this.Duration1,
            this.Payment1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewMainForm.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewMainForm.GridColor = System.Drawing.Color.White;
            this.DataGridViewMainForm.Name = "DataGridViewMainForm";
            this.DataGridViewMainForm.RowHeadersVisible = false;
            this.DataGridViewMainForm.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewMainForm.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewMainForm.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewMainForm.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewMainForm.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewMainForm.ThemeStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridViewMainForm.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.DataGridViewMainForm.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewMainForm.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewMainForm.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewMainForm.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewMainForm.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewMainForm.ThemeStyle.HeaderStyle.Height = 15;
            this.DataGridViewMainForm.ThemeStyle.ReadOnly = false;
            this.DataGridViewMainForm.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewMainForm.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewMainForm.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewMainForm.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewMainForm.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewMainForm.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewMainForm.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewMainForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            // 
            // Type
            // 
            resources.ApplyResources(this.Type, "Type");
            this.Type.Name = "Type";
            // 
            // Model
            // 
            resources.ApplyResources(this.Model, "Model");
            this.Model.Name = "Model";
            // 
            // Duration1
            // 
            resources.ApplyResources(this.Duration1, "Duration1");
            this.Duration1.Name = "Duration1";
            // 
            // Payment1
            // 
            resources.ApplyResources(this.Payment1, "Payment1");
            this.Payment1.Name = "Payment1";
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.OkBtn, "OkBtn");
            this.OkBtn.BorderColor = System.Drawing.Color.AliceBlue;
            this.OkBtn.BorderRadius = 15;
            this.OkBtn.BorderThickness = 1;
            this.OkBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OkBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OkBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OkBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OkBtn.FillColor = System.Drawing.Color.Orange;
            this.OkBtn.ForeColor = System.Drawing.Color.White;
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BtnAdminMainForm
            // 
            this.BtnAdminMainForm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnAdminMainForm, "BtnAdminMainForm");
            this.BtnAdminMainForm.BorderColor = System.Drawing.Color.AliceBlue;
            this.BtnAdminMainForm.BorderRadius = 15;
            this.BtnAdminMainForm.BorderThickness = 1;
            this.BtnAdminMainForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdminMainForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdminMainForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdminMainForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdminMainForm.FillColor = System.Drawing.Color.Orange;
            this.BtnAdminMainForm.ForeColor = System.Drawing.Color.White;
            this.BtnAdminMainForm.Name = "BtnAdminMainForm";
            // 
            // guna2PictureBox2
            // 
            resources.ApplyResources(this.guna2PictureBox2, "guna2PictureBox2");
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.TabStop = false;
            // 
            // AdminMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.BtnAdminMainForm);
            this.Controls.Add(this.DataGridViewMainForm);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.MainClose);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button MainClose;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label VId;
        private Guna.UI2.WinForms.Guna2TextBox TbVId;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label VModel;
        private System.Windows.Forms.Label VType;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Label TimeOut;
        private System.Windows.Forms.Label TimeIn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TbPayment;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private Guna.UI2.WinForms.Guna2TextBox TbDuration;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2ComboBox VehicleType;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewMainForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment1;
        private Guna.UI2.WinForms.Guna2ComboBox Model1;
        private Guna.UI2.WinForms.Guna2Button OkBtn;
        private System.Windows.Forms.DateTimePicker DtpTimeIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button BtnAdminMainForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}