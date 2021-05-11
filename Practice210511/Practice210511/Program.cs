using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoSomething();
            Thread th1 = new Thread(new ThreadStart(DoSomething));
            th1.Start();
            //th1.Join();
            DoOtherthing();

        }

        private static void DoSomething()
        {
            for (int i =0; i < 30; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); //10ms 
            }
        }

        private static void DoOtherthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i}");
            }
        }
    }
}
