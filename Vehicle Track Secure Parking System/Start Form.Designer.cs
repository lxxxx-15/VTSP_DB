
namespace Vehicle_Track_Secure_Parking_System
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.StartFormClose = new Guna.UI2.WinForms.Guna2Button();
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PictureBox2
            // 
            resources.ApplyResources(this.guna2PictureBox2, "guna2PictureBox2");
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2PictureBox1
            // 
            resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.TabStop = false;
            // 
            // StartFormClose
            // 
            this.StartFormClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartFormClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartFormClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartFormClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartFormClose.FillColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.StartFormClose, "StartFormClose");
            this.StartFormClose.ForeColor = System.Drawing.Color.White;
            this.StartFormClose.Name = "StartFormClose";
            this.StartFormClose.Click += new System.EventHandler(this.StartFormClose_Click);
            // 
            // StartButton
            // 
            this.StartButton.Animated = true;
            this.StartButton.AutoRoundedCorners = true;
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.BorderColor = System.Drawing.Color.AliceBlue;
            this.StartButton.BorderRadius = 20;
            this.StartButton.BorderThickness = 1;
            this.StartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartButton.FillColor = System.Drawing.Color.Orange;
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Name = "StartButton";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StartFormClose);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox2);
            this.ForeColor = System.Drawing.Color.Wheat;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "StartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button StartFormClose;
        private Guna.UI2.WinForms.Guna2Button StartButton;
    }
}

