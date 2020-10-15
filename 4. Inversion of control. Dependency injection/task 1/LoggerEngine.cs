using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class LoggerEngine
    {
        private ILogger loggerEngine;

        public LoggerEngine(ILogger loggerEngine)
        {
            this.loggerEngine = loggerEngine;
        }

        public void Logger()
        {
            loggerEngine.Logger();
        }
    }
}
