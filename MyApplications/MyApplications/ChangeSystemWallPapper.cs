using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
        FileInfo[] filesPdf;
        int rollWallPapperIndex=0;
        DelegateForCalculateFunctionRunTime delegateForCalculateFunctionRunTime = new DelegateForCalculateFunctionRunTime();
        ApplicationProgramFunction.PDFWatermarkFunction pDFWatermarkFunction = new ApplicationProgramFunction.PDFWatermarkFunction();
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
            //System.Windows.Forms.FileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();
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
        /// <summary>
        /// 选择PDF文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            string papperFilePath = this.SelectPath();
            this.textBoxPDFFolder.Text = papperFilePath;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string papperFilePath = this.SelectPathForFile("图像(*.jpg;*.JPG;*.png)|*.jpg;*.JPG;*.png");
            this.textBoxWaterPapper.Text = papperFilePath;
        }
        /// <summary>
        /// 文件格式
        /// </summary>
        /// <param name="filterString"></param>
        /// <returns></returns>
        private string SelectPathForFile(string filterString)
        {
            string path = string.Empty;
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = filterString//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                path = openFileDialog.FileName;
            }
            return path;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPDFFolder.Text) && Directory.Exists(textBoxPDFFolder.Text)&& !string.IsNullOrWhiteSpace(textBoxWaterPapper.Text) &&File.Exists(textBoxWaterPapper.Text))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(textBoxPDFFolder.Text);
                filesPdf = directoryInfo.GetFiles();
            }
            else
            {
                MessageBox.Show("请选择PDF文件夹或水印路径！", "提示");
                return;
            }
            
            if(!Regex.IsMatch(textBoxLocationX.Text, @"^-|[1-9][0-9]*$")||!Regex.IsMatch(textBoxLocationY.Text,@" ^-|[1-9][0-9]*$"))
            {
                MessageBox.Show("坐标包含非法字符","提示");
                return;
            }
            foreach(FileInfo fileInfo in filesPdf)
            {
                string outputfilepath = textBoxWaterPDFFolder.Text+"\\" +fileInfo.Name;
                if (string.IsNullOrWhiteSpace(textBoxWaterPDFFolder.Text) ||!Directory.Exists(textBoxWaterPDFFolder.Text))
                {
                    outputfilepath = fileInfo.FullName.Split('.')[0] + "1.pdf";
                }

                    
                    pDFWatermarkFunction.PDFWatermark(fileInfo.FullName, outputfilepath, this.textBoxWaterPapper.Text,24, int.Parse(textBoxLocationY.Text), int.Parse(textBoxLocationX.Text),0);
            }
            MessageBox.Show("转换完成","提示");
        }

        private void buttonSelectCacheFolder_Click(object sender, EventArgs e)
        {
            string waterPdfFilePath = this.SelectPath();
            this.textBoxWaterPDFFolder.Text = waterPdfFilePath;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 获取文字位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            pDFWatermarkFunction.GetTextLocationAndSize(this.textBoxPDFPath.Text, new List<string>(textBoxText.Text.Split(' ')));
            try
            {
                if (pDFWatermarkFunction.textInfos.Count == 0) return;
                StringBuilder pointStr=new StringBuilder(20);
                foreach(ApplicationProgramFunction.textInfo textInfo in pDFWatermarkFunction.textInfos)
                {
                    pointStr.AppendLine(textInfo.textLocation.X.ToString()+" "+ textInfo.textLocation.Y.ToString());
                }
                

                textLocationX.Text = (pDFWatermarkFunction.textInfos[0].textLocation.X+2 * pDFWatermarkFunction.textInfos[0].textSize.Height).ToString();
                textLocationY.Text = (pDFWatermarkFunction.textInfos[0].textLocation.Y + pDFWatermarkFunction.textInfos[0].textSize.Height).ToString();
                MessageBox.Show(pointStr.ToString());
            }
            catch (Exception ex)
            { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string papperFilePath = this.SelectPathForFile("文件(*.pdf;*.PDF)|*.pdf;*.PDF");
            this.textBoxPDFPath.Text = papperFilePath;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pDFWatermarkFunction.PDFWatermark(textBoxPDFPath.Text, textBoxPDFPath.Text, this.textBoxWaterPapper.Text,24, float.Parse(textLocationY.Text), float.Parse(textLocationX.Text), 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool result=pDFWatermarkFunction.PDFZoom(textBoxPDFPath.Text, textBoxPDFPath.Text,iTextSharp.text.PageSize.A5);
            if(result)
            {
#pragma warning disable CA1303 // 请不要将文本作为本地化参数传递
                _ = MessageBox.Show("success!");
#pragma warning restore CA1303 // 请不要将文本作为本地化参数传递
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(this.textBoxWaterPapper.Text, FileMode.Open, FileAccess.Read);
            Stream ms = new MemoryStream();
            fs.Position = 0;
            fs.CopyTo(ms);
            Bitmap bitmap = new Bitmap(ms);
            bitmap.Save(@"D:\BuildFolder\2.png");

        }
    }
}
