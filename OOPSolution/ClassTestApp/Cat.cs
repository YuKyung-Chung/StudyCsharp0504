using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        //public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        //public void Meow() { Console.WriteLine("{0}, 야옹!", this.Name); }
        public void Meow() { Console.WriteLine($"{this.Name}, 야옹!"); }

        public Cat() { /*Nothing*/} // 기본 생성자
        public Cat(string name, string color, int age) // 추가 생성자
        {
            //Initialization 초기화
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public Cat(string name, string color) // 추가 생성자2
        {
            this.Name = name;
            this.Color = color;
        }
        public Cat(string name, int age) // 추가 생성자2
        {
            this.Name = name;
            this.Age = age;
        }
        public override void Sleep() //virtual 추가해야 override 할 수 있음
        {
            base.Sleep(); //base는 부모(Animal)을 뜻함. 부모의 Sleep() 실행
                          //이후 자식 클래스의 Sleep 실행. this는 자신의 클래스를 뜻함.
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) 잡니다!");
        }
    }
}
