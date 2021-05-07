using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MainApp : MyList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
            {
                list[i] = (i + 1); // 1~5 this[index] set
            }
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]); // this[index] get
            }

            Console.WriteLine("Foreach 실행====");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
