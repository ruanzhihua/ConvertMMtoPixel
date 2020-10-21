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
using System.Runtime.CompilerServices;

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
            }
            set
            {
                this.imageCroppingBox1.Image = value;
                this.imageCroppingBox1.Size = image.Size;
                this.barStaticItemPictureSize.Caption = string.Format("长：{0} 宽：{1}", image.Size.Width, image.Size.Height);
                zoomTrackBarControl1_ValueChanged(null, null);
            }
        }
        private Bitmap currentBitmap
        {
            get
            {
                return (Bitmap)new Bitmap(image).Clone();
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
            image = bitmap;            
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
            image = bitmap;           
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
            image = bitmap;
            
        }
        private void Crop()
        {
            if(this.imageCroppingBox1.SelectedRectangle.IsEmpty)
            {
                MessageBox.Show("未选择区域或者区域范围过小","提示");
                return;
            }
            
            image = currentBitmap.Clone(this.imageCroppingBox1.SelectedRectangle, currentBitmap.PixelFormat);
        }
            
        /// <summary>
        /// 裁剪
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            mouseSelectAreaFlag = true;
            if (mouseSelectAreaFlag == true) mouseSelectAreaFlag = false;
            switch (this.barButtonItem4.Caption)
            {
                case "裁剪":
                    this.barButtonItem4.Caption = "选择裁剪区域";
                    this.btnSelectArea.Visible = true;
                    this.imageCroppingBox1._IsLockSelected = false;
                    break;
                case "选择裁剪区域":
                    this.barButtonItem4.Caption = "裁剪";
                    this.btnSelectArea.Visible = false;
                    this.imageCroppingBox1._IsLockSelected = true; ;
                    break;

            }
            this.btnSelectArea.Location = new Point(this.imageCroppingBox1.Location.X + this.imageCroppingBox1.Width - btnSelectArea.Width, this.imageCroppingBox1.Location.Y + this.imageCroppingBox1.Height + 3);
            
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
            this.currentOriginMap = (Bitmap)new Bitmap(imageCroppingBox1.Image).Clone();
        }

        private void PictureEdit_Load(object sender, EventArgs e)
        {
            this.imageCroppingBox1._IsLockSelected = true;
            //Point imageLocation = new Point((this.panelLeft.Size.Width - image.Size.Width) / 2, (this.panelLeft.Size.Height - image.Size.Height) / 2);
            //this.imageCroppingBox1.Location = new Point(imageLocation.X < 0 ? 0: imageLocation.X, imageLocation.Y<0?0: imageLocation.Y);
            //默认五号字
            this.comboBoxFontSize.Items.AddRange(new object[] { 5f, 5.5f,6.5f,7.5f,9f,10.5f,12f,14f,15f,16f,18f,22f,24f,26f,36f,42f });
            this.comboBoxFontSize.SelectedIndex = 5;
            this.fontEdit1.Text = "宋体";            
            this.imageCroppingBox1_MouseClick(null, new MouseEventArgs(MouseButtons.Right, 1, 5, 5, 0));
            //初始化工具栏
            changePictureTextStyle();
            zoomTrackBarControl1_ValueChanged(null, null);
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
            image = bmap;           
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
                this.barButtonItem6.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.buttonConfirmPictureTextContenr.Visible= this.textBoxPictureText.Visible = false;
                

            }
            else
            {
                this.barButtonItem6.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                this.buttonConfirmPictureTextContenr.Visible = this.textBoxPictureText.Visible = true;


            }
            
            

        }       

        private void imageCroppingBox1_MouseClick(object sender, MouseEventArgs e)
        {           
           
            this.textBoxPictureText.Location = new Point(e.X + imageCroppingBox1.Location.X, e.Y + imageCroppingBox1.Location.Y);
            this.buttonConfirmPictureTextContenr.Location = new Point(this.textBoxPictureText.Location.X + this.textBoxPictureText.Width + 5, this.textBoxPictureText.Location.Y);            
        }
        private void changePictureTextStyle()
        {            
            Font font = new Font(this.fontEdit1.Text, float.Parse(this.comboBoxFontSize.SelectedItem.ToString()), FontStyle.Regular);
            this.textBoxPictureText.Font =this.buttonPictureTextColor.Font= font;
            this.buttonPictureTextColor.ForeColor = this.textBoxPictureText.ForeColor = this.colorEdit1.Color;;
        }

        private void buttonPictureTextColor_Click(object sender, EventArgs e)
        {
            this.barButtonItem6_ItemClick(null, null);           
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
            image = bitmap;
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
            this.barButtonItem6_ItemClick(null, null);
           
           
        }

        private void imageCroppingBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            switch (this.barButtonItem4.Caption)
            {
                
                case "选择裁剪区域":
                    this.btnSelectArea.Location = new Point(e.X+imageCroppingBox1.Location.X - btnSelectArea.Width,e.Y+imageCroppingBox1.Location.Y  + 3);
                    break;

            }
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fontEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorEdit1_TextChanged(object sender, EventArgs e)
        {
            this.changePictureTextStyle();
        }

        private void fontEdit1_TextChanged(object sender, EventArgs e)
        {
            this.changePictureTextStyle();
        }

        private void comboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changePictureTextStyle();
        }

        private void fontEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            System.Windows.Forms.FileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();
            fileDialog.Filter = "图像(*.jpg;*.JPG)|*.jpg;*.JPG|图像（*.png）|*.png|图像（*.dwg)|*.dwg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNameArray = fileDialog.FileName.Split('.');
                foreach (string str in fileNameArray)
                {
                    if (str.ToUpper() == "DWG")
                    {
                        try
                        {
                            splashScreenManager1.ShowWaitForm();
                            splashScreenManager1.SetWaitFormCaption("正在加载内容，请稍后...");

                            Application.DoEvents();
                            DWGViewForm dWGViewForm = new DWGViewForm();
                            dWGViewForm.WindowState = FormWindowState.Maximized;
                            dWGViewForm.PutSourcePath(fileDialog.FileName);
                            splashScreenManager1.CloseWaitForm();
                            dWGViewForm.ShowDialog();
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("未安装DWG TrueView或者其他错误！", "错误");
                        }
                    }
                }
                this.image = Image.FromFile(fileDialog.FileName);
                currentOriginMap = (Bitmap)new Bitmap(this.image).Clone();
            }
            else
            {
                return;
            }
        }

        private void zoomTrackBarControl1_ValueChanged(object sender, EventArgs e)
        {
            if(zoomTrackBarControl1.Value!=0)
            {
                
            }
            else
            {
                zoomTrackBarControl1.Value = 1;
                MessageBox.Show("无法缩放到0%", "提示");
            }
            this.zoomValue.Text = zoomTrackBarControl1.Value.ToString()+"%";
            if(image!=null)
            {
                textZoomWidth.Text = Math.Ceiling(this.image.Width * zoomTrackBarControl1.Value * 0.01).ToString();
                textZoomHeight.Text= Math.Ceiling(this.image.Height * zoomTrackBarControl1.Value * 0.01).ToString();
            }
            else
            {
                textZoomWidth.Text = "0";
                textZoomHeight.Text = "0";
            }
            
        }
        /// <summary>
        /// 执行比例缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmZoom_Click(object sender, EventArgs e)
        {
            Size pictureZoomSize = new Size();
            try
            {
                pictureZoomSize.Width = int.Parse(textZoomWidth.Text);
                pictureZoomSize.Height = int.Parse(textZoomHeight.Text);
            }
            catch
            {
                MessageBox.Show("缩放尺寸不合法！");
            }
            
            if (zoomValue.Text!="100%"&& pictureZoomSize.Width >= 0 && pictureZoomSize.Height >= 0)
            {
                this.ResizePicture(pictureZoomSize.Width, pictureZoomSize.Height);
            }     

            
        }

        private void buttonImageRotate_Click(object sender, EventArgs e)
        {
            barButtonItem1_ItemClick(null, null);
        }

        private void buttonImageMirror_Click(object sender, EventArgs e)
        {
            barButtonItem2_ItemClick(null, null);
        }

        private void buttonImageCrop_Click(object sender, EventArgs e)
        {
            barButtonItem4_ItemClick(null, null);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}