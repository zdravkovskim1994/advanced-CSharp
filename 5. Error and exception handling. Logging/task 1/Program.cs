using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using task_1.Models;

namespace task_1
{
    class Program
    {
        private static ILog log = LogManager.GetLogger(typeof(DbHelper.DbAccess));
        static void Main(string[] args)
        {
            string path = "./Data/Students.txt";
            XmlConfigurator.Configure();
            List<Student> students = new List<Student>();

            LoadFromFile loader = new LoadFromFile();

            try
            {
                students = loader.LoadStudents(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load students. " + ex.Message);

            }

            AddStudentsToDB(students);

            Console.ReadLine();

        }
        private static void AddStudentsToDB(List<Student> students)
        {
            foreach (var item in students)
            {
                try
                {
                    Repository.InsertStudentToDb(item);
                    log.Info("Successfully inserted students");
                }
                catch (Exception ex)
                {

                    log.Error("Failed to insert", ex);
                }
            }
                
        }
    }
}
