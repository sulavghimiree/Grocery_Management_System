namespace Grocery_Management_System
{
    partial class ProductModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combocat = new System.Windows.Forms.ComboBox();
            this.lblpid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(635, 73);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(611, 0);
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
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Module";
            // 
            // txtdesc
            // 
            this.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(161, 233);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(391, 26);
            this.txtdesc.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Description :";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(430, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 38);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(327, 342);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(97, 38);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(224, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 38);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(161, 140);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(391, 26);
            this.txtqty.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Category :";
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(161, 186);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(391, 26);
            this.txtprice.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Price :";
            // 
            // txtpname
            // 
            this.txtpname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(161, 93);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(391, 26);
            this.txtpname.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product Name :";
            // 
            // combocat
            // 
            this.combocat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocat.FormattingEnabled = true;
            this.combocat.Location = new System.Drawing.Point(161, 276);
            this.combocat.Name = "combocat";
            this.combocat.Size = new System.Drawing.Size(391, 29);
            this.combocat.TabIndex = 30;
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(24, 355);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(76, 17);
            this.lblpid.TabIndex = 31;
            this.lblpid.Text = "product id";
            this.lblpid.Visible = false;
            // 
            // ProductModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 397);
            this.Controls.Add(this.lblpid);
            this.Controls.Add(this.combocat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox combocat;
        public System.Windows.Forms.Label lblpid;
    }
}