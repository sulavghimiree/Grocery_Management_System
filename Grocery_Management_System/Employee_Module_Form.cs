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

namespace Grocery_Management_System
{
    public partial class Employee_Module_Form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public Employee_Module_Form()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtpswd.Text != repswd.Text)
                {
                    MessageBox.Show("Password did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmd = new SqlCommand("INSERT INTO dbEmployee(username,fullname,password,phone) VALUES (@username,@fullname,@password,@phone)", conn);
                cmd.Parameters.AddWithValue("@username", txtuname.Text);
                cmd.Parameters.AddWithValue("@fullname", txtfname.Text);
                cmd.Parameters.AddWithValue("@password", txtpswd.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee has been saved successfully.");
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnupdate.Enabled = false;
        }

        public void Clear()
        {
            txtuname.Clear();
            txtfname.Clear();
            txtpswd.Clear();
            txtphone.Clear();
            repswd.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpswd.Text != repswd.Text)
                {
                    MessageBox.Show("Password did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmd = new SqlCommand("UPDATE dbEmployee SET fullname = @fullname, password = @password, phone = @phone WHERE username LIKE '"+txtuname.Text+"'", conn);
                cmd.Parameters.AddWithValue("@fullname", txtfname.Text);
                cmd.Parameters.AddWithValue("@password", txtpswd.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee has been updated successfully.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
