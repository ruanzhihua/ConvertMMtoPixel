using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace MyApplications
{
    public partial class PictureEdit : DevExpress.XtraEditors.XtraForm
    {
        public PictureEdit()
        {
            InitializeComponent();
        }
        public Image image
        {
            get
            {
                return imageCroppingBox1.Image;
            }set
            {
                this.imageCroppingBox1.Image = value;
                this.imageCroppingBox1.Size = image.Size;
               
            }
        }
        private Bitmap currentBitmap
        {
            get
            {
                return (Bitmap)new Bitmap(this.imageCroppingBox1.Image).Clone();
            }
        }
        Bitmap currentOriginMap;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(this.imageCroppingBox1.Image==null)
            {
                return;
            }
            Bitmap bitmap = currentBitmap;
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.imageCroppingBox1.Image = bitmap;
            this.imageCroppingBox1.Size = this.imageCroppingBox1.Image.Size;
            this.btnSelectArea.Location = new Point(this.imageCroppingBox1.Location.X + this.imageCroppingBox1.Width - btnSelectArea.Width, this.imageCroppingBox1.Location.Y + this.imageCroppingBox1.Height + 3);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.imageCroppingBox1.Image == null)
            {
                return;
            }            
            Bitmap bitmap= currentBitmap;
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.imageCroppingBox1.Image = bitmap;
            this.imageCroppingBox1.Size = this.imageCroppingBox1.Size;
            this.btnSelectArea.Location = new Point(this.imageCroppingBox1.Location.X+this.imageCroppingBox1.Width - btnSelectArea.Width, this.imageCroppingBox1.Location.Y+this.imageCroppingBox1.Height + 3);
        }
        /// <summary>
        /// 完成，窗口关闭，返回修改图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 绘制裁剪区域
        /// </summary>
        /// <param name="positonX"></param>
        /// <param name="positionY"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void DrawOutCropArea(int positonX,int positionY,int width,int height)
        {
            Bitmap bitmap;
            if (currentOriginMap == null)
            {
                bitmap = (Bitmap)currentBitmap.Clone();
                currentOriginMap= (Bitmap)currentBitmap.Clone();
            }
            else
            {
                bitmap = (Bitmap)currentOriginMap.Clone();
            }
             Graphics graphics = Graphics.FromImage(bitmap);
            Brush brush = new Pen(Color.FromArgb(150,Color.White)).Brush;
            Rectangle rectangle1 = new Rectangle(0, 0, bitmap.Width, positionY);//上蒙板
            Rectangle rectangle2 = new Rectangle(0, positionY, positonX, height);//左蒙板
            //右蒙板
            Rectangle rectangle3 = new Rectangle(0, positionY+height, bitmap.Width, bitmap.Height-positionY-height);
            Rectangle rectangle4 = new Rectangle(positonX+width, positionY, bitmap.Width-positonX-width, height);
            graphics.FillRectangle(brush, rectangle1);
            graphics.FillRectangle(brush, rectangle2);
            graphics.FillRectangle(brush, rectangle3);
            graphics.FillRectangle(brush, rectangle4);
            this.imageCroppingBox1.Image = bitmap;
            
        }
        private void Crop()
        {
            if(this.imageCroppingBox1.SelectedRectangle.IsEmpty)
            {
                MessageBox.Show("未选择区域或者区域范围过小","提示");
                return;
            }
            
            this.imageCroppingBox1.Image = currentBitmap.Clone(this.imageCroppingBox1.SelectedRectangle, currentBitmap.PixelFormat);
        }
            
        /// <summary>
        /// 裁剪
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            mouseSelectAreaFlag = true;            
            switch (this.barButtonItem4.Caption)
            {
                case "裁剪":
                    this.barButtonItem4.Caption = "选择裁剪区域";
                    break;
                
            }
            this.btnSelectArea.Location = new Point(this.imageCroppingBox1.Location.X + this.imageCroppingBox1.Width - btnSelectArea.Width, this.imageCroppingBox1.Location.Y + this.imageCroppingBox1.Height + 3);
            this.btnSelectArea.Visible = true;
            


        }
        #region
        bool mouseSelectAreaFlag = false;
       
       
        
        private void imageCroppingBox1_MouseDown(object sender, MouseEventArgs e)
        {            
          
        }

        private void imageCroppingBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseSelectAreaFlag = false;
            
            
            this.btnSelectArea.Location= new Point(MousePosition.X-btnSelectArea.Width, MousePosition.Y+3);
            this.btnSelectArea.Visible = true;
        }

        private void imageCroppingBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void imageCroppingBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseSelectAreaFlag == true)
            {
                
            }
        }
        #endregion

        private void btnSelectArea_Click(object sender, EventArgs e)
        {
            this.btnSelectArea.Visible = false;
            this.barButtonItem4.Caption = "裁剪";
            this.Crop();
            this.imageCroppingBox1.Size = this.imageCroppingBox1.Image.Size;
        }

        private void PictureEdit_Load(object sender, EventArgs e)
        {
            this.imageCroppingBox1.Location = new Point((this.Size.Width - image.Size.Width) / 2, (this.Size.Height - image.Size.Height) / 2);
        }

       
    }
}