using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_1.Models;
using System.IO;
using log4net;
using task_1.DbHelper;

namespace task_1
{
    class LoadFromFile
    {
        private static ILog log = LogManager.GetLogger(typeof(DbAccess));
        public List<Student> LoadStudents(string path)
        {
            List<Student> students = new List<Student>();
            List<string> result = new List<string>();

            try
            {
                result = File.ReadAllLines(path).ToList();
            }
            catch (FileNotFoundException ex)
            {
                log.Error("Faild to load File!");
                throw ex;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

            foreach (var item in result)
            {
                var studentProperties = item.Split(',');

                try
                {
                    Student student = new Student();
                    student.FirstName = studentProperties[0];
                    student.LastName = studentProperties[1];
                    student.Age = int.Parse(studentProperties[2]);
                    student.Gender = studentProperties[3];
                    student.City = studentProperties[4];
                    student.Country = studentProperties[5];

                    students.Add(student);
                }
                catch (Exception ex)
                {
                    log.Error($"Failed to load line {studentProperties}", ex);
                }
            }

            return students;
        }
    }
}
