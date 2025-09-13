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
    public partial class EmpReg : Form
    {
        public EmpReg()
        {
            InitializeComponent();
        }
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        string gen, eid;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

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

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtNIC.TextLength == 10 || txtNIC.TextLength == 12)
            {
                txtNIC.ForeColor = Color.Black;
            }
            else
            {
                txtNIC.ForeColor = Color.Red;
            }
        }
        private void Clear()
        {
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            dtpDOB.Text = "";
            txtNIC.Text = "";
            txtConNo.Text = "";
            rbF.Checked = false;
            rbM.Checked = false;
            cmbCS.SelectedIndex = 0;
            txtAdd.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            lblEmID.Visible = true;
            cmbEmID.Visible = false;
            btnSave.Visible = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            txtFName.Focus();
            AutoNumGen();
        }

        private void txtConNo_TextChanged(object sender, EventArgs e)
        {
            if (txtConNo.TextLength < 10)
            {
                txtConNo.ForeColor = Color.Red;
            }
            else
            {
                txtConNo.ForeColor = Color.Black;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCS.SelectedIndex > 0)
                {
                    if (rbM.Checked == true) { gen = "Male"; }
                    else if (rbF.Checked == true) { gen = "Female"; }
                    string queSave = "INSERT INTO Employee(EmID,EFName,EMName,ELName,NIC,ConNo,DOB,Gender,CStatus,EAddress,UserName,Password) VALUES('" + eid + "','" + txtFName.Text + "','" + txtMName.Text + "','" + txtLName.Text + "','" + txtNIC.Text + "','" + txtConNo.Text + "','" + dtpDOB.Text + "','" + gen + "','" + cmbCS.SelectedItem.ToString() + "','" + txtAdd.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(queSave, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Employee ID: " + eid + ", successfully Save to the Database!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Civil Status need to Select!", "Selection Compulsory!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCS.Focus();
                }
            }
            catch(Exception SaveRrr)
            {
                MessageBox.Show("Erro while Save..." + Environment.NewLine + SaveRrr);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string queGet = "SELECT EmID FROM Employee";
                conn.Open();
                SqlDa = new SqlDataAdapter(queGet, conn);
                DataTable DtEm = new DataTable();
                SqlDa.Fill(DtEm);
                if (DtEm.Rows.Count > 0)
                {
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    lblEmID.Visible = false;
                    cmbEmID.Visible = true;
                    cmbEmID.Items.Clear();
                    cmbEmID.Items.Add("--SELECT--");
                    foreach(DataRow R in DtEm.Rows)
                    {
                        cmbEmID.Items.Add(R["EmID"]);
                    }
                    cmbEmID.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Database is Empty!", "No Records!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conn.Close();
            }
            catch(Exception SearchErr)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + SearchErr);
            }
        }

        private void cmbEmID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmID.SelectedIndex > 0)
                {
                    eid = cmbEmID.SelectedItem.ToString();
                    string queData = "SELECT *FROM Employee WHERE EmID='" + eid + "'";
                    conn.Open();
                    cmd = new SqlCommand(queData, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        txtFName.Text = Rd.GetValue(2).ToString();
                        txtMName.Text= Rd.GetValue(3).ToString();
                        txtLName.Text= Rd.GetValue(4).ToString();
                        txtNIC.Text= Rd.GetValue(5).ToString();
                        txtConNo.Text= Rd.GetValue(6).ToString();
                        dtpDOB.Text= Rd.GetValue(7).ToString();
                        gen= Rd.GetValue(8).ToString();
                        cmbCS.SelectedItem= Rd.GetValue(9).ToString();
                        txtAdd.Text= Rd.GetValue(10).ToString();
                        txtUserName.Text= Rd.GetValue(11).ToString();
                        txtPassword.Text= Rd.GetValue(12).ToString();
                    }
                    if (gen.Equals("Male")) { rbM.Checked = true; }
                    else if (gen.Equals("Female")) { rbF.Checked = true; }
                    conn.Close();
                }
                else
                {
                    txtFName.Text = "";
                    txtMName.Text = "";
                    txtLName.Text = "";
                    txtNIC.Text = "";
                    dtpDOB.Text = "";
                    rbF.Checked = false;
                    rbM.Checked = false;
                    cmbCS.SelectedIndex = 0;
                    txtAdd.Text = "";
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch(Exception SelectErr)
            {
                MessageBox.Show("Erro While Select..." + Environment.NewLine + SelectErr);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbM.Checked == true) { gen = "Male"; }
                else if (rbF.Checked == true) { gen = "Female"; }
                string queUp = "UPDATE Employee SET EFName='" + txtFName.Text + "',EMName='" + txtMName.Text + "',ELName='" + txtLName.Text + "',NIC='" + txtNIC.Text + "',ConNo='" + txtConNo.Text + "',DOB='" + dtpDOB.Text + "',Gender='" + gen + "',CStatus='" + cmbCS.SelectedItem.ToString() + "',EAddress='" + txtAdd.Text + "',UserName='" + txtUserName.Text + "',Password='" + txtPassword.Text + "' WHERE EmID='" + cmbEmID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee ID: " + cmbEmID.SelectedItem.ToString() + ", successfully Update!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
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
                eid = cmbEmID.SelectedItem.ToString();
                DialogResult resDel = MessageBox.Show("Are you sure, you want to Delete Employee ID: " + eid + " from the Database???", "Confirm to Delete!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM Employee WHERE EmID='" + eid + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Employee ID: " + eid + " successfully Delete from the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch(Exception DeleteErr)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + DeleteErr);
            }
        }

        private void EmpReg_Load(object sender, EventArgs e)
        {
            cmbCS.SelectedIndex = 0;
            AutoNumGen();
        }

        private void AutoNumGen()
        {
            try
            {
                int employee = 0;
                string queFind = "SELECT SerialNo FROM Employee";
                conn.Open();
                SqlDa = new SqlDataAdapter(queFind, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);
                if (Dt.Rows.Count > 0)
                {
                    string queMax = "SELECT MAX(SerialNo) FROM Employee";
                    cmd = new SqlCommand(queMax, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        employee = int.Parse(R.GetValue(0).ToString());
                    }
                    employee += 1;
                }
                else
                {
                    employee = 1;
                }
                if (employee < 10) { eid = "GTE-00000" + employee; }
                else if (employee < 100) { eid = "GTE-0000" + employee; }
                else if (employee < 1000) { eid = "GTE-000" + employee; }
                else if (employee < 10000) { eid = "GTE-00" + employee; }
                else if (employee < 100000) { eid = "GTE-0" + employee; }
                else if (employee < 1000000) { eid = "GTE-" + employee; }
                
                conn.Close();
                lblEmID.Text = eid;
            }
            catch(Exception NumGenError)
            {
                MessageBox.Show("Error while Number Generation..." + Environment.NewLine + NumGenError);
            }
        }
    }
}
