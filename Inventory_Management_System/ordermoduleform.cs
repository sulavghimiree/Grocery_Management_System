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
    public partial class ordermoduleform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        public ordermoduleform()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCustomer()
        {
            int i = 0;
            dgv_customers.Rows.Clear();
            cm = new SqlCommand("SELECT cid, cname FROM tbCustomer WHERE CONCAT(cid, cname) LIKE '%"+searchcust.Text+"%'", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_customers.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            conn.Close();
        }

        public void LoadProduct()
        {
            int i = 0;
            dvg_product.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid, pname, pprice, pdescription, pcategory) LIKE '%" + searchprod.Text + "%'", conn);
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

        private void searchcust_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void searchprod_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void qty_box_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if(Convert.ToInt16(qty_box.Value)>qty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                qty_box.Value = qty_box.Value - 1;
                return;
            }
            if (Convert.ToInt16(qty_box.Value) > 0)
            {
                int total = Convert.ToInt16(price_box.Text) * Convert.ToInt16(qty_box.Value);
                total_box.Text = total.ToString();
            }
        }

        private void dgv_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cid_box.Text = dgv_customers.Rows[e.RowIndex].Cells[1].Value.ToString();
            cname_box.Text = dgv_customers.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dvg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pid_box.Text = dvg_product.Rows[e.RowIndex].Cells[1].Value.ToString();
            pname_box.Text = dvg_product.Rows[e.RowIndex].Cells[2].Value.ToString();
            price_box.Text = dvg_product.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cid_box.Text == "")
                {
                    MessageBox.Show("Please select customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (pid_box.Text == "")
                {
                    MessageBox.Show("Please select product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to insert this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbOrder(odate, pid, cid, qty, price, total)VALUES(@odate, @pid, @cid, @qty, @price, @total)", conn);
                    cm.Parameters.AddWithValue("@odate", odate_box.Value);
                    cm.Parameters.AddWithValue("@pid", Convert.ToInt16(pid_box.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt16(cid_box.Text));
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(qty_box.Value));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(price_box.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt16(total_box.Text));
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Order has been inserted successfully.");
                    

                    cm = new SqlCommand("UPDATE tbProduct SET pqty=(pqty-@pqty) WHERE pid LIKE '" + pid_box.Text + "' ", conn);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(qty_box.Text));
                    
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    Clear();
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            cid_box.Clear();
            cname_box.Clear();

            pid_box.Clear();
            pname_box.Clear();
            price_box.Clear();

            total_box.Clear();
            odate_box.Value = DateTime.Now;
            qty_box.Value = 0;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void GetQty()
        {
            cm = new SqlCommand("SELECT pqty FROM tbProduct WHERE pid = '" + pid_box.Text + "'", conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }
    }
}
