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
    public partial class SellForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public SellForm()
        {
            InitializeComponent();
            LoadSell();
        }

        public void LoadSell()
        {
            int i = 0;
            dgvSoldItems.Rows.Clear();
            cmd = new SqlCommand("SELECT orderid, odate, O.pid, P.pname, O.cname, qty, price, total FROM dbSold AS O JOIN dbProduct AS P ON O.pid = P.pid WHERE CONCAT(orderid, odate, O.pid, P.pname, O.cname, qty, price) LIKE '%"+txtsrchsold.Text+"%'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSoldItems.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SellmoduleForm sellmodule = new SellmoduleForm();
            sellmodule.ShowDialog();
            LoadSell();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSoldItems.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM dbSold WHERE orderid LIKE '" + dgvSoldItems.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sold Items has been deleted successfully");

                cmd = new SqlCommand("UPDATE dbProduct SET pqty = (pqty+@pqty) WHERE pid LIKE '" + dgvSoldItems.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", conn);
                cmd.Parameters.AddWithValue("@pqty", Convert.ToInt16(dgvSoldItems.Rows[e.RowIndex].Cells[6].Value.ToString()));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadSell();
        }

        private void txtsrchsold_TextChanged(object sender, EventArgs e)
        {
            LoadSell();
        }
    }
}
