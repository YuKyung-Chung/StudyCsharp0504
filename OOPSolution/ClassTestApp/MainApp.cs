using System;
using System.Runtime.CompilerServices;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat("키티", "하얀색", 3);
            //kitty.Name = "키티";
            //kitty.Color = "하얀색";
            //kitty.Age = 3;
            kitty.Meow();

            /*Cat nero = new Cat
            {
                Name = "네로",
                Color = "하얀색",
                Age = 3
            };
            nero.Meow();*/

            Cat nero = new Cat("네로", "하얀색", 3);

            Cat mimi = new Cat("미미","노랑",3);
            mimi.Meow();

            Cat noname = new Cat("야옹이","은색", 10);
            //noname.Name = "야옹이";
            noname.Meow();
            noname.Sleep();

            var list = (First:"Cat", Second:"Dog", Third:"Pig",55);
            Console.Write($"튜플 첫번째 : {list.First}");
            Console.Write($"튜플 두번째 : {list.Second}");
            Console.Write($"튜플 세번째 : {list.Third}");
            Console.Write($"튜플 네번째 : {list.Item4}");

        }
    }
}
