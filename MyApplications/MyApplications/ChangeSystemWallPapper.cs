using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace MyApplications
{
    public partial class ChangeSystemWallPapper : MyControls.ContainerControls.UserBaseControl
    {
        public ChangeSystemWallPapper()
        {
            InitializeComponent();
        }
        #region 变量
        string strApplicationPath = System.Windows.Forms.Application.StartupPath;
        string strSetingTexFilePath= System.Windows.Forms.Application.StartupPath+ "\\SetingTexFileForChangeSystemWallPapper.txt"
        #endregion
        // 选择文件：
        private string SelectPathForFile()
        {
            string path = string.Empty;
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = "Files (*.*)|*.*"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                path = openFileDialog.FileName;
            }
            return path;
        }
        // 选择路径
        private string SelectPath()
        {
            string path = string.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            return path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string papperFilePath = this.SelectPathForFile();
            this.papperFile.Text = papperFilePath;
            this.pictureBox1.ImageLocation = papperFilePath;
            
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            Pen pp = new Pen(Color.Red);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y,
 e.ClipRectangle.X + e.ClipRectangle.Width - 1,
e.ClipRectangle.Y + e.ClipRectangle.Height - 1);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ChangeSystemWallPapper_Load(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrEmpty(papperFile.Text))
            {
                this.pictureBox1.ImageLocation = papperFile.Text;
            }
        }
    }
}
