namespace Inventory_Management_System
{
    partial class customermoduleform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customermoduleform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.customermodule = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.cphone_box = new System.Windows.Forms.TextBox();
            this.cname_box = new System.Windows.Forms.TextBox();
            this.customerphone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.cid_txt = new System.Windows.Forms.Label();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 62);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // close_button
            // 
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(608, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(19, 20);
            this.close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_button.TabIndex = 10;
            this.close_button.TabStop = false;
            // 
            // customermodule
            // 
            this.customermodule.AutoSize = true;
            this.customermodule.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customermodule.ForeColor = System.Drawing.Color.White;
            this.customermodule.Location = new System.Drawing.Point(12, 19);
            this.customermodule.Name = "customermodule";
            this.customermodule.Size = new System.Drawing.Size(188, 27);
            this.customermodule.TabIndex = 0;
            this.customermodule.Text = "Customer Module";
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updatebutton.FlatAppearance.BorderSize = 0;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.White;
            this.updatebutton.Location = new System.Drawing.Point(382, 183);
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
            this.clearbutton.Location = new System.Drawing.Point(484, 183);
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
            this.savebutton.Location = new System.Drawing.Point(278, 183);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(98, 40);
            this.savebutton.TabIndex = 23;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cphone_box
            // 
            this.cphone_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cphone_box.Location = new System.Drawing.Point(190, 128);
            this.cphone_box.Name = "cphone_box";
            this.cphone_box.Size = new System.Drawing.Size(398, 24);
            this.cphone_box.TabIndex = 22;
            // 
            // cname_box
            // 
            this.cname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname_box.Location = new System.Drawing.Point(190, 88);
            this.cname_box.Name = "cname_box";
            this.cname_box.Size = new System.Drawing.Size(398, 24);
            this.cname_box.TabIndex = 19;
            // 
            // customerphone
            // 
            this.customerphone.AutoSize = true;
            this.customerphone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerphone.Location = new System.Drawing.Point(36, 128);
            this.customerphone.Name = "customerphone";
            this.customerphone.Size = new System.Drawing.Size(64, 20);
            this.customerphone.TabIndex = 16;
            this.customerphone.Text = "Phone :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(36, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 20);
            this.name.TabIndex = 15;
            this.name.Text = "Name :";
            // 
            // cid_txt
            // 
            this.cid_txt.AutoSize = true;
            this.cid_txt.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_txt.Location = new System.Drawing.Point(25, 195);
            this.cid_txt.Name = "cid_txt";
            this.cid_txt.Size = new System.Drawing.Size(100, 18);
            this.cid_txt.TabIndex = 26;
            this.cid_txt.Text = "Customer ID";
            // 
            // customermoduleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 253);
            this.Controls.Add(this.cid_txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.cphone_box);
            this.Controls.Add(this.cname_box);
            this.Controls.Add(this.customerphone);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customermoduleform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customermoduleform";
            this.Load += new System.EventHandler(this.customermoduleform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.Label customermodule;
        public System.Windows.Forms.Button updatebutton;
        public System.Windows.Forms.Button clearbutton;
        public System.Windows.Forms.Button savebutton;
        public System.Windows.Forms.TextBox cphone_box;
        public System.Windows.Forms.TextBox cname_box;
        private System.Windows.Forms.Label customerphone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label cid_txt;
    }
}