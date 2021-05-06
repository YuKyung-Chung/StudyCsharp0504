using System;
using System.Reflection;

namespace UsingInterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var monitor = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
            monitor.PrintLog("로그내용입니다!");

            var monitor = new ExtendedMonitor(new FileLogger("210504.log"));
            monitor.PrintLog("로그내용입니다!");
        }
          
    }
}
