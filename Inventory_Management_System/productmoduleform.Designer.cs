namespace Inventory_Management_System
{
    partial class productmoduleform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productmoduleform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.Productmodule = new System.Windows.Forms.Label();
            this.description_box = new System.Windows.Forms.TextBox();
            this.retypepassword = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.quantity_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.pname_box = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.Label();
            this.categorycombo = new System.Windows.Forms.ComboBox();
            this.pid_txt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Controls.Add(this.Productmodule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 62);
            this.panel1.TabIndex = 14;
            // 
            // close_button
            // 
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(603, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(19, 20);
            this.close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_button.TabIndex = 10;
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Productmodule
            // 
            this.Productmodule.AutoSize = true;
            this.Productmodule.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productmodule.ForeColor = System.Drawing.Color.White;
            this.Productmodule.Location = new System.Drawing.Point(12, 19);
            this.Productmodule.Name = "Productmodule";
            this.Productmodule.Size = new System.Drawing.Size(172, 27);
            this.Productmodule.TabIndex = 0;
            this.Productmodule.Text = "Product Module";
            // 
            // description_box
            // 
            this.description_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_box.Location = new System.Drawing.Point(187, 213);
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(398, 24);
            this.description_box.TabIndex = 27;
            // 
            // retypepassword
            // 
            this.retypepassword.AutoSize = true;
            this.retypepassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypepassword.Location = new System.Drawing.Point(33, 215);
            this.retypepassword.Name = "retypepassword";
            this.retypepassword.Size = new System.Drawing.Size(99, 20);
            this.retypepassword.TabIndex = 26;
            this.retypepassword.Text = "Description :";
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updatebutton.FlatAppearance.BorderSize = 0;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.White;
            this.updatebutton.Location = new System.Drawing.Point(376, 296);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(96, 40);
            this.updatebutton.TabIndex = 25;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Red;
            this.clearbutton.FlatAppearance.BorderSize = 0;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.White;
            this.clearbutton.Location = new System.Drawing.Point(478, 296);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(104, 40);
            this.clearbutton.TabIndex = 24;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(272, 296);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(98, 40);
            this.savebutton.TabIndex = 23;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // quantity_box
            // 
            this.quantity_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_box.Location = new System.Drawing.Point(187, 126);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(398, 24);
            this.quantity_box.TabIndex = 21;
            // 
            // price_box
            // 
            this.price_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_box.Location = new System.Drawing.Point(187, 169);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(398, 24);
            this.price_box.TabIndex = 20;
            // 
            // pname_box
            // 
            this.pname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname_box.Location = new System.Drawing.Point(187, 87);
            this.pname_box.Name = "pname_box";
            this.pname_box.Size = new System.Drawing.Size(398, 24);
            this.pname_box.TabIndex = 19;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(33, 128);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(79, 20);
            this.quantity.TabIndex = 18;
            this.quantity.Text = "Quantity :";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(33, 169);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(54, 20);
            this.price.TabIndex = 17;
            this.price.Text = "Price :";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(33, 254);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(87, 20);
            this.category.TabIndex = 16;
            this.category.Text = "Category :";
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(33, 87);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(123, 20);
            this.productname.TabIndex = 15;
            this.productname.Text = "Product Name :";
            // 
            // categorycombo
            // 
            this.categorycombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycombo.FormattingEnabled = true;
            this.categorycombo.Location = new System.Drawing.Point(187, 256);
            this.categorycombo.Name = "categorycombo";
            this.categorycombo.Size = new System.Drawing.Size(398, 26);
            this.categorycombo.TabIndex = 28;
            // 
            // pid_txt
            // 
            this.pid_txt.AutoSize = true;
            this.pid_txt.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid_txt.Location = new System.Drawing.Point(34, 308);
            this.pid_txt.Name = "pid_txt";
            this.pid_txt.Size = new System.Drawing.Size(86, 18);
            this.pid_txt.TabIndex = 29;
            this.pid_txt.Text = "Product ID";
            this.pid_txt.Visible = false;
            // 
            // productmoduleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 353);
            this.Controls.Add(this.pid_txt);
            this.Controls.Add(this.categorycombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.retypepassword);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.quantity_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.pname_box);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.category);
            this.Controls.Add(this.productname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productmoduleform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productmoduleform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.Label Productmodule;
        public System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.Label retypepassword;
        public System.Windows.Forms.Button updatebutton;
        public System.Windows.Forms.Button clearbutton;
        public System.Windows.Forms.Button savebutton;
        public System.Windows.Forms.TextBox quantity_box;
        public System.Windows.Forms.TextBox price_box;
        public System.Windows.Forms.TextBox pname_box;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label productname;
        public System.Windows.Forms.ComboBox categorycombo;
        public System.Windows.Forms.Label pid_txt;
    }
}