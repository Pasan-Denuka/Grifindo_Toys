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
    public partial class SalReportcs : Form
    {
        public SalReportcs()
        {
            InitializeComponent();
        }
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Grifindo_Toys;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmID.SelectedIndex > 0)
                {
                    String queGet = "SELECT * FROM SalaryCalculate WHERE EmID='" + cmbEmID.SelectedItem + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGet, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    while (R.Read())
                    {
                        lblName.Text = R.GetValue(1).ToString();
                        lblMonth.Text = R.GetValue(2).ToString();
                        lblNpay.Text = R.GetValue(10).ToString();
                        lblBaP.Text = R.GetValue(11).ToString();
                        lblGrP.Text = R.GetValue(12).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    lblName.Text = "";
                    lblMonth.Text = "";
                    lblNpay.Text = "";
                    lblBaP.Text = "";
                    lblGrP.Text = "";


                }
            }
            catch (Exception SelErr)
            {
                MessageBox.Show("Error while Selecting Employee ID....." + Environment.NewLine + SelErr);
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

        private void SalReportcs_Load(object sender, EventArgs e)
        {
            try
            {
                String getID = "SELECT EmID FROM SalaryCalculate";
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
            }
            catch (Exception EmIDLErr)
            {
                MessageBox.Show("Error while Loading Employee ID....." + Environment.NewLine + EmIDLErr);
            }
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            cmbEmID.SelectedIndex = 0;
            lblName.Text = "";
            lblMonth.Text = "";
            lblBaP.Text = "";
            lblGrP.Text = "";
            lblNpay.Text = "";
        }
    }
}
