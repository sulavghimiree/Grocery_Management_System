using System;
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
    public partial class CustomerButton : PictureBox
    {
        public CustomerButton()
        {
            InitializeComponent();
        }

        private void CustomerButton_Load(object sender, EventArgs e)
        {

        }

        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }

        public Image ImageHover
        {
            get { return HoverImage; }
            set { HoverImage = value; }
        }

        private void CustomerButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
