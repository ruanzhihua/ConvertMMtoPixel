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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtResult=new DataTable();
        DataView dvResult=new DataView();
        int variationalWidth = 0;
        string[] applicationPath = { Application.StartupPath + "\\无损音乐下载器V3.5.exe" };
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
        private void variationalBarThread()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
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

        
    }
}
