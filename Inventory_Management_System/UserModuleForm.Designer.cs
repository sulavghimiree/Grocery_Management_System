namespace Inventory_Management_System
{
    partial class UserModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.Usermodule = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.fullname_box = new System.Windows.Forms.TextBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.retypepassword_box = new System.Windows.Forms.TextBox();
            this.retypepassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(627, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Usermodule
            // 
            this.Usermodule.AutoSize = true;
            this.Usermodule.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usermodule.ForeColor = System.Drawing.Color.White;
            this.Usermodule.Location = new System.Drawing.Point(12, 19);
            this.Usermodule.Name = "Usermodule";
            this.Usermodule.Size = new System.Drawing.Size(137, 27);
            this.Usermodule.TabIndex = 0;
            this.Usermodule.Text = "User Module";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(36, 107);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(97, 20);
            this.Username.TabIndex = 1;
            this.Username.Text = "User Name :";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(36, 274);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(64, 20);
            this.phone.TabIndex = 2;
            this.phone.Text = "Phone :";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(36, 189);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(87, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Password :";
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(36, 148);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(87, 20);
            this.fullname.TabIndex = 4;
            this.fullname.Text = "Full Name :";
            // 
            // username_box
            // 
            this.username_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.Location = new System.Drawing.Point(190, 107);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(398, 24);
            this.username_box.TabIndex = 5;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(190, 189);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(398, 24);
            this.password_box.TabIndex = 6;
            this.password_box.UseSystemPasswordChar = true;
            // 
            // fullname_box
            // 
            this.fullname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_box.Location = new System.Drawing.Point(190, 146);
            this.fullname_box.Name = "fullname_box";
            this.fullname_box.Size = new System.Drawing.Size(398, 24);
            this.fullname_box.TabIndex = 7;
            // 
            // phone_box
            // 
            this.phone_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_box.Location = new System.Drawing.Point(190, 274);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(398, 24);
            this.phone_box.TabIndex = 8;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(301, 333);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(98, 40);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Red;
            this.clearbutton.FlatAppearance.BorderSize = 0;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.White;
            this.clearbutton.Location = new System.Drawing.Point(507, 333);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(104, 40);
            this.clearbutton.TabIndex = 10;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clear_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updatebutton.FlatAppearance.BorderSize = 0;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.White;
            this.updatebutton.Location = new System.Drawing.Point(405, 333);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(96, 40);
            this.updatebutton.TabIndex = 11;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // retypepassword_box
            // 
            this.retypepassword_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypepassword_box.Location = new System.Drawing.Point(190, 233);
            this.retypepassword_box.Name = "retypepassword_box";
            this.retypepassword_box.Size = new System.Drawing.Size(398, 24);
            this.retypepassword_box.TabIndex = 13;
            this.retypepassword_box.UseSystemPasswordChar = true;
            this.retypepassword_box.TextChanged += new System.EventHandler(this.retypepassword_box_TextChanged);
            // 
            // retypepassword
            // 
            this.retypepassword.AutoSize = true;
            this.retypepassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypepassword.Location = new System.Drawing.Point(36, 235);
            this.retypepassword.Name = "retypepassword";
            this.retypepassword.Size = new System.Drawing.Size(143, 20);
            this.retypepassword.TabIndex = 12;
            this.retypepassword.Text = "Retype Password :";
            // 
            // UserModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 385);
            this.Controls.Add(this.retypepassword_box);
            this.Controls.Add(this.retypepassword);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.fullname_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModuleForm";
            this.Text = "UserModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Label Usermodule;
        private System.Windows.Forms.PictureBox close_button;
        public System.Windows.Forms.Button savebutton;
        public System.Windows.Forms.Button clearbutton;
        public System.Windows.Forms.Button updatebutton;
        public System.Windows.Forms.TextBox username_box;
        public System.Windows.Forms.TextBox password_box;
        public System.Windows.Forms.TextBox fullname_box;
        public System.Windows.Forms.TextBox phone_box;
        public System.Windows.Forms.TextBox retypepassword_box;
        private System.Windows.Forms.Label retypepassword;
    }
}