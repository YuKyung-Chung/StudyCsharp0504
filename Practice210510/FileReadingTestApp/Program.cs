using System;
using System.Globalization;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath,FileMode.Open));
            
            while (sr.EndOfStream == false) //스트림의 끝까지 갔는지?
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close(); //필수

            //텍스트파일 읽어오는 부분
            Console.WriteLine("텍스트파일 읽기완료!!");

            string writePath = @"C:\Test\Help\SMG.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));

            sw.Write("안녕하세요");
            sw.Close(); //필수

            Console.WriteLine("종료합니다.");
        }
    }
}
