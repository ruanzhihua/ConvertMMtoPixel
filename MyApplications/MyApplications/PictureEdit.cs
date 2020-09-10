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
using System.Drawing.Drawing2D;

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
        public Bitmap currentOriginMap;
        /// <summary>
        /// 旋转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.currentOriginMap = (Bitmap)new Bitmap(imageCroppingBox1.Image).Clone();
        }
        /// <summary>
        /// 镜像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.currentOriginMap = (Bitmap)new Bitmap(imageCroppingBox1.Image).Clone();
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
                    this.imageCroppingBox1._IsLockSelected = false;
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
            this.imageCroppingBox1._IsLockSelected = true;
            this.Crop();
            this.imageCroppingBox1.Size = this.imageCroppingBox1.Image.Size;
            this.currentOriginMap = (Bitmap)new Bitmap(imageCroppingBox1.Image).Clone();
        }

        private void PictureEdit_Load(object sender, EventArgs e)
        {
            this.imageCroppingBox1._IsLockSelected = true;
            this.imageCroppingBox1.Location = new Point((this.Size.Width - image.Size.Width) / 2, (this.Size.Height - image.Size.Height) / 2);
            //默认五号字
            this.comboBoxFontSize.Items.AddRange(new object[] { 5f, 5.5f,6.5f,7.5f,9f,10.5f,12f,14f,15f,16f,18f,22f,24f,26f,36f,42f });
            this.comboBoxFontSize.SelectedIndex = 5;
            this.textBoxPictureText.ForeColor = this.buttonPictureTextColor.ForeColor;
            
        }
        /// <summary>
        /// 图片缩放实现函数
        /// 双线性内插值法
        /// </summary>
        /// <param name="newWidth"></param>
        /// <param name="newHeight"></param>
        public void ResizePicture(int newWidth,int newHeight)
        {
            if(newWidth<=0||newHeight<=0)
            {                
                return;
            }

            Bitmap temp = (Bitmap)currentOriginMap.Clone();
            Bitmap bmap = new Bitmap(newWidth, newHeight, temp.PixelFormat);
            //双线性内插值法
            double nWidthFactor = (double)temp.Width / (double)newWidth;
            double nHeightFactor= (double)temp.Height / (double)newHeight;

            double fx, fy, nx, ny;
            int cx, cy, fr_x, fr_y;
            Color color1 = new Color();
            Color color2 = new Color();
            Color color3 = new Color();
            Color color4 = new Color();

            byte nR, nG, nB;
            byte bp1, bp2;

            for(int x=0;x<bmap.Width;++x)
            {
                for(int y=0;y<bmap.Height;++y)
                {
                    fr_x = (int)Math.Floor(x * nWidthFactor);
                    fr_y = (int)Math.Floor(y * nHeightFactor);
                    cx = fr_x + 1;
                    cy = fr_y + 1;
                    if (cx >= temp.Width) cx = fr_x;
                    if (cy >= temp.Height) cy = fr_y;

                    //坐标差值
                    fx = x * nWidthFactor - fr_x;
                    fy = y * nHeightFactor - fr_y;
                    nx = 1.0 - fx;
                    ny = 1.0 - fy;

                    color1 = temp.GetPixel(fr_x, fr_y);
                    color2 = temp.GetPixel(cx, fr_y);
                    color3 = temp.GetPixel(fr_x, cy);
                    color4 = temp.GetPixel(cx, cy);

                    //red
                    bp1 = (byte)(nx*color1.R+fx*color2.R);
                    bp2 = (byte)(nx * color3.R + fx * color4.R);
                    nR = (byte)(ny * (double)bp1 + fy * (double)bp2);

                    //green
                    bp1 = (byte)(nx * color1.G + fx * color2.G);
                    bp2 = (byte)(nx * color3.G + fx * color4.G);
                    nG = (byte)(ny * (double)bp1 + fy * (double)bp2);

                    //blue
                    bp1 = (byte)(nx * color1.B + fx * color2.B);
                    bp2 = (byte)(nx * color3.B + fx * color4.B);
                    nB = (byte)(ny * (double)bp1 + fy * (double)bp2);

                    bmap.SetPixel(x, y, System.Drawing.Color.FromArgb(255, nR, nG, nB));
                }
            }
            this.imageCroppingBox1.Image = bmap;
            this.imageCroppingBox1.Size = this.imageCroppingBox1.Image.Size;
            this.currentOriginMap = (Bitmap)new Bitmap(imageCroppingBox1.Image).Clone();

        }
        /// <summary>
        /// 缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            PicutreZoomParameter picutreZoomParameter = new PicutreZoomParameter();
            picutreZoomParameter.FormClosing += (s, ea) =>
            {
                if (picutreZoomParameter.pictureZoomSize.pictureWidth >= 0 && picutreZoomParameter.pictureZoomSize.pictureWidth >= 0)
                {
                    this.ResizePicture(picutreZoomParameter.pictureZoomSize.pictureWidth, picutreZoomParameter.pictureZoomSize.pictureHeight);
                }
            };
           
            picutreZoomParameter.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(this.barButtonItem6.Border == DevExpress.XtraEditors.Controls.BorderStyles.Simple)
            {
                this.barButtonItem6.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.panelBottom.Visible = false;
            }
            else
            {
                this.barButtonItem6.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                this.panelBottom.Visible = true;
            }
            this.comboBoxFontSize.Location = new Point(this.panelBottom.Size.Width / 2 - this.comboBoxFontSize.Width, this.comboBoxFontSize.Location.Y);
            this.buttonPictureTextColor.Location = new Point(this.comboBoxFontSize.Location.X + this.comboBoxFontSize.Width + 5, this.comboBoxFontSize.Location.Y);

        }       

        private void imageCroppingBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxPictureText.Visible = panelBottom.Visible;
            this.buttonConfirmPictureTextContenr.Visible = panelBottom.Visible;
            Font font = new Font("宋体", float.Parse(this.comboBoxFontSize.SelectedItem.ToString()), FontStyle.Regular);
            
            this.textBoxPictureText.Font = font;
            this.textBoxPictureText.Location = new Point(e.X + imageCroppingBox1.Location.X, e.Y + imageCroppingBox1.Location.Y);
            this.buttonConfirmPictureTextContenr.Location = new Point(this.textBoxPictureText.Location.X + this.textBoxPictureText.Width + 5, this.textBoxPictureText.Location.Y);
            
        }

        private void buttonPictureTextColor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= this.colorDialog1.ShowDialog();
            if(dialogResult==DialogResult.OK)
            {
                this.buttonPictureTextColor.ForeColor = this.colorDialog1.Color;
                this.textBoxPictureText.ForeColor = this.colorDialog1.Color;

            }
        }
        /// <summary>
        /// 为图像添加文字
        /// </summary>
        /// <param name="text"></param>
        /// <param name="pointLocation"></param>
        /// <param name="textFont"></param>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        public void InsertTextToImage(string text,Point pointLocation,Font textFont,string color1,string color2)
        {
            Bitmap temp = currentBitmap;
            Bitmap bitmap = (Bitmap)temp.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            if(string.IsNullOrEmpty(color1))
            {
                color1 = "Black";
            }
            if(string.IsNullOrEmpty(color2))
            {
                color2 = color1;
            }
            Color color3 = Color.FromName(color1);
            Color color4 = Color.FromName(color2);

            int gw = (int)(text.Length * textFont.Size);
            gw = gw == 0 ? 10 : gw;
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(0, 0, gw, (int)textFont.Size), color3, color4, LinearGradientMode.Vertical);
            graphics.DrawString(text, textFont, linearGradientBrush, pointLocation);
            this.imageCroppingBox1.Image = bitmap;
            currentOriginMap = (Bitmap)bitmap.Clone();
            ///修复添加文字后锁定选择失效
            this.imageCroppingBox1._IsLockSelected = true;
        }
        private void buttonConfirmPictureTextContenr_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBoxPictureText.Text.Trim()))
            {
                MessageBox.Show("未输入文字", "提示");
                return;
            }
            else
            {
                Point point = new Point(this.textBoxPictureText.Location.X - this.imageCroppingBox1.Location.X, this.textBoxPictureText.Location.Y - this.imageCroppingBox1.Location.Y);
                this.InsertTextToImage(this.textBoxPictureText.Text, point, this.textBoxPictureText.Font,this.textBoxPictureText.ForeColor.Name,"");
            }
            this.barButtonItem6.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            panelBottom.Visible=false;
            this.textBoxPictureText.Visible = panelBottom.Visible;
            this.buttonConfirmPictureTextContenr.Visible = panelBottom.Visible;
        }
    }
}