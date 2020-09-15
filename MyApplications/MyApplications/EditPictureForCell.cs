using MyControls.ContainerControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplications
{
    public partial class EditPictureForCell : UserBaseControl
    {
        public EditPictureForCell()
        {
            InitializeComponent();
        }
        
        private void axCell1_DropCellSelected(object sender, AxCELL50Lib._DCell2000Events_DropCellSelectedEvent e)
        {
           
        }

        private void btnEditPicture_Click(object sender, EventArgs e)
        {
            if(this.OriginPicture.Image==null)
            {
                System.Windows.Forms.FileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();
                fileDialog.Filter = "图像(*.jpg;*.JPG)|*.jpg;*.JPG|图像（*.png）|*.png|图像（*.dwg)|*.dwg";
                if(fileDialog.ShowDialog()==DialogResult.OK)
                {
                    string[] fileNameArray = fileDialog.FileName.Split('.');
                    foreach(string str in fileNameArray)
                    {
                        if(str.ToUpper()=="DWG")
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
                            catch(Exception ex)
                            {
                                MessageBox.Show("未安装DWG TrueView或者其他错误！","错误");
                            }
                        }
                    }
                    this.OriginPicture.Image = Image.FromFile(fileDialog.FileName);
                }
                else
                {
                    return;
                }
            }
            PictureEdit pictureEdit = new PictureEdit();
            pictureEdit.image = (Image)new Bitmap(this.OriginPicture.Image).Clone();
            pictureEdit.currentOriginMap= (Bitmap)new Bitmap(this.OriginPicture.Image).Clone();
            pictureEdit.WindowState = FormWindowState.Maximized;
            pictureEdit.FormClosing += (object sender1, FormClosingEventArgs e1) =>
                {
                    this.ResultPicture.Image = (Image)new Bitmap(pictureEdit.image).Clone();
                };
                ;
            pictureEdit.ShowDialog();
            
               
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FileDialog fileDialog = new System.Windows.Forms.SaveFileDialog();
            fileDialog.Filter = "图像(*.jpg;)|*.jpg|图像（*.png）|*.png|图像（*.dwg)|*.dwg";
            fileDialog.DefaultExt = "jpg" ;
            fileDialog.AddExtension = true;
            if(fileDialog.ShowDialog()==DialogResult.OK)
            {
                this.ResultPicture.Image.Save(fileDialog.FileName,System.Drawing.Imaging.ImageFormat.Jpeg);
                int imageIndex=this.axCell1.AddImage(fileDialog.FileName);
                this.axCell1.SetCellImage(this.axCell1.GetCurrentCol(), this.axCell1.GetCurrentRow(), this.axCell1.GetCurSheet(), imageIndex, 1, 0, 0);
            }


        }

        private void axCell1_MouseLClick(object sender, AxCELL50Lib._DCell2000Events_MouseLClickEvent e)
        {
            Point pointCellSelectedLocation = new Point(0, 0);
            int cellLeft = 0;
            int cellTop = 0;
            int cellRight = 0;
            int cellBottom = 0;
            int cellStartCol = 0;
            int cellEndCol = 0;
            int cellStartRow = 0;
            int cellEndRow = 0;
            int cellSpanWidth = 0;
            int cellSpanHeight = 0;
            ///获取当前单元格的绘图区域
            //this.axCell1.GetCellRect(this.axCell1.GetCurrentCol(), this.axCell1.GetCurrentRow(), ref cellLeft, ref cellTop, ref cellRight, ref cellBottom, true, false);
           
            ///获取当前单元格的扩展范围
            this.axCell1.GetMergeRange2(this.axCell1.GetCurrentCol(), this.axCell1.GetCurrentRow(), ref cellStartCol, ref cellStartRow, ref cellEndCol,ref cellEndRow, this.axCell1.GetCurSheet());
           
            for(int i=cellStartCol; i<=cellEndCol; ++i)
            {
                cellSpanWidth += this.axCell1.GetColWidth(1,i, this.axCell1.GetCurSheet());
            }
            for (int i = cellStartRow; i <= cellEndRow; ++i)
            {
                cellSpanHeight += this.axCell1.GetRowHeight(1, i, this.axCell1.GetCurSheet());
            }
            this.labelCellSelectedSize.Text = labelCellSelectedSize.Tag.ToString() + cellSpanWidth + "," + cellSpanHeight;
        }

      
    }
}
