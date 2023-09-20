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
    public partial class SellmoduleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        public SellmoduleForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProducts.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM dbProduct WHERE CONCAT(pid, pname, pprice, pdescription, pcategory) LIKE '%" + txtsrchproduct.Text + "%' ", conn);
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

        private void txtsrchproduct_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void qtyupdown_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if(Convert.ToInt16(qtyupdown.Value) > qty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                qtyupdown.Value = qtyupdown.Value - 1;
                return;
            }
            if (Convert.ToInt16(qtyupdown.Value) > 0)
            {
                int total = Convert.ToInt16(txtprice.Text) * Convert.ToInt16(qtyupdown.Value);
                txttotal.Text = total.ToString();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpname.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtprice.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpid.Text == "")
                {
                    MessageBox.Show("Please Select Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if(txtcname.Text == "")
                {
                    MessageBox.Show("Please enter Customer name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmd = new SqlCommand("INSERT INTO dbSold(odate, pid, cname, qty, price, total) VALUES (@odate, @pid, @cname, @qty, @price, @total)", conn);
                cmd.Parameters.AddWithValue("@odate", pickdate.Value);
                cmd.Parameters.AddWithValue("@pid", Convert.ToInt16(txtpid.Text));
                cmd.Parameters.AddWithValue("@cname", txtcname.Text);
                cmd.Parameters.AddWithValue("@qty", Convert.ToInt16(qtyupdown.Value));
                cmd.Parameters.AddWithValue("@price", Convert.ToInt16(txtprice.Text));
                cmd.Parameters.AddWithValue("@total", Convert.ToInt16(txttotal.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SoldItem has been saved successfully.");

                cmd = new SqlCommand("UPDATE dbProduct SET pqty = (pqty-@pqty) WHERE pid LIKE '" + txtpid.Text + "'", conn);
                cmd.Parameters.AddWithValue("@pqty", Convert.ToInt16(qtyupdown.Value));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvbilltable.Rows.Add(txtpname.Text, txtprice.Text, qtyupdown.Value, txttotal.Text);
            Clear();

            label19.Text = txtcname.Text;

            double total = 0;
            for(int i=0; i<dgvbilltable.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvbilltable.Rows[i].Cells[3].Value);
            }
            ttltxt.Text = total.ToString();

            dtvalue.Text = Convert.ToString(pickdate.Value);
        }

        public void Clear()
        {
            txtpid.Clear();
            txtpname.Clear();

            txtprice.Clear();
            txttotal.Clear();
            pickdate.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void GetQty()
        {
            cmd = new SqlCommand("SELECT pqty FROM dbProduct WHERE pid = '" + txtpid.Text + "' ", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void billprint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing Bill......");
        }
    }
}
