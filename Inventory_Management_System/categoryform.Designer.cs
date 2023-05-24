namespace Inventory_Management_System
{
    partial class categoryform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryform));
            this.dvg_categories = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.manage_users = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addbutton = new Inventory_Management_System.Control_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_categories)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_categories
            // 
            this.dvg_categories.AllowUserToAddRows = false;
            this.dvg_categories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_categories.ColumnHeadersHeight = 30;
            this.dvg_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvg_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_categories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_categories.EnableHeadersVisualStyles = false;
            this.dvg_categories.Location = new System.Drawing.Point(0, 0);
            this.dvg_categories.Name = "dvg_categories";
            this.dvg_categories.RowHeadersWidth = 51;
            this.dvg_categories.Size = new System.Drawing.Size(930, 479);
            this.dvg_categories.TabIndex = 5;
            this.dvg_categories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_categories_CellContentClick);
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
            this.Column1.HeaderText = "Category ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 106;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // manage_users
            // 
            this.manage_users.AutoSize = true;
            this.manage_users.BackColor = System.Drawing.Color.Red;
            this.manage_users.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_users.ForeColor = System.Drawing.Color.White;
            this.manage_users.Location = new System.Drawing.Point(12, 11);
            this.manage_users.Name = "manage_users";
            this.manage_users.Size = new System.Drawing.Size(205, 24);
            this.manage_users.TabIndex = 0;
            this.manage_users.Text = "Manage Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.manage_users);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 44);
            this.panel1.TabIndex = 4;
            // 
            // addbutton
            // 
            this.addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbutton.Image = ((System.Drawing.Image)(resources.GetObject("addbutton.Image")));
            this.addbutton.ImageHover = ((System.Drawing.Image)(resources.GetObject("addbutton.ImageHover")));
            this.addbutton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("addbutton.ImageNormal")));
            this.addbutton.Location = new System.Drawing.Point(880, 6);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(38, 32);
            this.addbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addbutton.TabIndex = 5;
            this.addbutton.TabStop = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // categoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 523);
            this.Controls.Add(this.dvg_categories);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryform";
            this.Text = "categoryform";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_categories)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_categories;
        private System.Windows.Forms.Label manage_users;
        private System.Windows.Forms.Panel panel1;
        private Control_Button_1 addbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}