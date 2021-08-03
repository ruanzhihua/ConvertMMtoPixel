using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SqliteAdd
{
    [Guid("2A7E295F-A77E-4B0E-992C-2899821BFAB6")]
    public class SqliteOperate
    {
        public string errmsg = string.Empty;
        public string fileMd5 = string.Empty;
        public string fileName = string.Empty;
        public string insertData = string.Empty;
        public string updateData = string.Empty;
        public string deleteData = string.Empty;
        //sqlite数据库所在位置，服务端调用该路径可能获取不正确，请手动修改该路径
        public string databaseLocation = System.AppDomain.CurrentDomain.BaseDirectory+"dwgshx.sqlite";
        SQLiteConnection conn = null;
        public bool ExecInsert()
        {
            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source="+databaseLocation);
                }
                catch(Exception ex)
                {
                    //throw new Exception(databaseLocation + ex.Message + ex.StackTrace);
                }
            }
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SQLiteTransaction transaction = conn.BeginTransaction();
            try
            {
                SQLiteCommand command = new SQLiteCommand(conn);
                command.Transaction = transaction;
                foreach(string each in insertData.Split('|'))
                {
                    command.CommandText = $@"select count(1) from dwgshxinfo where  fileMd5='{fileMd5}' and shxname= '{each}'";
                    if (command.ExecuteScalar() != null && Convert.ToInt32(command.ExecuteScalar()) == 0)
                    {
                        
                    }
                    else
                    {
                        continue;
                    }
                    command.CommandText = $@"insert into dwgshxinfo values('{fileMd5}','{fileName}', '{each}')";
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                conn.Close();
            }
            catch(Exception ex)
            {
                errmsg = string.Empty;
                errmsg += ex.Message + ex.StackTrace;
                transaction.Rollback();
                conn.Close();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获取已转换的md5列表
        /// </summary>
        /// <returns></returns>
        public string getFileMd5()
        {
            string fileMd5List = string.Empty;
            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=" + databaseLocation);
                }
                catch (Exception ex)
                {
                    //throw new Exception(databaseLocation + ex.Message + ex.StackTrace);
                }
            }
            if(conn.State==System.Data.ConnectionState.Closed) conn.Open();
            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = @"select distinct fileMd5 from dwgshxinfo";
            SQLiteDataReader reader= command.ExecuteReader();
            try
            {
                while(reader.Read())
                {
                    fileMd5List += reader["fileMd5"].ToString() + "|";
                }
            }
            catch(Exception ex)
            {
                errmsg = string.Empty;
                errmsg += ex.Message + ex.StackTrace;
                reader.Close();
            }
            reader.Close();
            return fileMd5List.Trim('|');
        }
        /// <summary>
        /// 获取已转换的md5列表
        /// </summary>
        /// <returns></returns>
        public List<string> getShxList(string fileMd5)
        {
            List<string> fileShxList = new List<string>();
            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=" + databaseLocation);
                }
                catch (Exception ex)
                {
                    //throw new Exception(databaseLocation + ex.Message + ex.StackTrace);
                }
            }
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = $@"select distinct shxname from dwgshxinfo where fileMd5='{fileMd5}'";
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    fileShxList.Add(reader["shxname"].ToString());
                }
            }
            catch (Exception ex)
            {
                errmsg = string.Empty;
                errmsg += ex.Message + ex.StackTrace;
                reader.Close();
            }
            reader.Close();
            return fileShxList;
        }/// <summary>
         /// 获取已转换的md5列表
         /// </summary>
         /// <returns></returns>
        public string getShxListString(string fileMd5)
        {
            string fileShxList = string.Empty;
            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=" + databaseLocation);
                }
                catch (Exception ex)
                {
                    //throw new Exception(databaseLocation + ex.Message + ex.StackTrace);
                }
            }
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = $@"select distinct shxname from dwgshxinfo where fileMd5 in('{fileMd5}')";
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    fileShxList+=reader["shxname"].ToString()+" ";
                }
            }
            catch (Exception ex)
            {
                errmsg = string.Empty;
                errmsg += ex.Message + ex.StackTrace;
                reader.Close();
            }
            reader.Close();
            return fileShxList.TrimEnd();
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="fileMd5"></param>
        /// <returns></returns>
        public int deleteDataWithMd5(string fileMd5)
        {
            int result = 0;
            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=" + databaseLocation);
                }
                catch (Exception ex)
                {
                    //throw new Exception(databaseLocation + ex.Message + ex.StackTrace);
                }
            }
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = $@"delete from dwgshxinfo where fileMd5='{fileMd5}'";
            
            try
            {
                result = command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                errmsg = string.Empty;
                errmsg += ex.Message + ex.StackTrace;
                result = -1;
                conn.Close();
            }
            return result;
        }
    }
}
