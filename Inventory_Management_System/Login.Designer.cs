namespace Inventory_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Top_2 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.picturebox_white = new System.Windows.Forms.PictureBox();
            this.Show_password = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_white)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Top_2);
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Controls.Add(this.Top);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 102);
            this.panel1.TabIndex = 0;
            // 
            // Top_2
            // 
            this.Top_2.AutoSize = true;
            this.Top_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_2.ForeColor = System.Drawing.Color.White;
            this.Top_2.Location = new System.Drawing.Point(103, 57);
            this.Top_2.Name = "Top_2";
            this.Top_2.Size = new System.Drawing.Size(106, 25);
            this.Top_2.TabIndex = 10;
            this.Top_2.Text = "SYSTEM";
            // 
            // close_button
            // 
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(309, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(19, 20);
            this.close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_button.TabIndex = 9;
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Top
            // 
            this.Top.AutoSize = true;
            this.Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top.ForeColor = System.Drawing.Color.White;
            this.Top.Location = new System.Drawing.Point(11, 31);
            this.Top.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(306, 26);
            this.Top.TabIndex = 7;
            this.Top.Text = "GROCERY MANAGEMENT\r\n";
            this.Top.Click += new System.EventHandler(this.Top_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(34, 286);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(93, 20);
            this.username.TabIndex = 1;
            this.username.Text = "User Name:";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_text
            // 
            this.username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_text.Location = new System.Drawing.Point(38, 309);
            this.username_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(246, 28);
            this.username_text.TabIndex = 2;
            this.username_text.TextChanged += new System.EventHandler(this.username_text_TextChanged);
            // 
            // text_Password
            // 
            this.text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Password.Location = new System.Drawing.Point(38, 373);
            this.text_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(246, 28);
            this.text_Password.TabIndex = 4;
            this.text_Password.UseSystemPasswordChar = true;
            this.text_Password.TextChanged += new System.EventHandler(this.text_Password_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(34, 351);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Location = new System.Drawing.Point(59, 448);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(208, 41);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // picturebox_white
            // 
            this.picturebox_white.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_white.Image")));
            this.picturebox_white.Location = new System.Drawing.Point(115, 126);
            this.picturebox_white.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturebox_white.Name = "picturebox_white";
            this.picturebox_white.Size = new System.Drawing.Size(88, 89);
            this.picturebox_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_white.TabIndex = 6;
            this.picturebox_white.TabStop = false;
            this.picturebox_white.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Show_password
            // 
            this.Show_password.AutoSize = true;
            this.Show_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_password.Location = new System.Drawing.Point(38, 405);
            this.Show_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Show_password.Name = "Show_password";
            this.Show_password.Size = new System.Drawing.Size(136, 22);
            this.Show_password.TabIndex = 7;
            this.Show_password.Text = "Show Password";
            this.Show_password.UseVisualStyleBackColor = true;
            this.Show_password.CheckedChanged += new System.EventHandler(this.Show_password_CheckedChanged);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clear.Location = new System.Drawing.Point(131, 506);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(73, 27);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(84, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please Login First";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Show_password);
            this.Controls.Add(this.picturebox_white);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_white)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.PictureBox picturebox_white;
        private System.Windows.Forms.CheckBox Show_password;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.Label Top_2;
        private System.Windows.Forms.Label Top;
        private System.Windows.Forms.Label label1;
    }
}

