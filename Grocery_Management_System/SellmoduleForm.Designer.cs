namespace Grocery_Management_System
{
    partial class SellmoduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellmoduleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.dtvalue = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.billprint = new System.Windows.Forms.Button();
            this.ttltxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvbilltable = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbloid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qtyupdown = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pickdate = new System.Windows.Forms.DateTimePicker();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsrchproduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilltable)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 50);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(873, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sell Items Module";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.dtvalue);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.billprint);
            this.panel3.Controls.Add(this.ttltxt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dgvbilltable);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 617);
            this.panel3.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(-15, 562);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(344, 17);
            this.label21.TabIndex = 44;
            this.label21.Text = "---------------------------------------------------------------------------------" +
    "---";
            // 
            // dtvalue
            // 
            this.dtvalue.AutoSize = true;
            this.dtvalue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtvalue.Location = new System.Drawing.Point(90, 186);
            this.dtvalue.Name = "dtvalue";
            this.dtvalue.Size = new System.Drawing.Size(0, 19);
            this.dtvalue.TabIndex = 43;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(26, 186);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 19);
            this.label22.TabIndex = 42;
            this.label22.Text = "Date :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(163, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 19);
            this.label19.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(26, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 19);
            this.label18.TabIndex = 40;
            this.label18.Text = "Name of Customer :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(141, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Bill";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(82, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 19);
            this.label16.TabIndex = 38;
            this.label16.Text = "MART GROCERY SHOP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(58, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 31);
            this.label17.TabIndex = 37;
            this.label17.Text = "E";
            // 
            // billprint
            // 
            this.billprint.BackColor = System.Drawing.Color.Blue;
            this.billprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billprint.FlatAppearance.BorderSize = 0;
            this.billprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billprint.ForeColor = System.Drawing.Color.White;
            this.billprint.Location = new System.Drawing.Point(88, 582);
            this.billprint.Name = "billprint";
            this.billprint.Size = new System.Drawing.Size(147, 32);
            this.billprint.TabIndex = 36;
            this.billprint.Text = "Print Bill";
            this.billprint.UseVisualStyleBackColor = false;
            this.billprint.Click += new System.EventHandler(this.billprint_Click);
            // 
            // ttltxt
            // 
            this.ttltxt.AutoSize = true;
            this.ttltxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttltxt.Location = new System.Drawing.Point(281, 473);
            this.ttltxt.Name = "ttltxt";
            this.ttltxt.Size = new System.Drawing.Size(0, 19);
            this.ttltxt.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Grand Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Signature of Seller";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "---------------------";
            // 
            // dgvbilltable
            // 
            this.dgvbilltable.BackgroundColor = System.Drawing.Color.White;
            this.dgvbilltable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbilltable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column10,
            this.Column9,
            this.total});
            this.dgvbilltable.Location = new System.Drawing.Point(0, 214);
            this.dgvbilltable.Name = "dgvbilltable";
            this.dgvbilltable.RowHeadersVisible = false;
            this.dgvbilltable.Size = new System.Drawing.Size(326, 292);
            this.dgvbilltable.TabIndex = 6;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Product Name";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Price";
            this.Column10.Name = "Column10";
            this.Column10.Width = 64;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Qty";
            this.Column9.Name = "Column9";
            this.Column9.Width = 55;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Width = 64;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.txtcname);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 95);
            this.panel4.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(-3, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(344, 17);
            this.label20.TabIndex = 5;
            this.label20.Text = "---------------------------------------------------------------------------------" +
    "---";
            // 
            // txtcname
            // 
            this.txtcname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(15, 57);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(251, 22);
            this.txtcname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUSTOMER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customer Name :";
            // 
            // lbloid
            // 
            this.lbloid.AutoSize = true;
            this.lbloid.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloid.Location = new System.Drawing.Point(3, 595);
            this.lbloid.Name = "lbloid";
            this.lbloid.Size = new System.Drawing.Size(50, 15);
            this.lbloid.TabIndex = 5;
            this.lbloid.Text = "OrderID";
            this.lbloid.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.qtyupdown);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pickdate);
            this.panel2.Controls.Add(this.txtpname);
            this.panel2.Controls.Add(this.lbloid);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txttotal);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtpid);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtsrchproduct);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(332, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 617);
            this.panel2.TabIndex = 4;
            // 
            // qtyupdown
            // 
            this.qtyupdown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyupdown.Location = new System.Drawing.Point(416, 438);
            this.qtyupdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtyupdown.Name = "qtyupdown";
            this.qtyupdown.Size = new System.Drawing.Size(134, 26);
            this.qtyupdown.TabIndex = 38;
            this.qtyupdown.ValueChanged += new System.EventHandler(this.qtyupdown_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(403, 570);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 38);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(249, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 38);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 499);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 19);
            this.label15.TabIndex = 34;
            this.label15.Text = "Order Date :";
            // 
            // pickdate
            // 
            this.pickdate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickdate.CustomFormat = "dd/MM/yyyy";
            this.pickdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickdate.Location = new System.Drawing.Point(20, 523);
            this.pickdate.Name = "pickdate";
            this.pickdate.Size = new System.Drawing.Size(237, 27);
            this.pickdate.TabIndex = 33;
            // 
            // txtpname
            // 
            this.txtpname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpname.Enabled = false;
            this.txtpname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(20, 457);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(237, 26);
            this.txtpname.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 19);
            this.label14.TabIndex = 31;
            this.label14.Text = "Product Name :";
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(416, 484);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(134, 26);
            this.txttotal.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 487);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 19);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(343, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Quantity :";
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Enabled = false;
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(416, 397);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(134, 26);
            this.txtprice.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(343, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Price :";
            // 
            // txtpid
            // 
            this.txtpid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpid.Enabled = false;
            this.txtpid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid.Location = new System.Drawing.Point(20, 392);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(237, 26);
            this.txtpid.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Product ID:";
            // 
            // txtsrchproduct
            // 
            this.txtsrchproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsrchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsrchproduct.Location = new System.Drawing.Point(226, 305);
            this.txtsrchproduct.Name = "txtsrchproduct";
            this.txtsrchproduct.Size = new System.Drawing.Size(260, 22);
            this.txtsrchproduct.TabIndex = 22;
            this.txtsrchproduct.TextChanged += new System.EventHandler(this.txtsrchproduct_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(101, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Search Product :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "PRODUCT";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(565, 285);
            this.dgvProducts.TabIndex = 6;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "S.N.";
            this.Column7.Name = "Column7";
            this.Column7.Width = 57;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ProductID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            this.Column3.Width = 55;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 64;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Category";
            this.Column6.Name = "Column6";
            this.Column6.Width = 94;
            // 
            // SellmoduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 667);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellmoduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellmoduleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilltable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtsrchproduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lbloid;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtcname;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.TextBox txtpid;
        public System.Windows.Forms.TextBox txtpname;
        public System.Windows.Forms.DateTimePicker pickdate;
        public System.Windows.Forms.NumericUpDown qtyupdown;
        private System.Windows.Forms.DataGridView dgvbilltable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ttltxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        public System.Windows.Forms.Button billprint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label dtvalue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
    }
}