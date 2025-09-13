namespace login_1
{
    partial class SalReportcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalReportcs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNpay = new System.Windows.Forms.Label();
            this.lblBaP = new System.Windows.Forms.Label();
            this.lblGrP = new System.Windows.Forms.Label();
            this.btnCl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALARY REPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID:";
            // 
            // cmbEmID
            // 
            this.cmbEmID.FormattingEnabled = true;
            this.cmbEmID.Location = new System.Drawing.Point(183, 84);
            this.cmbEmID.Name = "cmbEmID";
            this.cmbEmID.Size = new System.Drawing.Size(194, 30);
            this.cmbEmID.TabIndex = 2;
            this.cmbEmID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Month:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(179, 191);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(15, 22);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = " ";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(12, 243);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(134, 22);
            this.lblReport.TabIndex = 5;
            this.lblReport.Text = "Non-Pay Value:";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::login_1.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_256;
            this.btnExit.Location = new System.Drawing.Point(496, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(179, 146);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 22);
            this.lblName.TabIndex = 8;
            this.lblName.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Employee Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Base-Pay Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gross-Pay Value:";
            // 
            // lblNpay
            // 
            this.lblNpay.AutoSize = true;
            this.lblNpay.Location = new System.Drawing.Point(179, 243);
            this.lblNpay.Name = "lblNpay";
            this.lblNpay.Size = new System.Drawing.Size(15, 22);
            this.lblNpay.TabIndex = 11;
            this.lblNpay.Text = " ";
            // 
            // lblBaP
            // 
            this.lblBaP.AutoSize = true;
            this.lblBaP.Location = new System.Drawing.Point(179, 286);
            this.lblBaP.Name = "lblBaP";
            this.lblBaP.Size = new System.Drawing.Size(15, 22);
            this.lblBaP.TabIndex = 12;
            this.lblBaP.Text = " ";
            // 
            // lblGrP
            // 
            this.lblGrP.AutoSize = true;
            this.lblGrP.Location = new System.Drawing.Point(179, 330);
            this.lblGrP.Name = "lblGrP";
            this.lblGrP.Size = new System.Drawing.Size(15, 22);
            this.lblGrP.TabIndex = 13;
            this.lblGrP.Text = " ";
            // 
            // btnCl
            // 
            this.btnCl.BackColor = System.Drawing.Color.Blue;
            this.btnCl.ForeColor = System.Drawing.Color.White;
            this.btnCl.Location = new System.Drawing.Point(443, 440);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(105, 37);
            this.btnCl.TabIndex = 14;
            this.btnCl.Text = "CLEAR";
            this.btnCl.UseVisualStyleBackColor = false;
            this.btnCl.Click += new System.EventHandler(this.btnCl_Click);
            // 
            // SalReportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(560, 489);
            this.ControlBox = false;
            this.Controls.Add(this.btnCl);
            this.Controls.Add(this.lblGrP);
            this.Controls.Add(this.lblBaP);
            this.Controls.Add(this.lblNpay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalReportcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Report";
            this.Load += new System.EventHandler(this.SalReportcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNpay;
        private System.Windows.Forms.Label lblBaP;
        private System.Windows.Forms.Label lblGrP;
        private System.Windows.Forms.Button btnCl;
    }
}