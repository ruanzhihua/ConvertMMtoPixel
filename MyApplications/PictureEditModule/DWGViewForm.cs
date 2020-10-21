using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PictureEditModule
{
    public partial class DWGViewForm : DevExpress.XtraEditors.XtraForm
    {
        public DWGViewForm()
        {
            InitializeComponent();
        }
        public void PutSourcePath(string filePath)
        {
            this.axAcCtrl1.PutSourcePath(filePath);
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.axAcCtrl1.Plot();
        }
    }
}