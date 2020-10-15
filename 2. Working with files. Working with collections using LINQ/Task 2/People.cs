using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class People
    {
        public List<Person> people = new List<Person>();

        public People()
        {
            people = FileLoader.ReadFromTextFile("./Data/People.txt");
        }

        public List<Person> AllPeopleFromSameCity(string city)
        {
            return people.Where(x => x.City == city).ToList();
        }

        public int Under18()
        {
            return people.Where(x => x.Age < 18).Count();
        }

        public int Over65()
        {
            return people.Where(x => x.Age > 65).Count();
        }

        public List<string> NameGenderM()
        {
            return people.Where(x => x.Gender == "m").Select(x => x.FirstName + " " + x.LastName).ToList();
        }

        public int CountFemales()
        {
            return people.Where(x => x.Gender == "f").Count();
        }

        public int Range18and28()
        {
            return people.Where(x => x.Age <= 18 && x.Age >= 28).Count();
        }

        public List<string> DifferentCities()
        {
            return people.Select(x => x.City).Distinct().ToList();
        }

        public List<Person> OldestToYoungest()
        {
            return people.OrderByDescending(x => x.Age).ToList();
        }
    }
}
