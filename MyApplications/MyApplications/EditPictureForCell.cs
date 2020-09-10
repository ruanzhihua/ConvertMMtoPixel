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
                fileDialog.Filter = "图像(*.jpg;*.JPG)|*.jpg;*.JPG;*.png;*.dwg";
                if(fileDialog.ShowDialog()==DialogResult.OK)
                {
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

       
    }
}
