using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using log4net;

namespace task_1.DbHelper
{
    class DbAccess
    {
        private static ILog log = LogManager.GetLogger(typeof(DbAccess));
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString);

            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                log.Error("Failed to connect to DB");
                throw ex;
            }

            return conn;
        }
    }
}
