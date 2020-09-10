using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplications
{
    public partial class PicutreZoomParameter : Form
    {
        public PicutreZoomParameter()
        {
            InitializeComponent();
        }
        public PictureZoomSize pictureZoomSize = new PictureZoomSize();
        public struct PictureZoomSize
        {
            public int pictureWidth;
            public int pictureHeight;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pictureZoomSize.pictureWidth = int.Parse(this.textBoxWidth.Text.Trim());
                this.pictureZoomSize.pictureHeight = int.Parse(this.textBoxHeight.Text.Trim());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("非法字符", "提示");
            }
            this.Close();

        }
    }
}
