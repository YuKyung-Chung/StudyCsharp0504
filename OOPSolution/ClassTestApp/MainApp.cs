using System;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "하얀색";
            kitty.Age = 3;
            kitty.Meow();

            Cat nero = new Cat
            {
                Name = "네로",
                Color = "하얀색",
                Age = 3
            };
            nero.Meow();

            Cat mimi = new Cat("미미","노랑",3);
            mimi.Meow();
        }
    }
}
