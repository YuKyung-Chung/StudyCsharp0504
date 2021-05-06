using System;
using System.Collections;

namespace CollectionTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList 예제");

/*            //object는 모든 형태의 자료 다 들어갈 수 있음!!!
            int a = 123;
            //object obj = a; //박싱
            object obj = (object)a; //박싱
            int b = (int) obj; //언박싱 => obj에 어떤 값이 들어갈지 모르기 때문에 이런 과정 거침

            Console.WriteLine("a의 타입 : " + a.GetType());
            Console.WriteLine("obj의 타입 : " + obj.GetType());

            Console.WriteLine("a의 값 : " + a);
            Console.WriteLine("obj의 값 : " + obj);
            Console.WriteLine("b의 값 : " + b);

            string str = "문자열임";
            obj = str;

            Console.WriteLine("str의 값 : " + str);
            Console.WriteLine("obj의 값 : " + obj);*/

            ArrayList list = new ArrayList(); //배열인데 사이즈 지정X
            list.Add(3);
            list.Add(67);
            list.Add(1.4f);
            list.Add(30.67);
            list.Add("14");

            foreach (var item in list) //item은 object라 모든 형태의 자료 다 들어감.
            {
                Console.WriteLine(item);
            }

/*            list.Sort(); 같은 자료형끼리만 정렬 가능!
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();*/

            list.Add(100);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Insert(2, 88); //[2]번째 위치에 88 삽입 
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //list.RemoveAt(5); // [5]번째 위치 자료 삭제
            list.Remove(5); // 5라는 값을 삭제
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치 : {index100}");

            int lstIndex14 = list.LastIndexOf(14);
            Console.WriteLine($"마지막 14의 위치값 : {lstIndex14}");

            Console.WriteLine($"총 개수 : {list.Count}");
            Console.WriteLine($"리스트 마지막값 : {list[list.Count-1]}");

        }
    }
}
