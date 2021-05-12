using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger // Ver 1.0에서 업데이트
    {
        public void WriteError(string error)
        {
            //throw new NotImplementedException();
            //Debug.
        }

        public void WriteLog(string message) // 인터페이스 구현
        {
            //throw new NotImplementedException(); // 예외는 던진다(?)
            Console.WriteLine($"로그 {DateTime.Now} : {message} ");
        }
    }
}
