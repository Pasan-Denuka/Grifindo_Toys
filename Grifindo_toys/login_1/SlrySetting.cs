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
    public partial class SlrySetting : Form
    {
        public SlrySetting()
        {
            InitializeComponent();
        }
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        string sid;
         
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string queGet = "SELECT SalCyID FROM SalarySetting";
                conn.Open();
                SqlDa = new SqlDataAdapter(queGet, conn);
                DataTable DtEm = new DataTable();
                SqlDa.Fill(DtEm);
                if (DtEm.Rows.Count > 0)
                {
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    lblSalaryID.Visible = false;
                    cmbSalaryID.Visible = true;
                    cmbSalaryID.Items.Clear();
                    cmbSalaryID.Items.Add("--SELECT--");
                    foreach (DataRow R in DtEm.Rows)
                    {
                        cmbSalaryID.Items.Add(R["SalCyID"]);
                    }
                    cmbSalaryID.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Database is Empty!", "No Records!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conn.Close();
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + SearchErr);
            }
        }

        private void cmbSalaryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSalaryID.SelectedIndex > 0)
                {
                    sid = cmbSalaryID.SelectedItem.ToString();
                    string queData = "SELECT *FROM SalarySetting WHERE SalCyID='" + sid + "'";
                    conn.Open();
                    cmd = new SqlCommand(queData, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        cmbSalMonth.SelectedItem = Rd.GetValue(2).ToString();
                        txtDateRange.Text = Rd.GetValue(3).ToString();
                        dtpStartDate.Text = Rd.GetValue(4).ToString();
                        dtpEndDate.Text = Rd.GetValue(5).ToString();
                        txtLeaves.Text = Rd.GetValue(6).ToString();
                         
                    }
                    
                    conn.Close();
                }
                else
                {
                    cmbSalMonth.SelectedIndex = 0;
                    txtDateRange.Text = "";
                    dtpStartDate.Text = "";
                    dtpEndDate.Text = "";
                    txtLeaves.Text = "";
                     
                }
            }
            catch (Exception SelectErr)
            {
                MessageBox.Show("Erro While Select..." + Environment.NewLine + SelectErr);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Makanna();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string queUp = "UPDATE SalarySetting SET MonthSalCyl='" + cmbSalMonth.SelectedItem.ToString() + "',DateRange='" + txtDateRange.Text + "',DRStart='" + dtpStartDate.Text + "',DREnd='" + dtpEndDate.Text + "',Leaves='" + txtLeaves.Text +  "'  WHERE SalCyID='" + cmbSalaryID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Salary Cycle ID: " + cmbSalaryID.SelectedItem.ToString() + ", successfully Update!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Makanna();
            }
            catch (Exception UpdateErr)
            {
                MessageBox.Show("Error while Update..." + Environment.NewLine + UpdateErr);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sid = cmbSalaryID.SelectedItem.ToString();
                DialogResult resDel = MessageBox.Show("Are you sure, you want to Delete Salary Detatils for Salary Cycle ID: " + sid + " From the Database???", "Confirm to Delete!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM SalarySetting WHERE SalCyID='" + sid + "' ";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Salary Setting ID: " + sid + " Successfully Deleted Salary Detatils from the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Makanna();
                }
            }
            catch (Exception DeleteErr)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + DeleteErr);
            }
        }

        private void SlrySetting_Load(object sender, EventArgs e)
        {
            cmbSalMonth.SelectedIndex = 0;
            AutoNumGen();
        }

        private void Makanna()
        {
            cmbSalaryID.Visible = false;
            cmbSalMonth.SelectedIndex = 0;
            txtDateRange.Text = "";
            dtpStartDate.Text = "";
            dtpEndDate.Text = "";
            txtLeaves.Text = "";
            lblSalaryID.Visible = true;
            btnSave.Visible=true;
            btnUpdate.Visible=false;
            btnDelete.Visible=false;
            cmbSalMonth.Focus();
            AutoNumGen();
        }
        private void AutoNumGen()
        {
            try
            {
                int salary = 0;
                string queFind = "SELECT SerialNo FROM SalarySetting";
                conn.Open();
                SqlDa = new SqlDataAdapter(queFind, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);
                if (Dt.Rows.Count > 0)
                {
                    string queMax = "SELECT MAX(SerialNo) FROM SalarySetting";
                    cmd = new SqlCommand(queMax, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        salary = int.Parse(R.GetValue(0).ToString());
                    }
                    salary += 1;
                }
                else
                {
                    salary = 1;
                }
                if (salary < 10) { sid = "GTSC-0000" + salary; }
                else if (salary < 100) { sid = "GTSC-000" + salary; }
                else if (salary < 1000) { sid = "GTSC-00" + salary; }
                else if (salary < 10000) { sid = "GTSc-0" + salary; }
                else if (salary < 100000) { sid = "GTSC-" + salary; }
                 

                conn.Close();
                lblSalaryID.Text = sid;
            }
            catch (Exception NumGenError)
            {
                MessageBox.Show("Error while Number Generation..." + Environment.NewLine + NumGenError);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime endDate = DateTime.Parse(dtpEndDate.Text);
                DateTime startDate = DateTime.Parse(dtpStartDate.Text);
                int dtcal = (endDate - startDate).Days + 1;
                int drange;
                if (!int.TryParse(txtDateRange.Text, out drange))
                {
                    MessageBox.Show("Please enter a valid number for the date range.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDateRange.Focus();

                    return;
                }
                if (dtcal == drange)
                {
                    string queSave = "INSERT INTO SalarySetting(SalCyID,MonthSalCyl,DateRange,DRStart,DREnd,Leaves) VALUES('" + sid + "','" + cmbSalMonth.SelectedItem + "','" + txtDateRange.Text + "','" + dtpStartDate.Text + "','" + dtpEndDate.Text + "','" + txtLeaves.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(queSave, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Salary Cycle ID: " + sid + ", Successfully Save to the Database!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Makanna();
                }
                else
                {
                    MessageBox.Show("Salary cycle date range and Date range must match", "Match the Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDateRange.Focus();
                    Makanna();
                }
            }
            catch (Exception SaveRrr)
            {
                MessageBox.Show("Erro while Save..." + Environment.NewLine + SaveRrr);
            }

        }
        
    }
}
