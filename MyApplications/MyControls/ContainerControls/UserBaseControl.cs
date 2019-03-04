using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControls.ContainerControls
{
    public partial class UserBaseControl : UserControl
    {
        public UserBaseControl()
        {
            InitializeComponent();
        }

        
        
        private void Exit_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Parent.Dispose();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).WindowState = FormWindowState.Minimized;
        }
        public void ShowAsForm()
        {
            Form form = new Form();
            //不显示容器窗体窗体栏
            form.FormBorderStyle = FormBorderStyle.None;
            //窗体相对于父容器位置
            form.Location = new Point(Screen.PrimaryScreen.Bounds.Width/2-this.Width/2,Screen.PrimaryScreen.Bounds.Height/2-this.Height/2);
            //窗体的位置由Location属性决定
            form.StartPosition = FormStartPosition.Manual;//默认FormStartPosition.WindowsDefaultBounds; //窗体定位在windows默认位置，边界也由windows默认决定
            form.Width = this.Width;
            form.Height = this.Height;
            form.Controls.Add(this);
            form.ShowDialog();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (((Form)this.Parent).WindowState == FormWindowState.Maximized)
            {
                ((Form)this.Parent).WindowState = FormWindowState.Normal;
                this.Width = 814;
                this.Height = 487;
                this.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                ((Form)this.Parent).WindowState = FormWindowState.Maximized;
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height;
                this.BorderStyle = BorderStyle.None;
            }
        }
    }
}
