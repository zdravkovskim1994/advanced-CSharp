using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\n");
            do
            {
                Console.WriteLine("Please enter number of command you want to execute:");
                //Method for Print menu
                PrintMenu();
                Console.WriteLine(" ");
                int menu = int.Parse(Console.ReadLine());
                Console.WriteLine("START");

                switch (menu)
                {
                    case 1:
                        CreateNote();
                        break;
                    case 2:
                        EditNote();
                        break;
                    case 3:
                        DeleteNote();
                        break;
                    case 4:
                        SelectNote();
                        break;
                    default:
                        Console.WriteLine("Invalid menu!");
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Do you want to continue (Y/N)?");
            } while (Console.ReadLine() != "n");
        }
        private static void PrintMenu()
        {
            Console.WriteLine("1.Create Note");
            Console.WriteLine("2.Edit Note");
            Console.WriteLine("3.Delete Note");
            Console.WriteLine("4.Select Note");
        }
        private static void CreateNote()
        {
            Note note = new Note();

            Console.WriteLine("Please enter title: ");
            note.Title = Console.ReadLine();

            Console.WriteLine("Please enter discription");
            note.Description = Console.ReadLine();

            Repository repository = new Repository();
            repository.CreateNote(note);
        }

        private static void EditNote()
        {
            Note note = new Note();

            Console.WriteLine("Enter Id: ");
            note.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Title: ");
            note.Title = Console.ReadLine();

            Console.WriteLine("Enter Description: ");
            note.Description = Console.ReadLine();

            Repository repository = new Repository();
            repository.EditNote(note);
        }

        private static void DeleteNote()
        {
            Note note = new Note();
            Console.WriteLine("Please enter Id: ");
            note.Id = int.Parse(Console.ReadLine());

            Repository repository = new Repository();
            repository.DeleteNote(note);
        }

        private static void SelectNote()
        {
            Note note = new Note();
            Console.WriteLine("Enter Id: ");
            note.Id = int.Parse(Console.ReadLine());

            Repository repository = new Repository();
            var result = repository.SelectNote(note);

            //Print Element Method (SELECT * )
            PrintElement(result);
        }

        private static void PrintElement(Note note)
        {
            Console.WriteLine("Id:          " + note.Id);
            Console.WriteLine("Title:       " + note.Title);
            Console.WriteLine("Description: " + note.Description);
            Console.WriteLine("DateCreated: " + note.DateCreated);
        }
    }
}
