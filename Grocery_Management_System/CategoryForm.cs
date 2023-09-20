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
    public partial class CategoryForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            int i = 0;
            dgvCategories.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM dbCategory", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategories.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModuleForm formmodule = new CategoryModuleForm();
            formmodule.btnSave.Enabled = true;
            formmodule.btnupdate.Enabled = false;
            formmodule.ShowDialog();
            LoadCategory();
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategories.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModuleForm category_Module = new CategoryModuleForm();
                category_Module.lblcatid.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                category_Module.txtcatname.Text = dgvCategories.Rows[e.RowIndex].Cells[2].Value.ToString();

                category_Module.btnSave.Enabled = false;
                category_Module.btnupdate.Enabled = true;
                category_Module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM dbCategory WHERE catid LIKE '" + dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Category has been deleted successfully");
            }
            LoadCategory();
        }
    }
}
