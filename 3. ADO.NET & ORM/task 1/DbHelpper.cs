using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace task_1
{
    class DbHelpper
    {
        public static SqlConnection GetConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["NoteDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();
            return conn;
            
            
        }
    }
}
