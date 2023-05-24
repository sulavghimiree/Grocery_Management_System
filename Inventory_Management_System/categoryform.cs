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
    public partial class categoryform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public categoryform()
        {
            InitializeComponent();
            LoadCategory();
        }
        public void LoadCategory()
        {
            int i = 0;
            dvg_categories.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategory", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvg_categories.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            categorymoduleform formModule = new categorymoduleform();
            formModule.savebutton.Enabled = true;
            formModule.updatebutton.Enabled = false;
            formModule.ShowDialog();
            LoadCategory();
        }

        private void dvg_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dvg_categories.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                categorymoduleform formModule = new categorymoduleform();
                formModule.catid.Text = dvg_categories.Rows[e.RowIndex].Cells[1].Value.ToString();
                formModule.catname_box.Text = dvg_categories.Rows[e.RowIndex].Cells[2].Value.ToString();

                formModule.savebutton.Enabled = false;
                formModule.updatebutton.Enabled = true;
                formModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE catid LIKE '" + dvg_categories.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadCategory();
        }
    }
}
