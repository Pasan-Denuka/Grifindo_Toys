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
    public partial class Salary_Dt_Reg : Form
    {
        public Salary_Dt_Reg()
        {
            InitializeComponent();
        }
         
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        string Eid;
        decimal basePValue, MthSalary, OTRate, OTHours, Allow;
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
                        txtEmName.Text = R.GetValue(1).ToString();
                        txtMonth.Text=R.GetValue(2).ToString();
                        txtMonthlySalary.Text=R.GetValue(3).ToString();
                        txtOTRate.Text=R.GetValue(4).ToString();
                        txtOTHours.Text=R.GetValue(5).ToString();
                        txtAllowance.Text=R.GetValue(6).ToString();
                        lblBasePayValue.Text=R.GetValue(7).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    txtEmName.Text = "";
                    txtMonth.Text = "";
                    txtMonthlySalary.Text = "";
                    txtOTRate.Text = "";
                    txtOTHours.Text = "";
                    txtAllowance.Text = "";
                    lblBasePayValue.Text = "";

                }
                
            }
            catch (Exception SelErr)
            {
                MessageBox.Show("Error while Selecting Employee ID....." + Environment.NewLine + SelErr);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            makanna();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string queUp = "UPDATE EmpBasicSalary SET EmpName='" + txtEmName.Text + "',Month='" + txtMonth.Text + "',MthSalary='" + txtMonthlySalary.Text + "',OTRate='" + txtOTRate.Text + "',OTHours='" + txtOTHours.Text + "',Allowance='" + txtAllowance.Text + "',BasePayValue='" + basePValue.ToString() + "'  WHERE EmpID='" + cmbEmID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Admin ID: " + cmbEmID.SelectedItem.ToString() + ", successfully Update!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();
            }
            catch(Exception UpdateErr)
            {
                MessageBox.Show("Error while Update..." + Environment.NewLine + UpdateErr);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Eid = cmbEmID.SelectedItem.ToString();
                DialogResult resDel = MessageBox.Show("Are you sure, you want to Delete Salary Detatils for Employee ID: " + Eid + " From the Database???", "Confirm to Delete!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM EmpBasicSalary WHERE EmpID='" + Eid + "' ";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Employee ID: " + Eid + " Successfully Deleted Salary Detatils from the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makanna();
                }
            }
            catch(Exception DeleteErr)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + DeleteErr);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Exit???", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            MthSalary = decimal.Parse(txtMonthlySalary.Text);
            OTRate = decimal.Parse(txtOTRate.Text);
            OTHours = decimal.Parse(txtOTHours.Text);
            Allow = decimal.Parse(txtAllowance.Text);
            basePValue = MthSalary + Allow + (OTHours * OTRate);
            lblBasePayValue.Text = basePValue.ToString();
        }

        private void Salary_Dt_Reg_Load(object sender, EventArgs e)
        {
            try
            {
                String getID = "SELECT EmID FROM Employee";
                conn.Open();
                SqlDa = new SqlDataAdapter(getID, conn);
                DataTable Dtem = new DataTable();
                SqlDa.Fill(Dtem);
                conn.Close();
                cmbEmSl.Items.Clear();
                cmbEmSl.Items.Add("--SELECT--");
                foreach (DataRow myRow in Dtem.Rows)
                {
                    cmbEmSl.Items.Add(myRow["EmID"]);
                    
                }
                cmbEmSl.SelectedIndex = 0;
            }
            catch (Exception EmIDLErr)
            {
                MessageBox.Show("Error while Loading Employee ID....." + Environment.NewLine + EmIDLErr);
            }
        }

        private void cmbEmSl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmSl.SelectedIndex > 0)
                {
                    String queGet = "SELECT * FROM Employee WHERE EmID='" + cmbEmSl.SelectedItem + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGet, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    while (R.Read())
                    {
                        txtEmName.Text = R.GetValue(2).ToString();   
                         
                        txtMonth.Focus();
                         
                    }
                    conn.Close();
                }
                else
                {
                    txtEmName.Text = "";

                }

            }
            catch (Exception SelErr)
            {
                MessageBox.Show("Error while Selecting Issue ID....." + Environment.NewLine + SelErr);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (  txtEmName.TextLength > 0 || txtMonth.TextLength > 0 || txtMonthlySalary.TextLength > 0)
                {
                    string queSave = "INSERT INTO EmpBasicSalary(EmpID,EmpName,Month,MthSalary,OTRate,OTHours,Allowance,BasePayValue) VALUES('" + cmbEmSl.SelectedItem+ "','" + txtEmName.Text + "','" + txtMonth.Text + "','" + txtMonthlySalary.Text + "','" + txtOTRate.Text + "','" + txtOTHours.Text + "','" + txtAllowance.Text + "','" + basePValue.ToString() + "')";
                    conn.Open();
                    cmd = new SqlCommand(queSave, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Employee ID: " + cmbEmSl.SelectedItem + ", Successfully Save to the Database!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makanna();
                }
                else
                {
                    MessageBox.Show("Employee ID, Employee Name, Month, Month Salary Cannot be a Blank!", "Fill the Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch(Exception SaveErr)
            {
                MessageBox.Show("Error while Save..." + Environment.NewLine + SaveErr);
            }
        }
        private void makanna()
        {
            cmbEmSl.SelectedIndex = 0;
            txtEmName.Text = "";
            txtMonth.Text = "";
            txtMonthlySalary.Text = "";
            txtOTRate.Text = "";
            txtOTHours.Text = "";
            txtAllowance.Text = "";
            lblBasePayValue.Text = "";
            cmbEmID.SelectedIndex = 0;
            cmbEmID.Visible = false;
            cmbEmSl.Visible = true;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string quwGet = "SELECT EmpID FROM EmpBasicSalary";
                conn.Open();
                SqlDa = new SqlDataAdapter(quwGet, conn);
                DataTable DtAd = new DataTable();
                SqlDa.Fill(DtAd);

                if (DtAd.Rows.Count > 0)
                {
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    cmbEmSl.Visible = false;
                    cmbEmID.Visible = true;
                    cmbEmID.Items.Clear();
                    cmbEmID.Items.Add("--SELECT--");
                    foreach (DataRow r in DtAd.Rows)
                    {
                        cmbEmID.Items.Add(r["EmpID"]);
                    }
                    cmbEmID.SelectedIndex = 0;
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
    

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MthSalary = decimal.Parse(txtMonthlySalary.Text);
            OTRate = decimal.Parse(txtOTRate.Text);
            OTHours = decimal.Parse(txtOTHours.Text);
            Allow = decimal.Parse(txtAllowance.Text);
            basePValue = MthSalary + Allow + (OTHours * OTRate);
            lblBasePayValue.Text = basePValue.ToString();
        }
    }
}
