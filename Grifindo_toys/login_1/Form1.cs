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
    public partial class log_1 : Form
    {
        public log_1()
        {
            InitializeComponent();
        }

        public static string uType;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            uType = cmbUType.SelectedItem.ToString();
            login_2 frm = new login_2();
            frm.Show();
            this.Hide();
        }

        private void log_1_Load(object sender, EventArgs e)
        {
            cmbUType.SelectedIndex = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Exit???", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
