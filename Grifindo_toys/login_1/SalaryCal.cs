using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_1
{
    public partial class SalaryCal : Form
    {
        public SalaryCal()
        {
            InitializeComponent();
        }
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        
        decimal govtax,npay,totsal,salcylrange,abstday,bpay,gpay;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblBasePay.Visible = true;
            bpay = decimal.Parse(lblBasePay.Text);
            govtax = decimal.Parse(txtGovTaxRate.Text);
            totsal = decimal.Parse(lblMonthSalary.Text);
            salcylrange = decimal.Parse(lblDtRange.Text);
            abstday = decimal.Parse(txtAbDay.Text);

            npay = (totsal / salcylrange) * abstday;
            lblNoPay.Text = npay.ToString("F2");
            gpay = bpay - (npay + bpay * govtax);
            lblGrossPay.Text = gpay.ToString("F2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                    string queSave = "INSERT INTO SalaryCalculate(EmID,EmName,Month,MonSalary,GovTax,SalCylID,DateRange,Leaves,AbsentDays,Holidays,NoPayValue,BasePayValue,GrossPayValue) VALUES('" + cmbEmID.SelectedItem + "','" + lblEmName.Text + "','" + lblMonth.Text + "','"+lblMonthSalary.Text+"','" + txtGovTaxRate.Text + "','" + cmbSlCyID.SelectedItem + "','" + lblDtRange.Text + "','" + txtLeave.Text + "','" + txtAbDay.Text + "','"+txtHol.Text+"','"+lblNoPay.Text+"','"+lblBasePay.Text+"','"+lblGrossPay.Text+"')";
                    conn.Open();
                    cmd = new SqlCommand(queSave, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Employee ID: " + cmbEmID.SelectedItem + ", Successfully Save to the Database!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makanna();
                
            }
            catch (Exception SaveErr)
            {
                MessageBox.Show("Error while Save..." + Environment.NewLine + SaveErr);
            }
        }

        private void SalaryCal_Load(object sender, EventArgs e)
        {
            try
            {
                String getID = "SELECT EmID FROM Employee";
                conn.Open();
                SqlDa = new SqlDataAdapter(getID, conn);
                DataTable Dtem = new DataTable();
                SqlDa.Fill(Dtem);
                conn.Close();
                cmbEmID.Items.Clear();
                cmbEmID.Items.Add("--SELECT--");
                foreach (DataRow myRow in Dtem.Rows)
                {
                    cmbEmID.Items.Add(myRow["EmID"]);

                }
                cmbEmID.SelectedIndex = 0;

                String getSID = "SELECT SalCyID  FROM SalarySetting";
                conn.Open();
                SqlDa = new SqlDataAdapter(getSID, conn);
                DataTable DtSem = new DataTable();
                SqlDa.Fill(DtSem);
                conn.Close();
                cmbSlCyID.Items.Clear();
                cmbSlCyID.Items.Add("--SELECT--");
                foreach (DataRow myRow in DtSem.Rows)
                {
                    cmbSlCyID.Items.Add(myRow["SalCyID"]);

                }
                cmbSlCyID.SelectedIndex = 0;
            }
            catch (Exception EmIDLErr)
            {
                MessageBox.Show("Error while Loading Employee ID....." + Environment.NewLine + EmIDLErr);
            }
        }

        private void cmbEmID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmID.SelectedIndex > 0)
                {
                    String queGet = "SELECT * FROM EmpBasicSalary WHERE EmpID='" + cmbEmID.SelectedItem + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGet, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    while (R.Read())
                    {
                        lblEmName.Text = R.GetValue(1).ToString();
                        lblMonth.Text = R.GetValue(2).ToString();
                        lblMonthSalary.Text = R.GetValue(3).ToString();
                        lblBasePay.Text = R.GetValue(7).ToString();

                    }
                    conn.Close();
                }
                else
                {
                    lblEmName.Text = "";
                    lblMonth.Text = "";
                    lblMonthSalary.Text = "";
                    lblBasePay.Text = "";
                }

            }
            catch (Exception SelErr)
            {
                MessageBox.Show("Error while Selecting Employee ID....." + Environment.NewLine + SelErr);
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSlCyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSlCyID.SelectedIndex > 0)
                {
                    String queGet = "SELECT * FROM SalarySetting WHERE SalCyID='" + cmbSlCyID.SelectedItem + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGet, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    while (R.Read())
                    {
                        lblDtRange.Text = R.GetValue(3).ToString();


                    }
                    conn.Close();
                }
                else
                {
                    lblDtRange.Text = "";

                }

            }
            catch (Exception SelErr)
            {
                MessageBox.Show("Error while Selecting Employee ID....." + Environment.NewLine + SelErr);
            }
        }
        private void makanna()
        {
            cmbEmID.SelectedIndex = 0;
            lblEmName.Text = "";
            lblMonth.Text = "";
            lblMonthSalary.Text = "";
            txtGovTaxRate.Text = "";
            lblDtRange.Text = "";
            txtLeave.Text = "";
            txtHol.Text = "";
            cmbSlCyID.SelectedIndex = 0;
            txtAbDay.Text = "";
            lblNoPay.Text = "";
            lblBasePay.Text = "";
            lblGrossPay.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            makanna();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Exit???", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
        }
    }
}
