using System;

namespace Practice210506
{
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA() 실행!");
            PrivateMethodA();
        }
    }
}
