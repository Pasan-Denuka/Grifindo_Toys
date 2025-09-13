namespace login_1
{
    partial class SalaryCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryCal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLeave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAbDay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGovTaxRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNoPay = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBasePay = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEmName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.lblMonthSalary = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDtRange = new System.Windows.Forms.Label();
            this.cmbSlCyID = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALARY CALCULATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID:";
            // 
            // cmbEmID
            // 
            this.cmbEmID.FormattingEnabled = true;
            this.cmbEmID.Location = new System.Drawing.Point(191, 97);
            this.cmbEmID.Name = "cmbEmID";
            this.cmbEmID.Size = new System.Drawing.Size(215, 30);
            this.cmbEmID.TabIndex = 2;
            this.cmbEmID.SelectedIndexChanged += new System.EventHandler(this.cmbEmID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Month:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date Range:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Month Salary:";
            // 
            // txtHol
            // 
            this.txtHol.Location = new System.Drawing.Point(645, 293);
            this.txtHol.Name = "txtHol";
            this.txtHol.Size = new System.Drawing.Size(215, 30);
            this.txtHol.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Holidays";
            // 
            // txtLeave
            // 
            this.txtLeave.Location = new System.Drawing.Point(645, 188);
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.Size = new System.Drawing.Size(215, 30);
            this.txtLeave.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Leaves:";
            // 
            // txtAbDay
            // 
            this.txtAbDay.Location = new System.Drawing.Point(645, 239);
            this.txtAbDay.Name = "txtAbDay";
            this.txtAbDay.Size = new System.Drawing.Size(215, 30);
            this.txtAbDay.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Absent Days:";
            // 
            // txtGovTaxRate
            // 
            this.txtGovTaxRate.Location = new System.Drawing.Point(191, 288);
            this.txtGovTaxRate.Name = "txtGovTaxRate";
            this.txtGovTaxRate.Size = new System.Drawing.Size(191, 30);
            this.txtGovTaxRate.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Goverment Tax Rate:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 22);
            this.label11.TabIndex = 19;
            this.label11.Text = "No-Pay Value:";
            // 
            // lblNoPay
            // 
            this.lblNoPay.AutoSize = true;
            this.lblNoPay.Location = new System.Drawing.Point(163, 380);
            this.lblNoPay.Name = "lblNoPay";
            this.lblNoPay.Size = new System.Drawing.Size(15, 22);
            this.lblNoPay.TabIndex = 20;
            this.lblNoPay.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 22);
            this.label13.TabIndex = 21;
            this.label13.Text = "Base-Pay Value:";
            // 
            // lblBasePay
            // 
            this.lblBasePay.AutoSize = true;
            this.lblBasePay.Location = new System.Drawing.Point(163, 428);
            this.lblBasePay.Name = "lblBasePay";
            this.lblBasePay.Size = new System.Drawing.Size(15, 22);
            this.lblBasePay.TabIndex = 22;
            this.lblBasePay.Text = " ";
            this.lblBasePay.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 471);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 22);
            this.label15.TabIndex = 23;
            this.label15.Text = "Gross-Pay Value:";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(163, 471);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(15, 22);
            this.lblGrossPay.TabIndex = 24;
            this.lblGrossPay.Text = " ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Blue;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(717, 374);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 35);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(717, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 35);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(717, 465);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 35);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEmName
            // 
            this.lblEmName.AutoSize = true;
            this.lblEmName.Location = new System.Drawing.Point(187, 149);
            this.lblEmName.Name = "lblEmName";
            this.lblEmName.Size = new System.Drawing.Size(15, 22);
            this.lblEmName.TabIndex = 28;
            this.lblEmName.Text = " ";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::login_1.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_256;
            this.btnExit.Location = new System.Drawing.Point(843, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 31;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMonthSalary
            // 
            this.lblMonthSalary.AutoSize = true;
            this.lblMonthSalary.Location = new System.Drawing.Point(187, 250);
            this.lblMonthSalary.Name = "lblMonthSalary";
            this.lblMonthSalary.Size = new System.Drawing.Size(15, 22);
            this.lblMonthSalary.TabIndex = 33;
            this.lblMonthSalary.Text = " ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(490, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 22);
            this.label16.TabIndex = 34;
            this.label16.Text = "Salary Cycle ID:";
            // 
            // lblDtRange
            // 
            this.lblDtRange.AutoSize = true;
            this.lblDtRange.Location = new System.Drawing.Point(641, 149);
            this.lblDtRange.Name = "lblDtRange";
            this.lblDtRange.Size = new System.Drawing.Size(15, 22);
            this.lblDtRange.TabIndex = 35;
            this.lblDtRange.Text = " ";
            // 
            // cmbSlCyID
            // 
            this.cmbSlCyID.FormattingEnabled = true;
            this.cmbSlCyID.Location = new System.Drawing.Point(645, 97);
            this.cmbSlCyID.Name = "cmbSlCyID";
            this.cmbSlCyID.Size = new System.Drawing.Size(215, 30);
            this.cmbSlCyID.TabIndex = 36;
            this.cmbSlCyID.SelectedIndexChanged += new System.EventHandler(this.cmbSlCyID_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(187, 196);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(15, 22);
            this.lblMonth.TabIndex = 32;
            this.lblMonth.Text = " ";
            // 
            // SalaryCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(924, 530);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSlCyID);
            this.Controls.Add(this.lblDtRange);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblMonthSalary);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblEmName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblBasePay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblNoPay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGovTaxRate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAbDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLeave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalaryCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Calculate";
            this.Load += new System.EventHandler(this.SalaryCal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLeave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAbDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGovTaxRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNoPay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBasePay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEmName;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label lblMonthSalary;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDtRange;
        private System.Windows.Forms.ComboBox cmbSlCyID;
        private System.Windows.Forms.Label lblMonth;
    }
}