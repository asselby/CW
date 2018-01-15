using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataBaseConnectionFactory
    {
        private static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        }

        public static SqlConnection Connection()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString());
            return sqlConnection;
        }
    }
}
