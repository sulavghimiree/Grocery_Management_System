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
    public partial class Employee_Main_Form : Form
    {
        public Employee_Main_Form()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSellItems_Click(object sender, EventArgs e)
        {
            openChildForm(new SellForm());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
