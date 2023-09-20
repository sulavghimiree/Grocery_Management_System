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
    public partial class Employee_Form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulav\OneDrive\Documents\GroceryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Employee_Form()
        {
            InitializeComponent();
            LoadEmployee();
        }

        public void LoadEmployee()
        {
            int i = 0;
            dgvEmployees.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM dbEmployee", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvEmployees.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee_Module_Form employeeModule = new Employee_Module_Form();
            employeeModule.btnSave.Enabled = true;
            employeeModule.btnupdate.Enabled = false;
            employeeModule.ShowDialog();
            LoadEmployee();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployees.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                Employee_Module_Form employee_Module = new Employee_Module_Form();
                employee_Module.txtuname.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                employee_Module.txtfname.Text = dgvEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
                employee_Module.txtpswd.Text = dgvEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
                employee_Module.txtphone.Text = dgvEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();

                employee_Module.btnSave.Enabled = false;
                employee_Module.btnupdate.Enabled=true;
                employee_Module.txtuname.Enabled = false;
                employee_Module.ShowDialog();
            }
            else if(colName == "Delete")
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM dbEmployee WHERE username LIKE '" + dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString()+"'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee has been deleted successfully");
            }
            LoadEmployee();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
