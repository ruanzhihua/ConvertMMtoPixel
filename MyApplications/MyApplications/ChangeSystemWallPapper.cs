using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace MyApplications
{
    /// <summary>
    /// 自己写的代码我自己度看不懂，委托。。。。
    /// </summary>
    public partial class ChangeSystemWallPapper : MyControls.ContainerControls.UserBaseControl
    {
        public ChangeSystemWallPapper()
        {
            InitializeComponent();
        }
        #region 变量
        string strApplicationPath = System.Windows.Forms.Application.StartupPath;
        string strSetingTexFilePath = System.Windows.Forms.Application.StartupPath + "\\SetingTexFileForChangeSystemWallPapper.txt";
        string strSetingTexFilePathPath = System.Windows.Forms.Application.StartupPath + "\\SetingTexFileForChangeSystemWallPapperRoll.txt";
        System.Timers.Timer timerForWallpapperRoll = new System.Timers.Timer();
        FileInfo[] files;
        int rollWallPapperIndex=0;
        DelegateForCalculateFunctionRunTime delegateForCalculateFunctionRunTime = new DelegateForCalculateFunctionRunTime();
        #endregion

        #region 系统组件
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
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
        private void ChangeDesktopImage(string imagePath,bool whetherChangeRegeditList)
        {
            int result;
            if(File.Exists(imagePath))
            {
                result = SystemParametersInfo(20, 1, imagePath, 0x1 | 0x2);
                if (result == 0)
                {
                    MessageBox.Show("没有更新成功!");
                }
                else if(whetherChangeRegeditList)
                {
                    RegistryKey hk = Registry.CurrentUser;
                    RegistryKey run = hk.CreateSubKey(@"Control Panel\Desktop\");
                    run.SetValue("Wallpaper", imagePath);  //将新图片路径写入注册表
                    MessageBox.Show("更新成功");
                }
            }
            else
            {
                MessageBox.Show("文件不存在!");
            }
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
            if(!string.IsNullOrEmpty(papperFile.Text))
            {
                StreamWriter streamWriter = new StreamWriter(strSetingTexFilePath, false, System.Text.Encoding.Default);
                streamWriter.WriteLine(papperFile.Text);
                streamWriter.Close();
                this.ChangeDesktopImage(papperFile.Text,true);
            }
        }

        private void ChangeSystemWallPapper_Load(object sender, EventArgs e)
        {
            if(File.Exists(strSetingTexFilePath))
            {
                StreamReader streamReader = new StreamReader(strSetingTexFilePath, System.Text.Encoding.Default);
                string[] textLine = new string[10];
                int i = 0;
                while((textLine[i] = streamReader.ReadLine())!=null)
                {
                    i++;
                    if(i>=10)
                    {
                        break;
                    }
                }
                streamReader.Close();
                papperFile.Text = textLine[0];
            }
            if(!string.IsNullOrEmpty(papperFile.Text))
            {
                this.pictureBox1.ImageLocation = papperFile.Text;
            }
            if (File.Exists(strSetingTexFilePathPath))
            {
                StreamReader streamReader = new StreamReader(strSetingTexFilePathPath, System.Text.Encoding.Default);
                string[] textLine = new string[10];
                int i = 0;
                while ((textLine[i] = streamReader.ReadLine()) != null)
                {
                    i++;
                    if (i >= 10)
                    {
                        break;
                    }
                }
                streamReader.Close();
                papperFilePath.Text = textLine[0];
            }
            this.timerForWallpapperRoll.Elapsed += TimerForWallpapperRoll_Elapsed;
            this.timerForWallpapperRoll.Interval = 120000;//2分钟间隔
            if (!string.IsNullOrWhiteSpace(papperFilePath.Text)&&File.Exists(papperFilePath.Text))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(papperFilePath.Text);
                files = directoryInfo.GetFiles();
            }
            delegateForCalculateFunctionRunTime.RunTimeEvent += ChangeDesktopImage;
        }

        private void TimerForWallpapperRoll_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (files.Count() > 0)
            {
                if (rollWallPapperIndex == files.Count())
                {
                    rollWallPapperIndex = 0;
                }
                //this.ChangeDesktopImage(files[rollWallPapperIndex].FullName, false);
                delegateForCalculateFunctionRunTime.FunctionRunTime(files[rollWallPapperIndex].FullName, false);
                rollWallPapperIndex++;
                if(rollWallPapperIndex==files.Count())
                {
                    rollWallPapperIndex = 0;
                }
            }
            //throw new NotImplementedException();
        }

        private void btnSelectWallPapperPath_Click(object sender, EventArgs e)
        {
            string papperFilePath = this.SelectPath();
            this.papperFilePath.Text = papperFilePath;
            
        }

        private void btnConfirmSelectPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(papperFilePath.Text))
            {
                StreamWriter streamWriter = new StreamWriter(strSetingTexFilePathPath, false, System.Text.Encoding.Default);
                streamWriter.WriteLine(papperFilePath.Text);
                streamWriter.Close();
                this.timerForWallpapperRoll.Start();
            }
        }
    }
}
