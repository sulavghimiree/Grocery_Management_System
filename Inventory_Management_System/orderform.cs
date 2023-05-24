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
    public partial class orderform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public orderform()
        {
            InitializeComponent();
            LoadOrder();
        }

        public void LoadOrder()
        {
            double total = 0;
            int i = 0;
            dgv_order.Rows.Clear();
            cm = new SqlCommand("SELECT orderid, odate, O.pid, P.pname, O.cid, C.cname, qty, price, total FROM tbOrder AS O JOIN tbCustomer AS C ON O.cid=C.cid JOIN tbProduct AS P ON O.pid=P.pid WHERE CONCAT (orderid, odate, O.pid, P.pname, O.cid, C.cname, qty, price) LIKE '%"+searchbox.Text+"%'", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_order.Rows.Add(i, dr[0].ToString(),Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                total += Convert.ToInt32(dr[8].ToString());
            }
            dr.Close();
            conn.Close();

            lblqty.Text = i.ToString();
            lbltotal.Text = total.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ordermoduleform moduleForm = new ordermoduleform();
            moduleForm.ShowDialog();
            LoadOrder();
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_order.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("DELETE FROM tbOrder WHERE orderid LIKE '" + dgv_order.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted!");

                    cm = new SqlCommand("UPDATE tbProduct SET pqty=(pqty+@pqty) WHERE pid LIKE '" + dgv_order.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", conn);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(dgv_order.Rows[e.RowIndex].Cells[7].Value.ToString()));

                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            LoadOrder();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
