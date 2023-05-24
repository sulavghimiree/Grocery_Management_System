namespace Inventory_Management_System
{
    partial class categorymoduleform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categorymoduleform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.customermodule = new System.Windows.Forms.Label();
            this.catid = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.catname_box = new System.Windows.Forms.TextBox();
            this.cat_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Controls.Add(this.customermodule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 76);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(743, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // close_button
            // 
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(811, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 25);
            this.close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_button.TabIndex = 10;
            this.close_button.TabStop = false;
            // 
            // customermodule
            // 
            this.customermodule.AutoSize = true;
            this.customermodule.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customermodule.ForeColor = System.Drawing.Color.White;
            this.customermodule.Location = new System.Drawing.Point(16, 23);
            this.customermodule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customermodule.Name = "customermodule";
            this.customermodule.Size = new System.Drawing.Size(239, 34);
            this.customermodule.TabIndex = 0;
            this.customermodule.Text = "Category Module";
            // 
            // catid
            // 
            this.catid.AutoSize = true;
            this.catid.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catid.Location = new System.Drawing.Point(33, 196);
            this.catid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catid.Name = "catid";
            this.catid.Size = new System.Drawing.Size(119, 23);
            this.catid.TabIndex = 35;
            this.catid.Text = "Category ID";
            this.catid.Click += new System.EventHandler(this.cid_txt_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updatebutton.FlatAppearance.BorderSize = 0;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.White;
            this.updatebutton.Location = new System.Drawing.Point(471, 181);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(128, 49);
            this.updatebutton.TabIndex = 34;
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
            this.clearbutton.Location = new System.Drawing.Point(607, 181);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(139, 49);
            this.clearbutton.TabIndex = 33;
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
            this.savebutton.Location = new System.Drawing.Point(332, 181);
            this.savebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(131, 49);
            this.savebutton.TabIndex = 32;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // catname_box
            // 
            this.catname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catname_box.Location = new System.Drawing.Point(226, 127);
            this.catname_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.catname_box.Name = "catname_box";
            this.catname_box.Size = new System.Drawing.Size(529, 29);
            this.catname_box.TabIndex = 30;
            this.catname_box.TextChanged += new System.EventHandler(this.catname_box_TextChanged);
            // 
            // cat_name
            // 
            this.cat_name.AutoSize = true;
            this.cat_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_name.Location = new System.Drawing.Point(32, 127);
            this.cat_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cat_name.Name = "cat_name";
            this.cat_name.Size = new System.Drawing.Size(170, 22);
            this.cat_name.TabIndex = 28;
            this.cat_name.Text = "Category Name :";
            // 
            // categorymoduleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.catid);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.catname_box);
            this.Controls.Add(this.cat_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "categorymoduleform";
            this.Text = "categorymoduleform";
            this.Load += new System.EventHandler(this.categorymoduleform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.Label customermodule;
        public System.Windows.Forms.Label catid;
        public System.Windows.Forms.Button updatebutton;
        public System.Windows.Forms.Button clearbutton;
        public System.Windows.Forms.Button savebutton;
        public System.Windows.Forms.TextBox catname_box;
        private System.Windows.Forms.Label cat_name;
    }
}