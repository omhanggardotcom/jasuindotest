using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace webUtils
{
    public class utils
    {
        public static string MysqlCS() 
        {
            return ConfigurationManager.ConnectionStrings["mysqlCS"].ConnectionString;
        }
    }
}
