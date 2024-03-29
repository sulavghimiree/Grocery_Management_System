﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Management_System
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
        }
        int startPos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 3;
            myprogress.Value = startPos;
            percent.Text = startPos + " %";
            if(myprogress.Value == 99)
            {
                myprogress.Value = 0;
                timer1.Stop(); 
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
