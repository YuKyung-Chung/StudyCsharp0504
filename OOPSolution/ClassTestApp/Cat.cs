using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat
    {
        public string Name { get; set; }
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
    }
}
