using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //排序按钮
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void 设置参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            
            setting.ShowDialog();
            
            
            
        }
    }
}
