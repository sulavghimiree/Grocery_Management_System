using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Management_System
{
    public partial class CategoryModuleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void CategoryModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO dbCategory(catname) VALUES (@catname)", conn);
                cmd.Parameters.AddWithValue("@catname", txtcatname.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Category has been saved successfully.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtcatname.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE dbCategory SET catname=@catname WHERE catid LIKE '" + lblcatid.Text + "'", conn);
                cmd.Parameters.AddWithValue("@catname", txtcatname.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Category has been updated successfully.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
