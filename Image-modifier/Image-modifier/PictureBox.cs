using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_modifier
{
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void Image1_CheckedChanged(object sender, EventArgs e)
        {
            ImageContainer.Image = Properties.Resources.python;
        }

        private void Image2_CheckedChanged(object sender, EventArgs e)
        {
            ImageContainer.Image = Properties.Resources.JS;
        }

        private void ImageNone_CheckedChanged(object sender, EventArgs e)
        {
            ImageContainer.Image = null;
        }

        private void Border1_CheckedChanged(object sender, EventArgs e)
        {
            ImageContainer.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Border2_CheckedChanged(object sender, EventArgs e)
        {
            ImageContainer.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BorderNone_CheckedChanged(object sender, EventArgs e)
        {
            ImageContainer.BorderStyle = BorderStyle.None;
        }

        private void Visible_CheckedChanged(object sender, EventArgs e)
        {
            if(Visible.Checked)
            {
                ImageContainer.Visible = true;
            }

            else
            {
                ImageContainer.Visible = false;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
