using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            List<string> questions = new List<string>
            {
                 "1.Get all people that live in a city entered from console input.",
                 "2.How many people are under 18?",
                 "3.How many people are over 65?",
                 "4.Get the first and last name of all males.",
                 "5.Get the count of all females.",
                 "6.How many people are in the range of 18-28?",
                 "7.Get all different cities",
                 "8.Show people ordered by age from oldest to youngest."
            };
            do
            {
                foreach (var item in questions)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nPlease select: ");
                int selection = Convert.ToInt32(Console.ReadLine());

                
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Please write city");
                        string city = Console.ReadLine();
                        PrintElements(people.AllPeopleFromSameCity(city));
                        break;
                    case 2:
                        Console.WriteLine(people.Under18());
                        break;
                    case 3:
                        Console.WriteLine(people.Over65());
                        break;
                    case 4:
                        PrintElements1(people.NameGenderM());
                        break;
                    case 5:
                        Console.WriteLine(people.CountFemales());
                        break;
                    case 6:
                        Console.WriteLine(people.Range18and28());
                        break;
                    case 7:
                        PrintElements1(people.DifferentCities());
                        break;
                    case 8:
                        PrintElements(people.OldestToYoungest());
                        break;
                    default:
                        Console.WriteLine("Invalid selection!");
                        break;
                }

                Console.WriteLine("Exit y/n");
            } while (Console.ReadLine() != "y");
        }
        
        public static void PrintElements(IEnumerable<Person> people)
        {
            foreach (var item in people)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Gender} {item.Age} {item.City}");
            }
        }

        public static void PrintElements1(IEnumerable<string> people)
        {
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }

    }
}
