using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class ConsoleLogger : ILogger
    {
        public void Logger()
        {
            Console.WriteLine("Hi from ConsoleLogger");
        }
    }
}
