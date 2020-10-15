using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var container = Bootstrap.Components())
            {
                var logger = container.Resolve<ILogger>();

                logger.Logger();

                //LoggerEngine loggerEngine = new LoggerEngine(logger);
                //loggerEngine.Logger();
            }

            Console.ReadLine();
        }
    }
}
