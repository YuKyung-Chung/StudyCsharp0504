using System;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반화 컬렉션 테스트 ===== ");

            List<int> list = new List<int>();
            for (int i=0;i<=100;i++)
            {
                list.Add(i);
            }
            var sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            Console.WriteLine($"1~100의 합 = {sum}");
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            ///중요!
            Dictionary<string, int> dics = new Dictionary<string, int>();
            dics["하나"] = 1;
            dics["둘"] = 2;
            dics["셋"] = 3;
            dics["넷"] = 4;
            dics["다섯"] = 5;

            Console.WriteLine(dics["하나"]);
            Console.WriteLine(dics["셋"]);
            Console.WriteLine(dics["다섯"]);

            foreach (var item in dics)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
