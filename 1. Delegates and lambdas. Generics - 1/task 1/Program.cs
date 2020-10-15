using System;

namespace task_1
{
    public delegate int DelegateCalculator(int x, int y);
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter frist number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter secound number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1.Add\n2.Subtraction\n3.Multiplication\n4.Divison");

                int menu = Convert.ToInt32(Console.ReadLine());

                DelegateCalculator dc = new DelegateCalculator(Add);

                int result = 0;


                switch (menu)
                {
                    case 1:
                        result = dc.Invoke(a, b);
                        break;
                    case 2:
                        dc += Subtraction;
                        result = dc.Invoke(a, b);
                        break;
                    case 3:
                        dc += Multiplication;
                        result = dc.Invoke(a, b);
                        break;
                    case 4:
                        dc += Division;
                        result = dc.Invoke(a, b);
                        break;
                }
                Console.WriteLine("Result: " + result);
                Console.WriteLine("Exit y/n");
            } while (Console.ReadLine() != "y");
        }

        public static int Add(int x, int y)
        {
            return x + y;

        }

        public static int Subtraction(int x, int y)
        {
            return x - y;
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }

        public static int Division(int x, int y)
        {
            return x / y;
        }
    }
}
