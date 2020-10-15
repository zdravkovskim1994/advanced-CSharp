using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate<int> intCoordinate = new Coordinate<int>();
            intCoordinate.x = 15;
            intCoordinate.y = 17;

            Console.WriteLine("Int numbers: " + intCoordinate.x + "   " + intCoordinate.y);


            Coordinate<float> floatCoordinate = new Coordinate<float>();
            floatCoordinate.x = 12.34f;
            floatCoordinate.y = 33.99f;

            Console.WriteLine("Float numbers: " + floatCoordinate.x + "   " + floatCoordinate.y);


            Console.ReadLine();
            
        }
    }
}
