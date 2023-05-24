using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class productform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public productform()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dvg_product.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid, pname, pprice, pdescription, pcategory) LIKE '%"+searchtxt.Text+"%'", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvg_product.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            productmoduleform formModule = new productmoduleform();
            formModule.savebutton.Enabled = true;
            formModule.updatebutton.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();
        }

        private void dvg_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dvg_product.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                productmoduleform productModule = new productmoduleform();
                productModule.pid_txt.Text = dvg_product.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.pname_box.Text = dvg_product.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.quantity_box.Text = dvg_product.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.price_box.Text = dvg_product.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.description_box.Text = dvg_product.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.categorycombo.Text = dvg_product.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.savebutton.Enabled = false;
                productModule.updatebutton.Enabled = true;
                productModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pid LIKE '" + dvg_product.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadProduct();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
