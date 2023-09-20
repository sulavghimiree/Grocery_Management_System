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
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void chkpswdshow_CheckedChanged(object sender, EventArgs e)
        {
            if(chkpswdshow.Checked == false)
            {
                txtpswd.UseSystemPasswordChar = true;
            }
            else
            {
                txtpswd.UseSystemPasswordChar = false;
            }
        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            txtuname.Clear();
            txtpswd.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM dbEmployee WHERE username = @username AND password = @password", conn);
                cmd.Parameters.AddWithValue("@username", txtuname.Text);
                cmd.Parameters.AddWithValue("@password", txtpswd.Text);
                conn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    MessageBox.Show("Welcome " + dr["fullname"].ToString() + " ! ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Employee_Main_Form main = new Employee_Main_Form();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbladmin_Click(object sender, EventArgs e)
        {
            Admin_Login adlog = new Admin_Login();
            adlog.ShowDialog();
            this.Hide();
        }
    }
}
