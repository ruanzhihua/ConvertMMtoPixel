using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace MyApplications
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DataTable dtResult=new DataTable();
        DataView dvResult=new DataView();
        int variationalWidth = 0;
        string[] applicationPath = { Application.StartupPath + "\\无损音乐下载器V3.5.exe" };
        System.Timers.Timer timer = new System.Timers.Timer();

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void initResultDisplay()
        {
            dtResult.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Sort",typeof(int)),
                new DataColumn("Result",typeof(float))
            });            
            dvResult = new DataView(dtResult);
            //绑定数据源时，不自动创建新列，而是使用设计器的列，列的DataPropertyName = 表的字段名
            dataGridView1.AutoGenerateColumns = false;
            
            this.dataGridView1.DataSource = dvResult;
            
            
        }
        private void theFirstNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void theFirstNum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.thePixel.Text = (int.Parse(this.theFirstNum.Text) / 25.4 * int.Parse(this.theSecondNum.Text)).ToString();
                float resultNum;
                
                if (float.TryParse(this.thePixel.Text,out resultNum)&&resultNum!=0)
                {
                    DataRow row = dtResult.NewRow();
                    row["Sort"] = dtResult.Rows.Count + 1;
                    row["Result"] = resultNum;
                    if(dtResult.Rows.Count==13)
                    {
                        dtResult.Rows.RemoveAt(0);
                        foreach(DataRow dataRow in dtResult.Rows)
                        {
                            dataRow["Sort"] = int.Parse(dataRow["Sort"].ToString()) - 1;
                        }
                        row["Sort"] = 13;
                        
                    }
                    dtResult.Rows.Add(row);                   
                    
                }
            }
        }

        private void thePixel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.theFirstNum.Text = (int.Parse(this.thePixel.Text) / int.Parse(this.theSecondNum.Text)*25.4).ToString();
                
            }
        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = System.DateTime.Now.ToLongDateString()+" "+ System.DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.initResultDisplay();
            this.DoubleBuffered = true;
            this.PictureBoxPaint();
            //排序按钮
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            #region 菜单图标
            Icon iconForMusicDownload = ApplicationProgramFunction.GetSystemIcon.GetIconByFileName(applicationPath[0],false);
            oneToolStripMenuItem.Image = iconForMusicDownload.ToBitmap();
            #endregion

            //开启线程
            Thread t1 = new Thread(new ThreadStart(variationalBarThread));
            t1.Start();

        }

        private void 设置参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            
            setting.ShowDialog();
            
            
            
        }

        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //如果已启动程序，不做动作
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName(applicationPath[0].Replace(Application.StartupPath+"\\","").Replace(".exe","").Trim());
            if(process.Length>0)
            {
                return;
            }
            System.Diagnostics.Process processNew = new System.Diagnostics.Process();
            processNew.StartInfo.FileName = applicationPath[0];
            processNew.Start();
            
        }
        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorToArgb colorToArgb = new ColorToArgb();
            colorToArgb.ShowDialog();
            //ColorToArgb
        }
        private void threeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSystemWallPapper changeSystemWallPapper = new ChangeSystemWallPapper();
            // 窗口最大化
            changeSystemWallPapper.WindowState = FormWindowState.Maximized;
            changeSystemWallPapper.Show();
        }
        private void variationalBarThread()
        {            
            timer.Interval = 10;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timerElapsed);
        }
        private void timerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {            
            variationalWidth += 1;
            if(variationalWidth == 151)
            {
                variationalWidth = 0;
            }
            variationalBar.Width = variationalWidth;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxPaint()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                PointF pf = new PointF(10, 10);
                Font f = new Font("宋体", 10, FontStyle.Regular);
                SolidBrush sbrush = new SolidBrush(Color.Black);
                graphics.DrawString("测试图片内容", f, sbrush, pf);
                pictureBox1.Image = bitmap;
            }
            
        }

        private void variationalBar_DoubleClick(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                this.timer.Stop();
            }
            else
            {
                this.timer.Start();
            }
        }

        private void pictureEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPictureForCell editPictureForCell = new EditPictureForCell();
            editPictureForCell.WindowState = FormWindowState.Normal;
            editPictureForCell.ShowDialog();
        }

        private void serviceTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            #region service1
            {
                string injson ="{"+ "\"instring\":\"wahh\"}";
                string serviceAddress = "http://localhost:52182/Services/TestService.svc/DoWork";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serviceAddress);
                httpWebRequest.Method = "POST";
                //request.CookieContainer = cookies;
                httpWebRequest.ContentType = "application/json";
                using (StreamWriter dataStream = new StreamWriter(httpWebRequest.GetRequestStream()))
                {                    
                    dataStream.Write(injson);
                    dataStream.Close();
                }
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                string encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8"; //默认编码  
                }
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                string retString = reader.ReadToEnd();
                MessageBox.Show(retString);
                //解析josn                
                JObject jo = JObject.Parse(retString);
            }

            #endregion
            #region
            {
                string injson = "{" + "\"folderPath\":\"\"}";
                string serviceAddress = "http://localhost:52182/Services/PKPMSVNFolderService.svc/GetPKPMSVNFolderList";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serviceAddress);
                httpWebRequest.Method = "POST";
                //request.CookieContainer = cookies;
                httpWebRequest.ContentType = "application/json";
                using (StreamWriter dataStream = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    dataStream.Write(injson);
                    dataStream.Close();
                }
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                string encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8"; //默认编码  
                }
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                string retString = reader.ReadToEnd();
                MessageBox.Show(retString);
                //解析josn                
                JObject jo = JObject.Parse(retString);
            }
            #endregion 
            return;
            #region xml不好使
            {                
                string param = @"<?xml version=""1.0"" encoding=""utf-8""?>
                                        <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                                          <soap:Body>
                                            <DoWork xmlns=""http://tempuri.org/"">   
                                                   <instring>sss</folderPath>
                                            </DoWork>
                                          </soap:Body>
                                        </soap:Envelope>";
                byte[] bs = Encoding.UTF8.GetBytes(param);
                string serviceAddress = "http://localhost:52182/Services/TestServiceForXMLRequest.svc//DoWork";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serviceAddress);
                httpWebRequest.Method = "POST";
                //request.CookieContainer = cookies;
                httpWebRequest.ContentType = "text/xml;charset=utf-8";               
                httpWebRequest.ContentLength = bs.Length;
                //参数传递
                using (Stream dataStream = httpWebRequest.GetRequestStream())
                {
                    dataStream.Write(bs, 0, bs.Length);
                    //dataStream.Write(injson);
                    dataStream.Close();
                }
                //结果读取
                using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    string encoding = response.ContentEncoding;
                    if (encoding == null || encoding.Length < 1)
                    {
                        encoding = "UTF-8"; //默认编码  
                    }
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                    string retString = reader.ReadToEnd();
                    MessageBox.Show(retString);
                    //解析josn                
                    JObject jo = JObject.Parse(retString);
                }
            }
            #endregion
        }

        private void dWGTOPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConverDWGToPDF dWGToPDF = new FormConverDWGToPDF();
            dWGToPDF.StartPosition = FormStartPosition.CenterParent;
            dWGToPDF.ShowDialog();
        }
    }
}
