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
    public partial class login_2 : Form
    {
        public login_2()
        {
            InitializeComponent();
        }
        public static string rName;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Exit???", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                
                log_1 frm = new log_1();
                frm.Show();
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string un, pw;
                SqlDataAdapter SqlDa = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Grifindo_Toys;Integrated Security=True");
                if(txtUserName.TextLength>0 && txtPassword.TextLength > 0)
                {
                    un = txtUserName.Text;
                    pw = txtPassword.Text;
                    if (log_1.uType == "ADMIN")
                    {
                        string queLog = "SELECT AdName FROM Admin WHERE Username='" + un + "' AND Password='" + pw + "'";
                        conn.Open();
                        SqlDa = new SqlDataAdapter(queLog, conn);
                        DataTable Dt = new DataTable();
                        SqlDa.Fill(Dt);

                        if (Dt.Rows.Count > 0)
                        {
                            cmd = new SqlCommand(queLog, conn);
                            SqlDataReader R = cmd.ExecuteReader();

                            if (R.Read())
                            {
                                rName = R.GetValue(0).ToString();
                            }
                            MainForm frm = new MainForm();
                            frm.Show();
                            this.Hide();//to show mainform

                        }

                        else
                        {   //if enter incorrect username or password, show this message
                            MessageBox.Show("Incorrect Username or Password!", "UNAUTHORIZED ACCESS DENIED!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtUserName.Text = "";
                            txtPassword.Text = "";
                            txtUserName.Focus();//focus to username
                        }
                    }
                    else
                    {
                        string queLog = "SELECT EFName FROM Employee WHERE UserName='" + un + "' AND Password='" + pw + "'";
                        conn.Open();
                        SqlDa = new SqlDataAdapter(queLog, conn);
                        DataTable Dt = new DataTable();
                        SqlDa.Fill(Dt);

                        if (Dt.Rows.Count > 0)
                        {
                            cmd = new SqlCommand(queLog, conn);
                            SqlDataReader R = cmd.ExecuteReader();

                            if (R.Read())
                            {
                                rName = R.GetValue(0).ToString();
                            }
                            MainForm frm = new MainForm();
                            frm.Show();
                            this.Hide();

                        }

                        else
                        {
                            MessageBox.Show("Incorrect Username or Password!", "UNAUTHORIZED ACCESS DENIED!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtUserName.Text = "";
                            txtPassword.Text = "";
                            txtUserName.Focus();
                        }
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password cannot be Blank!", "FILL THE DATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }
            }
            catch(Exception LogErr)
            {
                MessageBox.Show("Error while Login..." + Environment.NewLine + LogErr);
            }
        }

        private void rdbtnShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cheboxSPassword.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = default(char);
            }
        }

        private void login_2_Load(object sender, EventArgs e)
        {
            

        }
    }
}
