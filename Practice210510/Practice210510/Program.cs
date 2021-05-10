using System;

namespace Practice210510
{
    class Program
    {
        delegate void DoSomething(string name);
        delegate string Concatenate(string[] arr);
        static void Main(string[] args)
        {
            DoSomething doIt = (name) =>
            {
                Console.WriteLine($"{name}~!");
            };
            string name = "*Hugo*";
            doIt(name);

            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                }
                return result; //void 쓰면 return 값 없음
            };

            string[] strarr = { "아버지가 ", "방에 ", "들어가신다" };
            Console.WriteLine(concat(strarr));

            Func<int> func1 = () => 3;
            var val = func1();
            Console.WriteLine($"val의 값은 {val}.");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3 + 5 = {plus(3, 5)}");
            
        }
    }
}
