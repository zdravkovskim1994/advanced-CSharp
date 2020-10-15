using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using task_1.Models;
using System.Data.SqlClient;
using System.Data;

namespace task_1
{
    class Repository
    {

        public static bool InsertStudentToDb(Student student)
        {
            try
            {
                using (SqlConnection conn = DbHelper.DbAccess.GetSqlConnection())
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@firstName", student.FirstName);
                    parameters.Add("@lastName", student.LastName);
                    parameters.Add("@age", student.Age);
                    parameters.Add("@gender", student.Gender);
                    parameters.Add("@city", student.City);
                    parameters.Add("@country", student.Country);

                    int result = conn.Execute("InsertStudent", parameters, commandType: CommandType.StoredProcedure);
                    return result > 0;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
