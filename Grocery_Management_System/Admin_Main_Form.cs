using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Grocery_Management_System
{
    public partial class Admin_Main_Form : Form
    {
        public Admin_Main_Form()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
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

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            openChildForm(new Employee_Form());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
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
