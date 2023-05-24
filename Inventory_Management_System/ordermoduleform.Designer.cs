namespace Inventory_Management_System
{
    partial class ordermoduleform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordermoduleform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.Usermodule = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cname_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cid_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchcust = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.Label();
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.qty_box = new System.Windows.Forms.NumericUpDown();
            this.clearbutton = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.odate_box = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.pname_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.total_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pid_box = new System.Windows.Forms.TextBox();
            this.searchprod = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.Label();
            this.dvg_product = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Controls.Add(this.Usermodule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 62);
            this.panel1.TabIndex = 1;
            // 
            // close_button
            // 
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(893, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(19, 20);
            this.close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_button.TabIndex = 10;
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Usermodule
            // 
            this.Usermodule.AutoSize = true;
            this.Usermodule.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usermodule.ForeColor = System.Drawing.Color.White;
            this.Usermodule.Location = new System.Drawing.Point(12, 19);
            this.Usermodule.Name = "Usermodule";
            this.Usermodule.Size = new System.Drawing.Size(150, 27);
            this.Usermodule.TabIndex = 0;
            this.Usermodule.Text = "Order Module";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.orderid);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cname_box);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cid_box);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchcust);
            this.panel2.Controls.Add(this.customer);
            this.panel2.Controls.Add(this.dgv_customers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 545);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Customer Name :";
            // 
            // cname_box
            // 
            this.cname_box.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname_box.Location = new System.Drawing.Point(31, 424);
            this.cname_box.Margin = new System.Windows.Forms.Padding(2);
            this.cname_box.Name = "cname_box";
            this.cname_box.Size = new System.Drawing.Size(251, 24);
            this.cname_box.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer ID :";
            // 
            // cid_box
            // 
            this.cid_box.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_box.Location = new System.Drawing.Point(31, 361);
            this.cid_box.Margin = new System.Windows.Forms.Padding(2);
            this.cid_box.Name = "cid_box";
            this.cid_box.Size = new System.Drawing.Size(251, 24);
            this.cid_box.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search-Box :";
            // 
            // searchcust
            // 
            this.searchcust.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchcust.Location = new System.Drawing.Point(138, 261);
            this.searchcust.Margin = new System.Windows.Forms.Padding(2);
            this.searchcust.Name = "searchcust";
            this.searchcust.Size = new System.Drawing.Size(156, 24);
            this.searchcust.TabIndex = 8;
            this.searchcust.TextChanged += new System.EventHandler(this.searchcust_TextChanged);
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Teal;
            this.customer.Location = new System.Drawing.Point(2, 304);
            this.customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(113, 21);
            this.customer.TabIndex = 7;
            this.customer.Text = "CUSTOMER";
            // 
            // dgv_customers
            // 
            this.dgv_customers.AllowUserToAddRows = false;
            this.dgv_customers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customers.ColumnHeadersHeight = 30;
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_customers.EnableHeadersVisualStyles = false;
            this.dgv_customers.Location = new System.Drawing.Point(0, 0);
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.RowHeadersVisible = false;
            this.dgv_customers.RowHeadersWidth = 51;
            this.dgv_customers.Size = new System.Drawing.Size(298, 246);
            this.dgv_customers.TabIndex = 6;
            this.dgv_customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customers_CellClick);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "S.N";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 55;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Customer ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 111;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.qty_box);
            this.panel3.Controls.Add(this.clearbutton);
            this.panel3.Controls.Add(this.insertbutton);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.odate_box);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pname_box);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.total_box);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.price_box);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pid_box);
            this.panel3.Controls.Add(this.searchprod);
            this.panel3.Controls.Add(this.product);
            this.panel3.Controls.Add(this.dvg_product);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(310, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 545);
            this.panel3.TabIndex = 3;
            // 
            // qty_box
            // 
            this.qty_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_box.Location = new System.Drawing.Point(435, 404);
            this.qty_box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qty_box.Name = "qty_box";
            this.qty_box.Size = new System.Drawing.Size(156, 24);
            this.qty_box.TabIndex = 26;
            this.qty_box.ValueChanged += new System.EventHandler(this.qty_box_ValueChanged);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Red;
            this.clearbutton.FlatAppearance.BorderSize = 0;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.White;
            this.clearbutton.Location = new System.Drawing.Point(454, 493);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(136, 40);
            this.clearbutton.TabIndex = 25;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.insertbutton.FlatAppearance.BorderSize = 0;
            this.insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton.ForeColor = System.Drawing.Color.White;
            this.insertbutton.Location = new System.Drawing.Point(320, 493);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(128, 40);
            this.insertbutton.TabIndex = 24;
            this.insertbutton.Text = "Order Insert";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 463);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Order Date :";
            // 
            // odate_box
            // 
            this.odate_box.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odate_box.CustomFormat = "dd/MM/yyyy";
            this.odate_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.odate_box.Location = new System.Drawing.Point(16, 484);
            this.odate_box.Name = "odate_box";
            this.odate_box.Size = new System.Drawing.Size(200, 20);
            this.odate_box.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 404);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Product Name :";
            // 
            // pname_box
            // 
            this.pname_box.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname_box.Location = new System.Drawing.Point(16, 424);
            this.pname_box.Margin = new System.Windows.Forms.Padding(2);
            this.pname_box.Name = "pname_box";
            this.pname_box.Size = new System.Drawing.Size(251, 24);
            this.pname_box.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 440);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total :";
            // 
            // total_box
            // 
            this.total_box.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_box.Location = new System.Drawing.Point(435, 440);
            this.total_box.Margin = new System.Windows.Forms.Padding(2);
            this.total_box.Name = "total_box";
            this.total_box.Size = new System.Drawing.Size(156, 24);
            this.total_box.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Qty :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Product ID :";
            // 
            // price_box
            // 
            this.price_box.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_box.Location = new System.Drawing.Point(435, 360);
            this.price_box.Margin = new System.Windows.Forms.Padding(2);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(156, 24);
            this.price_box.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search-Box :";
            // 
            // pid_box
            // 
            this.pid_box.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid_box.Location = new System.Drawing.Point(16, 361);
            this.pid_box.Margin = new System.Windows.Forms.Padding(2);
            this.pid_box.Name = "pid_box";
            this.pid_box.Size = new System.Drawing.Size(251, 24);
            this.pid_box.TabIndex = 14;
            // 
            // searchprod
            // 
            this.searchprod.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchprod.Location = new System.Drawing.Point(250, 260);
            this.searchprod.Margin = new System.Windows.Forms.Padding(2);
            this.searchprod.Name = "searchprod";
            this.searchprod.Size = new System.Drawing.Size(318, 24);
            this.searchprod.TabIndex = 9;
            this.searchprod.TextChanged += new System.EventHandler(this.searchprod_TextChanged);
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.ForeColor = System.Drawing.Color.Teal;
            this.product.Location = new System.Drawing.Point(2, 304);
            this.product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(99, 21);
            this.product.TabIndex = 8;
            this.product.Text = "PRODUCT";
            // 
            // dvg_product
            // 
            this.dvg_product.AllowUserToAddRows = false;
            this.dvg_product.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_product.ColumnHeadersHeight = 30;
            this.dvg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvg_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_product.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvg_product.EnableHeadersVisualStyles = false;
            this.dvg_product.Location = new System.Drawing.Point(0, 0);
            this.dvg_product.Name = "dvg_product";
            this.dvg_product.RowHeadersVisible = false;
            this.dvg_product.RowHeadersWidth = 51;
            this.dvg_product.Size = new System.Drawing.Size(602, 246);
            this.dvg_product.TabIndex = 8;
            this.dvg_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_product_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "S.N";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 52;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 65;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Description";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Category";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 88;
            // 
            // orderid
            // 
            this.orderid.AutoSize = true;
            this.orderid.Location = new System.Drawing.Point(28, 509);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(47, 13);
            this.orderid.TabIndex = 14;
            this.orderid.Text = "Order ID";
            this.orderid.Visible = false;
            // 
            // ordermoduleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 607);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ordermoduleform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ordermoduleform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.Label Usermodule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dvg_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchcust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchprod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cname_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cid_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pname_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.TextBox pid_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker odate_box;
        public System.Windows.Forms.Button clearbutton;
        public System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.NumericUpDown qty_box;
        private System.Windows.Forms.Label orderid;
    }
}