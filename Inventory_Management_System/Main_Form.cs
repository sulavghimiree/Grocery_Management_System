using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Top_2_Click(object sender, EventArgs e)
        {

        }

        private void Top_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Org_name_1_Click(object sender, EventArgs e)
        {

        }

        private void gms_Click(object sender, EventArgs e)
        {

        }

        private void File_Click(object sender, EventArgs e)
        {
            openChildForm(new productform());
        }

        private void middel_panel_Paint(object sender, PaintEventArgs e)
        {

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
            middle_panel.Controls.Add(childForm);
            middle_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            openChildForm(new User_Form());
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void btncategories_Click(object sender, EventArgs e)
        {
            openChildForm(new categoryform());
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            openChildForm(new orderform());
        }
    }
}
