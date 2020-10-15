using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace task_1
{
    class Bootstrap
    {
        public static IContainer Components()
        {
            var builder = new ContainerBuilder();

          //builder.RegisterType<ConsoleLogger>().As<ILogger>();
            builder.RegisterType<DBLogger>().As<ILogger>();
          //builder.RegisterType<FileLogger>().As<ILogger>();


            return builder.Build();
        }
    }
}
