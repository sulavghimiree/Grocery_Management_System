namespace Grocery_Management_System
{
    partial class Employee_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Main_Form));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSellItems = new Grocery_Management_System.CustomerButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSellItems)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.Location = new System.Drawing.Point(0, 100);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(860, 391);
            this.MainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSellItems);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 100);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(380, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sell Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(248, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "GROCERY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 29);
            this.panel2.TabIndex = 4;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(55)))));
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(769, 0);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(82, 29);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSellItems
            // 
            this.btnSellItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSellItems.Image = ((System.Drawing.Image)(resources.GetObject("btnSellItems.Image")));
            this.btnSellItems.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnSellItems.ImageHover")));
            this.btnSellItems.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnSellItems.ImageNormal")));
            this.btnSellItems.Location = new System.Drawing.Point(392, 33);
            this.btnSellItems.Name = "btnSellItems";
            this.btnSellItems.Size = new System.Drawing.Size(47, 43);
            this.btnSellItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSellItems.TabIndex = 13;
            this.btnSellItems.TabStop = false;
            this.btnSellItems.Click += new System.EventHandler(this.btnSellItems_Click);
            // 
            // Employee_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 520);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Employee_Main_Form";
            this.Text = "Employee_Main_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSellItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private CustomerButton btnSellItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}