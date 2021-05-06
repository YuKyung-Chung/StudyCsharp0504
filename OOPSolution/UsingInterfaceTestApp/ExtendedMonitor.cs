using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class ExtendedMonitor : ILogger
    {
        public ExtendedMonitor(ConsoleLogger consoleLogger)
        {
            ConsoleLogger = consoleLogger;
        }

        public ConsoleLogger ConsoleLogger { get; }

        public void WriteLog(string message)
        {
            throw new NotImplementedException();
        }
    }
}
