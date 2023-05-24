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

namespace Inventory_Management_System
{
    public partial class UserModuleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(password_box.Text != retypepassword_box.Text)
                {
                    MessageBox.Show("Password didn't match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this user?","Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbUser(username, fullname, password, phone)VALUES(@username, @fullname, @password, @phone)", conn);
                    cm.Parameters.AddWithValue("@username", username_box.Text);
                    cm.Parameters.AddWithValue("@fullname", fullname_box.Text);
                    cm.Parameters.AddWithValue("@password", password_box.Text);
                    cm.Parameters.AddWithValue("@phone", phone_box.Text);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User has been saved successfully.");
                    Clear();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
            savebutton.Enabled = true;
            updatebutton.Enabled = false;
        }

        public void Clear()
        {
            username_box.Clear();
            fullname_box.Clear();
            password_box.Clear();
            phone_box.Clear();
            retypepassword_box.Clear();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (password_box.Text != retypepassword_box.Text)
            {
                MessageBox.Show("Password didn't match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                if (MessageBox.Show("Are you sure you want to update this user?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbUser SET username=@username, fullname=@fullname, password=@password, phone=@phone WHERE username LIKE '"+username_box.Text+"' ", conn);
                    cm.Parameters.AddWithValue("@username", username_box.Text);
                    cm.Parameters.AddWithValue("@fullname", fullname_box.Text);
                    cm.Parameters.AddWithValue("@password", password_box.Text);
                    cm.Parameters.AddWithValue("@phone", phone_box.Text);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User has been updated successfully!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void retypepassword_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
