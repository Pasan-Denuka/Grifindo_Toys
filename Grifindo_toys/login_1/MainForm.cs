using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (log_1.uType != "ADMIN")
            {
                MReg.Visible = false;
                MISalDet.Visible = false;
                MISalCal.Visible = false;
                MISalSetting.Visible = false;
            }
            lblDisplay.Text = "Welcome to the System, " + login_2.rName + "!";
        }

        private void MIAdReg_Click(object sender, EventArgs e)
        {
            AddminReg frmAd = new AddminReg();
            frmAd.Show();
            this.Show();
        }

        private void MIEmpReg_Click(object sender, EventArgs e)
        {
            EmpReg frmEp = new EmpReg();
            frmEp.Show();
            this.Hide();
        }

        private void MILogout_Click(object sender, EventArgs e)
        {
            log_1 frm = new log_1();
            frm.Show();
            this.Hide();
        }

        private void MIExit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, you want to Exit???", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MISalDet_Click(object sender, EventArgs e)
        {
            Salary_Dt_Reg frm = new Salary_Dt_Reg();
            frm.Show();
            this.Hide();
        }

        private void MISalSetting_Click(object sender, EventArgs e)
        {
            SlrySetting frm = new SlrySetting();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, you want to Exit???", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            log_1 frm = new log_1();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SlrySetting frm = new SlrySetting();
            frm.Show();
            this.Hide();
        }

        private void btnEmRegister_Click(object sender, EventArgs e)
        {
            EmpReg frmEp = new EmpReg();
            frmEp.Show();
            this.Hide();
        }

        private void MISalCal_Click(object sender, EventArgs e)
        {

            SalaryCal frm = new SalaryCal();
            frm.Show();
            this.Hide();
        }

        private void MIIindReport_Click(object sender, EventArgs e)
        {
            SalReportcs frm = new SalReportcs();
            frm.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
