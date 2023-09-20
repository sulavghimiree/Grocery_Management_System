using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Management_System
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtadmpass.Text == "soe123789")
            {
                MessageBox.Show("Welcome Admin ! ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin_Main_Form mainform = new Admin_Main_Form();
                mainform.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Admin password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkpswdshow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkpswdshow.Checked == false)
            {
                txtadmpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtadmpass.UseSystemPasswordChar = false;
            }
        }
    }
}
