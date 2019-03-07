using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyControls.ContainerControls
{
    public partial class UserBaseControl : Form
    {
        public UserBaseControl()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lPatam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0x00A1;
        const int HTCAPTION = 2;

        public new FormBorderStyle FormBorderStyle
        {
            get
            {
                return base.FormBorderStyle;
            }
            set
            {
                if(value !=FormBorderStyle.Sizable&&value!=FormBorderStyle.SizableToolWindow)
                {

                }
                base.FormBorderStyle = value;
            }
        }
        #region 隐藏父类属性
        [Browsable(false)]
        public new string Text
        {
            get
            {
                return TittleLabel.Text;
            }
            set { }
        }
        [Browsable(false)]
        public new bool ControlBox
        {
            get
            {
                return false;
            }
            set
            {
                base.ControlBox = false;
            }
        }
        #endregion
        #region 添加属性
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题")]
        public string Tittle
        {
            get
            {
                return this.TittleLabel.Text;
            }
            set
            {
                TittleLabel.Text = value;
            }
        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Description("窗体标题字体样式")]
        public Font TittleFont
        {
            get
            {
                return TittleLabel.Font;
            }
            set
            {
                TittleLabel.Font = value;
            }
        }
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题字体颜色")]
        public Color TitleColor
        {
            get
            {
                return TittleLabel.ForeColor;
            }
            set
            {
                TittleLabel.ForeColor = value;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题栏背景色")]
        public Color TitleBarBackColor
        {
            get
            {
                return panel1.BackColor;
            }
            set
            {
                panel1.BackColor = value;
            }
        }


        #endregion

        private void Exit_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Dispose();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// 不再使用
        /// </summary>
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
            this.Dock = DockStyle.Fill;
            form.ShowDialog();
        }
        
        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Width = 814;
                this.Height = 487;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height;
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();//释放捕获
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);//拖动窗体
            }
        }

        private void UserBaseControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
