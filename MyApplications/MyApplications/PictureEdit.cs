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
                return this.pictureEdit1.Image;
            }
            set
            {
                this.pictureEdit1.Image = value;
            }
        }
    }
}