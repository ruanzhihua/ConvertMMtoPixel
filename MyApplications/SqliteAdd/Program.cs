using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteAdd
{

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Console.WriteLine("参数个数：{0}", args.Length);
            //foreach (string each in args)
            //{
            //    Console.WriteLine("命令行参数：{0}", each);
            //}
            //Console.ReadKey();
            ////string dt1 = DateTime.Now.ToString();
            ////Console.WriteLine(dt1);
            //return;
            try
            {
                if (args.Length == 0)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                if (args.Length == 3)
                {

                    SqliteOperate insertData = new SqliteOperate();
                    if (args[1].Contains("||"))//第二个参数再次解析
                    {
                        insertData.fileMd5 = args[1].Substring(0,args[1].IndexOf("||"));
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
                            insertData.fileName+= each.Substring(each.LastIndexOf('/') + 1)+" ";
                        }
                        else if (each.Contains(@"\"))
                        {
                            insertData.fileName += each.Substring(each.LastIndexOf('\\') + 1)+" ";
                        }
                        else
                        {
                            insertData.fileName += each+" ";
                        }
                    }
                    insertData.fileName = insertData.fileName.TrimEnd();
                    insertData.insertData = args[2].Replace("|", " ");
                    insertData.ExecInsert();
                }
                if(args.Length==2)
                {
                    SqliteOperate insertData = new SqliteOperate();
                    if (args[0].Contains("||"))//第二个参数再次解析，第二个参数包含sqlite数据库路径
                    {
                        insertData.fileMd5 = args[0].Split('|')[0];
                        insertData.databaseLocation = args[0].Substring(args[0].IndexOf("||")+1);
                    }
                    else
                    {
                        insertData.fileMd5 = args[0];
                    }
                    
                    insertData.fileName = "";
                    
                    insertData.insertData = args[1].Replace("|"," ");
                    insertData.ExecInsert();
                }
                
            }
            catch (Exception ex)
            {

            }
            //Console.WriteLine("程序结束。");
            //Console.ReadKey();
        }
        
    }
    

}
