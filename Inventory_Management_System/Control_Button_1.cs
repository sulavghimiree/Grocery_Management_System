using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Control_Button_1 : PictureBox
    {
        public Control_Button_1()
        {
            InitializeComponent();
        }

        private void Control_Button_1_Load(object sender, EventArgs e)
        {

        }

        private Image NormalImage;
        private Image HoverImage;
        public Image ImageNormal
        {
            get { return NormalImage; } 
            set {  NormalImage = value; }
        }
        public Image ImageHover 
        { 
            get { return HoverImage; } 
            set { HoverImage = value; } 
        }

        private void Control_Button_1_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void Control_Button_1_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
