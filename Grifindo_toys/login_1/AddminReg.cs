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
    public partial class AddminReg : Form
    {
        public AddminReg()
        {
            InitializeComponent();
        }
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Grifindo_Toys;Integrated Security=True");
        string gen, aid;
        private void AddminReg_Load(object sender, EventArgs e)
        {
            cmbCS.SelectedIndex = 0;
            AutoNumGen();
        }
        private void AutoNumGen()
        {
            try
            {
                int admin = 0;
                string queFind = "SELECT SerialNo FROM Admin";
                conn.Open();
                SqlDa = new SqlDataAdapter(queFind, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);

                if (Dt.Rows.Count > 0)
                {
                    string queMax = "SELECT MAX(SerialNo) FROM Admin";
                    cmd = new SqlCommand(queMax, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        admin = int.Parse(R.GetValue(0).ToString());
                    }
                    admin += 1;
                }
                else
                {
                    admin = 1;
                }
                if (admin < 10) { aid = "GTA-00000" + admin; }
                else if (admin < 100) { aid = "GTA-0000" + admin; }
                else if (admin < 1000) { aid = "GTA-000" + admin; }
                else if (admin < 10000) { aid = "GTA-00" + admin; }
                else if (admin < 100000) { aid = "GTA-0" + admin; }
                else if (admin < 1000000) { aid = "GTA-" + admin; }
                conn.Close();
                lblAdID.Text = aid;

            }
            catch(Exception NumGenError)
            {
                MessageBox.Show("Error While Number Generation..." + Environment.NewLine + NumGenError);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
        private void clear()
        {
            txtAName.Text = "";
            dtpDOB.Text = "";
            txtNIC.Text = "";
            txtConNo.Text = "";
            rbF.Checked = false;
            rbM.Checked = false;
            cmbCS.SelectedIndex = 0;
            txtAdd.Text = "";
            txtuserName.Text = "";
            txtPassword.Text = "";
            lblAdID.Visible = true;
            cmbAdID.Visible = false;
            btnSave.Visible = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            cmbCS.SelectedIndex = 0; 
            txtAName.Focus();
            AutoNumGen();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string quwGet = "SELECT AdID FROM Admin";
                conn.Open();
                SqlDa = new SqlDataAdapter(quwGet, conn);
                DataTable DtAd = new DataTable();
                SqlDa.Fill(DtAd);

                if (DtAd.Rows.Count > 0)
                {
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    lblAdID.Visible = false;
                    cmbAdID.Visible = true;
                    cmbAdID.Items.Clear();
                    cmbAdID.Items.Add("--SELECT--");
                    foreach(DataRow r in DtAd.Rows)
                    {
                        cmbAdID.Items.Add(r["AdID"]);
                    }
                    cmbAdID.SelectedIndex = 0;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCS.SelectedIndex > 0)
                {
                    if (rbM.Checked == true) { gen = "Male"; }
                    else if (rbF.Checked == true) { gen = "Female"; }

                    string queSave="INSERT INTO Admin(AdID,AdName,DOB,NIC,ConNo,Gender,CStatus,AdAddress,Username,Password) VALUES('"+aid+"','"+txtAName.Text+"','"+dtpDOB.Text+"','"+txtNIC.Text+"','"+txtConNo.Text+"','"+gen+"','"+cmbCS.SelectedItem.ToString()+"','"+txtAdd.Text+"','"+txtuserName.Text+"','"+txtPassword.Text+"')";
                    conn.Open();
                    cmd = new SqlCommand(queSave, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Admin ID: " + aid + ", Successfully Save to the Database!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("Civil Status need to Select!", "Selection Comulsory!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCS.Focus();
                }
            }
            catch(Exception SaveErr)
            {
                MessageBox.Show("Error while Save..." + Environment.NewLine + SaveErr);
            }
        }

        private void cmbAdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAdID.SelectedIndex > 0)
                {
                    aid = cmbAdID.SelectedItem.ToString();
                    string queData = "SELECT * FROM Admin WHERE AdID='" + aid + "'";
                    conn.Open();
                    cmd = new SqlCommand(queData, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        txtAName.Text = Rd.GetValue(2).ToString();
                        dtpDOB.Text = Rd.GetValue(3).ToString();
                        txtNIC.Text = Rd.GetValue(4).ToString();
                        txtConNo.Text = Rd.GetValue(5).ToString();
                        gen = Rd.GetValue(6).ToString();
                        cmbCS.SelectedItem = Rd.GetValue(7).ToString();
                        txtAdd.Text = Rd.GetValue(8).ToString();
                        txtuserName.Text = Rd.GetValue(9).ToString();
                        txtPassword.Text = Rd.GetValue(10).ToString();
                    }
                    if (gen.Equals("Male")) { rbM.Checked = true; }
                    else if (gen.Equals("Female")) { rbF.Checked = true; }
                    conn.Close();
                }
                
                else
                {
                    txtAdd.Text = "";
                    txtAName.Text = "";
                    txtConNo.Text = "";
                    txtNIC.Text = "";
                    dtpDOB.Text = "";
                    rbF.Checked = false;
                    rbM.Checked = false;
                    cmbCS.SelectedIndex = 0;
                    txtuserName.Text = "";
                    txtPassword.Text = "";
                }

            }
            catch(Exception SelectErr)
            {
                MessageBox.Show("Error while Selecting Admin ID..." + Environment.NewLine + SelectErr);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbM.Checked == true) { gen = "Male"; }
                else if (rbF.Checked == true) { gen = "Female"; }

                string queUp = "UPDATE Admin SET AdName='" + txtAName.Text + "',DOB='" + dtpDOB.Text + "',NIC='" + txtNIC.Text + "',ConNo='" + txtConNo.Text + "',Gender='" + gen + "',CStatus='" + cmbCS.SelectedIndex.ToString() + "',AdAddress='" + txtAdd.Text + "',Username='" + txtuserName.Text + "',Password='" + txtPassword.Text + "' WHERE AdID='" + cmbAdID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Admin ID: " + cmbAdID.SelectedItem.ToString() + ", successfully Update!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
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
                aid = cmbAdID.SelectedItem.ToString();
                DialogResult resDel = MessageBox.Show("Are you sure, you want to Delete Admin ID: " + aid + " From the Database???", "Confirm to Delete!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM Admin WHERE AdID='" + aid + "' ";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Addmin ID: " + aid + " Successfully Deleted from the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch(Exception DeleteErr)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + DeleteErr);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resEx=MessageBox.Show("Are you sure, You want to Exit???", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                MainForm frm=new MainForm();
                frm.Show();
                this.Hide();
            }
        }
    }
}
