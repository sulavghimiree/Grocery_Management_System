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

namespace Inventory_Management_System
{
    public partial class User_Form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public User_Form()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgv_user.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_user.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            conn.Close();
        }
        

        private void manage_users_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.savebutton.Enabled = true;
            userModule.updatebutton.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_user.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.username_box.Text = dgv_user.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.fullname_box.Text = dgv_user.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.password_box.Text = dgv_user.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.phone_box.Text = dgv_user.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModule.savebutton.Enabled=false;
                userModule.updatebutton.Enabled=true;
                userModule.username_box.Enabled=false;
                userModule.ShowDialog();
            }
            else if(colName =="Delete")
            {
                if(MessageBox.Show("Are you sure want to delete this user?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbUser WHERE username LIKE '" + dgv_user.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadUser();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
