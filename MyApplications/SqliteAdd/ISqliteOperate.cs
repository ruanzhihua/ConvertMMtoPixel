using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SqliteAdd
{
    public class ISqliteOperate
    {
        [Guid("2A7E295F-A77E-4B0E-992C-2899821BFAB6")]
        public interface IOperate
        {
            [DispId(1)]
            bool ExecuteSql(string sql);

            [DispId(2)]
            bool ExecuteSql(string sql, string databaseLocation);
            
        }
    }
}
