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
    public partial class ProductModuleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            combocat.Items.Clear();
            cmd = new SqlCommand("SELECT catname FROM dbCategory", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                combocat.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO dbProduct(pname, pqty, pprice, pdescription, pcategory) VALUES (@pname, @pqty, @pprice, @pdescription, @pcategory)", conn);
                cmd.Parameters.AddWithValue("@pname", txtpname.Text);
                cmd.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtqty.Text));
                cmd.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtprice.Text));
                cmd.Parameters.AddWithValue("@pdescription", txtdesc.Text);
                cmd.Parameters.AddWithValue("@pcategory", combocat.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product has been saved successfully.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtpname.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtdesc.Clear();
            combocat.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE dbProduct SET pname = @pname, pqty = @pqty, pprice = @pprice, pdescription = @pdescription, pcategory = @pcategory WHERE pid LIKE '" + lblpid.Text + "'", conn);
                cmd.Parameters.AddWithValue("@pname", txtpname.Text);
                cmd.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtqty.Text));
                cmd.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtprice.Text));
                cmd.Parameters.AddWithValue("@pdescription", txtdesc.Text);
                cmd.Parameters.AddWithValue("@pcategory", combocat.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product has been updated successfully.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
