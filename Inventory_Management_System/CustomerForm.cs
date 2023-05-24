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
    public partial class CustomerForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            int i = 0;
            dgv_customers.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_customers.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void dgv_customers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_customers.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                customermoduleform customerModule = new customermoduleform();
                customerModule.cid_txt.Text = dgv_customers.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.cname_box.Text = dgv_customers.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModule.cphone_box.Text = dgv_customers.Rows[e.RowIndex].Cells[3].Value.ToString();

                customerModule.savebutton.Enabled = false;
                customerModule.updatebutton.Enabled = true;
                customerModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbCustomer WHERE cid LIKE '" + dgv_customers.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadCustomer();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            customermoduleform moduleForm = new customermoduleform();
            moduleForm.savebutton.Enabled = true;
            moduleForm.updatebutton.Enabled = false;
            moduleForm.ShowDialog();
            LoadCustomer();
        }
    }
}
