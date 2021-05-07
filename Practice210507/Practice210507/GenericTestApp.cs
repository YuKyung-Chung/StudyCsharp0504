using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice210507
{
    class GenericTestApp
    {
        static void Main(string[] args)
        {
            //int 배열을 int 배열로 복사
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // 5짜리 int 배열 {0,0,0,0,0}
            //복사전
            Console.WriteLine("복사전 targetInt 값");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<int>(sourceInt, targetInt);
            Console.WriteLine("복사후 targetInt 값");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];

            Console.WriteLine("복사전 targetFloat 값");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<float>(sourceFloat, targetFloat);
            Console.WriteLine("복사후 targetFloat 값");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            /////////////////////////////////////////////////////////////////////////////////////
            string[] sourceString = { "하나", "둘", "셋" };
            string[] targetString = new string[sourceString.Length];

            Console.WriteLine("복사전 targetString 값");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<string>(sourceString, targetString);
            Console.WriteLine("복사후 targetString 값");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        //일반화 메서드 통일
        private static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
