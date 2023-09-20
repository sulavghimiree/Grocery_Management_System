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
    public partial class ProductForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProducts.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM dbProduct WHERE CONCAT(pid, pname, pprice, pdescription, pcategory) LIKE '%"+txtsrchproduct.Text+"%' ", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProducts.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModuleForm formmodule = new ProductModuleForm();
            formmodule.btnSave.Enabled = true;
            formmodule.btnupdate.Enabled = false;
            formmodule.ShowDialog();
            LoadProduct();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProducts.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModuleForm product_module = new ProductModuleForm();
                product_module.lblpid.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                product_module.txtpname.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                product_module.txtqty.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                product_module.txtprice.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                product_module.txtdesc.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
                product_module.combocat.Text = dgvProducts.Rows[e.RowIndex].Cells[6].Value.ToString();

                product_module.btnSave.Enabled = false;
                product_module.btnupdate.Enabled = true;
                product_module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM dbProduct WHERE pid LIKE '" + dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product has been deleted successfully");
            }
            LoadProduct();
        }

        private void txtsrchproduct_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
