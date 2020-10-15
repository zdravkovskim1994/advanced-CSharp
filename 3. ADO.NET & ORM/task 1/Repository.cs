using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace task_1
{
    class Repository : IRepository
    {
        public int CreateNote(Note note)
        {
            try
            {
                using(SqlConnection conn = DbHelpper.GetConnection())
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@title", note.Title);
                    parameters.Add("@description", note.Description);

                    int result = conn.Execute("CreateNote", parameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return -1;
            }
            
        }
        public int EditNote(Note note)
        {
            try
            {
                using(SqlConnection conn = DbHelpper.GetConnection())
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@id", note.Id);
                    parameters.Add("@title", note.Title);
                    parameters.Add("@description", note.Description);

                    int result = conn.Execute("EditNote", parameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int DeleteNote(Note note)
        {
            try
            {
                using(SqlConnection conn = DbHelpper.GetConnection())
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@id", note.Id);

                    int result = conn.Execute("DeleteNote", parameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public Note SelectNote(Note note)
        {
            try
            {
                using(SqlConnection conn = DbHelpper.GetConnection())
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@id", note.Id);

                    Note result = conn.Query<Note>("SelectId", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    return result;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
