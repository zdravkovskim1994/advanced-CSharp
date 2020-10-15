using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class FileLoader
    {
        public static List<Person> ReadFromTextFile(string path)
        {
            List<Person> people = new List<Person>();

            if (File.Exists(path))
            {
                var items = File.ReadAllLines(path);

                foreach (var item in items)
                {
                    var data = item.Split(',');

                    people.Add(new Person
                    {
                        FirstName = data[0],
                        LastName = data[1],
                        Gender = data[2],
                        Age = Convert.ToInt32(data[3]),
                        City = data[4]

                    });
                }
            }
            return people;
        }
    }
}
