namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        private string name;
        //color도 생략 (시간절약)

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0) { this.age = 1; }
                else if (value > 15) { this.age = 15; }
                else { this.age = value; }
            }
        }

        /*public string Name
         {
             get
             {
                 return this.name;
             }
             set
             {
                 this.name = value;
             }
         }*/

        public string Name { get; set; } = "멍멍이"; //초기값 설정
        public string Color { get; set; } = "누런"; //초기값 설정
        public string GetName() { return this.name; }

        public void SetName(string name) { this.name=name; }

        //값을 사용
        public int GetAge() { return this.age; }
        //public string GetAge() {return $"{this.age}세";}

        //값을 설정
        public void SetAge(int age)
        {
            if (age < 0)
            {
                this.age = 1;
            }
            else if (age>15)
            {
                this.age = 15;
            }
            else
            {
                this.age = age;
            }
        }


    }
}
