using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteAdd
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        SqliteOperate sqliteOperate = new SqliteOperate();

        private void button1_Click(object sender, EventArgs e)
        {
            
            string result=sqliteOperate.getFileMd5();
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string result = string.Join("|",sqliteOperate.getShxList(this.textInput.Text.Trim()).ToArray());
            MessageBox.Show(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            sqliteOperate.fileMd5 = textFileMd5.Text.Trim();
            sqliteOperate.fileName = textFileName.Text.Trim();
            sqliteOperate.insertData = textShxName.Text.Trim();
            sqliteOperate.ExecInsert();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int result = sqliteOperate.deleteDataWithMd5(this.textInput.Text.Trim());
            MessageBox.Show(result.ToString()+sqliteOperate.errmsg);
        }

        private void execCmdArgs1_Click(object sender, EventArgs e)
        {
            string[] args = this.cmdArgs.Text.Trim().Split(' ');
            if (args.Length == 3)
            {

                SqliteOperate insertData = new SqliteOperate();
                if (args[1].Contains("||"))//第二个参数再次解析
                {
                    insertData.fileMd5 = args[1].Substring(0, args[1].IndexOf("||"));
                    insertData.databaseLocation = args[1].Substring(args[1].IndexOf("||") + 2);//双杠加2
                }
                else
                {
                    insertData.fileMd5 = args[1];
                }
                //从文件完全路径截取到文件名
                foreach (string each in args[0].Split(','))
                {
                    if (each.Contains("/"))
                    {
                        insertData.fileName += each.Substring(each.LastIndexOf('/') + 1) + " ";
                    }
                    else if (each.Contains(@"\"))
                    {
                        insertData.fileName += each.Substring(each.LastIndexOf('\\') + 1) + " ";
                    }
                    else
                    {
                        insertData.fileName += each + " ";
                    }
                }
                insertData.fileName = insertData.fileName.TrimEnd();
                insertData.insertData = args[2].Replace("|", " ");
                insertData.ExecInsert();
            }
            if (args.Length == 2)
            {
                SqliteOperate insertData = new SqliteOperate();
                if (args[0].Contains("||"))//第二个参数再次解析，第二个参数包含sqlite数据库路径
                {
                    insertData.fileMd5 = args[0].Split('|')[0];
                    insertData.databaseLocation = args[0].Substring(args[0].IndexOf("||") + 1);
                }
                else
                {
                    insertData.fileMd5 = args[0];
                }

                insertData.fileName = "";

                insertData.insertData = args[1].Replace("|", " ");
                insertData.ExecInsert();
            }
        }
    }
}
