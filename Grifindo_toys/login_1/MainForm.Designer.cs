namespace login_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xzcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MReg = new System.Windows.Forms.ToolStripMenuItem();
            this.MIAdReg = new System.Windows.Forms.ToolStripMenuItem();
            this.MIEmpReg = new System.Windows.Forms.ToolStripMenuItem();
            this.MSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.MISalDet = new System.Windows.Forms.ToolStripMenuItem();
            this.MISalCal = new System.Windows.Forms.ToolStripMenuItem();
            this.MISReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MIIindReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.MISalSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.MILogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDisplay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmRegister = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xzcToolStripMenuItem,
            this.MReg,
            this.MSalary,
            this.MSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "sdfx";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // xzcToolStripMenuItem
            // 
            this.xzcToolStripMenuItem.Name = "xzcToolStripMenuItem";
            this.xzcToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            // 
            // MReg
            // 
            this.MReg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIAdReg,
            this.MIEmpReg});
            this.MReg.Name = "MReg";
            this.MReg.Size = new System.Drawing.Size(101, 24);
            this.MReg.Text = "Registration";
            // 
            // MIAdReg
            // 
            this.MIAdReg.Name = "MIAdReg";
            this.MIAdReg.Size = new System.Drawing.Size(234, 26);
            this.MIAdReg.Text = "Admin Registration";
            this.MIAdReg.Click += new System.EventHandler(this.MIAdReg_Click);
            // 
            // MIEmpReg
            // 
            this.MIEmpReg.Name = "MIEmpReg";
            this.MIEmpReg.Size = new System.Drawing.Size(234, 26);
            this.MIEmpReg.Text = "Employee Registration";
            this.MIEmpReg.Click += new System.EventHandler(this.MIEmpReg_Click);
            // 
            // MSalary
            // 
            this.MSalary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MISalDet,
            this.MISalCal,
            this.MISReport});
            this.MSalary.Name = "MSalary";
            this.MSalary.Size = new System.Drawing.Size(61, 24);
            this.MSalary.Text = "Salary";
            // 
            // MISalDet
            // 
            this.MISalDet.Name = "MISalDet";
            this.MISalDet.Size = new System.Drawing.Size(189, 26);
            this.MISalDet.Text = "Salary Detatils";
            this.MISalDet.Click += new System.EventHandler(this.MISalDet_Click);
            // 
            // MISalCal
            // 
            this.MISalCal.Name = "MISalCal";
            this.MISalCal.Size = new System.Drawing.Size(189, 26);
            this.MISalCal.Text = "Salary Calculate";
            this.MISalCal.Click += new System.EventHandler(this.MISalCal_Click);
            // 
            // MISReport
            // 
            this.MISReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIIindReport});
            this.MISReport.Name = "MISReport";
            this.MISReport.Size = new System.Drawing.Size(189, 26);
            this.MISReport.Text = "Salary Report";
            // 
            // MIIindReport
            // 
            this.MIIindReport.Name = "MIIindReport";
            this.MIIindReport.Size = new System.Drawing.Size(198, 26);
            this.MIIindReport.Text = "Individual Report";
            this.MIIindReport.Click += new System.EventHandler(this.MIIindReport_Click);
            // 
            // MSetting
            // 
            this.MSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MISalSetting,
            this.MILogout,
            this.MIExit});
            this.MSetting.Name = "MSetting";
            this.MSetting.Size = new System.Drawing.Size(68, 24);
            this.MSetting.Text = "Setting";
            // 
            // MISalSetting
            // 
            this.MISalSetting.Name = "MISalSetting";
            this.MISalSetting.Size = new System.Drawing.Size(175, 26);
            this.MISalSetting.Text = "Salary Setting";
            this.MISalSetting.Click += new System.EventHandler(this.MISalSetting_Click);
            // 
            // MILogout
            // 
            this.MILogout.Name = "MILogout";
            this.MILogout.Size = new System.Drawing.Size(175, 26);
            this.MILogout.Text = "Logout";
            this.MILogout.Click += new System.EventHandler(this.MILogout_Click);
            // 
            // MIExit
            // 
            this.MIExit.Name = "MIExit";
            this.MIExit.Size = new System.Drawing.Size(175, 26);
            this.MIExit.Text = "Exit";
            this.MIExit.Click += new System.EventHandler(this.MIExit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTime.Location = new System.Drawing.Point(31, 539);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 37);
            this.lblTime.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDate.Location = new System.Drawing.Point(33, 597);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 27);
            this.lblDate.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(624, 41);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 22);
            this.lblDisplay.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnEmRegister);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(912, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 618);
            this.panel1.TabIndex = 4;
            // 
            // btnEmRegister
            // 
            this.btnEmRegister.Image = global::login_1.Properties.Resources.Designcontest_Ecommerce_Business_Admin_256;
            this.btnEmRegister.Location = new System.Drawing.Point(97, 292);
            this.btnEmRegister.Name = "btnEmRegister";
            this.btnEmRegister.Size = new System.Drawing.Size(79, 63);
            this.btnEmRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmRegister.TabIndex = 3;
            this.btnEmRegister.TabStop = false;
            this.btnEmRegister.Click += new System.EventHandler(this.btnEmRegister_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::login_1.Properties.Resources.Icojam_Blue_Bits_Picture_settings_256;
            this.btnSetting.Location = new System.Drawing.Point(97, 373);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(79, 63);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting.TabIndex = 2;
            this.btnSetting.TabStop = false;
            this.btnSetting.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::login_1.Properties.Resources.Saki_NuoveXT_2_Apps_session_logout_128;
            this.btnLogOut.Location = new System.Drawing.Point(97, 453);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(79, 63);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::login_1.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_256;
            this.btnExit.Location = new System.Drawing.Point(97, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 63);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login_1.Properties.Resources._1717055419250;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 646);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grifindo Toys";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEmRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xzcToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ToolStripMenuItem MReg;
        private System.Windows.Forms.ToolStripMenuItem MIAdReg;
        private System.Windows.Forms.ToolStripMenuItem MIEmpReg;
        private System.Windows.Forms.ToolStripMenuItem MSalary;
        private System.Windows.Forms.ToolStripMenuItem MSetting;
        private System.Windows.Forms.ToolStripMenuItem MISalSetting;
        private System.Windows.Forms.ToolStripMenuItem MILogout;
        private System.Windows.Forms.ToolStripMenuItem MIExit;
        private System.Windows.Forms.ToolStripMenuItem MISalDet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnLogOut;
        private System.Windows.Forms.PictureBox btnSetting;
        private System.Windows.Forms.PictureBox btnEmRegister;
        private System.Windows.Forms.ToolStripMenuItem MISalCal;
        private System.Windows.Forms.ToolStripMenuItem MISReport;
        private System.Windows.Forms.ToolStripMenuItem MIIindReport;
    }
}