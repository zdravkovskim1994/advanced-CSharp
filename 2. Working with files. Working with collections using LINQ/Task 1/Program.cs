using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
            Console.WriteLine("1.Reverse Text\n2.Reverse Character");
            string path = "./Data/File1.txt";
            string path1 = "./Data/File2.txt";
            int select = Convert.ToInt32(Console.ReadLine());
            string result = string.Empty;

            string content = TextReader.TextReaderFile(path);
            Console.WriteLine(content);
            
            
                switch (select)
                {
                    case 1:
                        result = TextReader.ReverseText(content);
                        break;
                    case 2:
                        result = TextReader.ReverseCharacter(content);
                        break;
                }

                Console.WriteLine(result);
                TextReader.WriteTextOnNewFile(path1, result);
                Console.WriteLine("New text is saved in a new file.");

                Console.WriteLine("\nDo you want continue? \ny/n");
                
            } while (Console.ReadLine() != "n");

            
           

        }
    }
}
