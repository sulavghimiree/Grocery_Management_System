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
    public partial class productmoduleform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public productmoduleform()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        public void LoadProduct()
        {
            categorycombo.Items.Clear();
            cm = new SqlCommand("SELECT catname FROM tbCategory" , conn);
            conn.Open();
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                categorycombo.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pname, pqty, pprice, pdescription, pcategory)VALUES(@pname, @pqty, @pprice, @pdescription, @pcategory)", conn);
                    cm.Parameters.AddWithValue("@pname", pname_box.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(quantity_box.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(price_box.Text));
                    cm.Parameters.AddWithValue("@pdescription", description_box.Text);
                    cm.Parameters.AddWithValue("@pcategory", categorycombo.Text);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been saved successfully.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            pname_box.Clear();
            quantity_box.Clear();
            price_box.Clear();
            description_box.Clear();
            categorycombo.Text = " ";
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Clear();
            savebutton.Enabled = true;
            updatebutton.Enabled = false;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET pname=@pname, pqty=@pqty, pprice=@pprice, pdescription=@pdescription, pcategory=@pcategory WHERE pid LIKE '" + pid_txt.Text + "' ", conn);
                    cm.Parameters.AddWithValue("@pname", pname_box.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(quantity_box.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(price_box.Text));
                    cm.Parameters.AddWithValue("@pdescription", description_box.Text);
                    cm.Parameters.AddWithValue("@pcategory", categorycombo.Text);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been updated successfully!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
