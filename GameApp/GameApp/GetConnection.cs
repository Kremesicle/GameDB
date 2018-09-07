using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GameApp
{
    public class GetConnection
    {       
        public static SqlConnection OpenConnection()
        {
            SqlConnection sn = new SqlConnection();
            sn.ConnectionString = @"Data Source=DESKTOP-CRMGFLF\SQLEXPRESS;Database=TestTable;Integrated Security=True;";
            sn.Open();
            return sn;
        }
    }
}
