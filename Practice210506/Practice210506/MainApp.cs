using System;

namespace Practice210506
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.PublicMethodA();
            obj.AbstractMethodA();
        }
    }
}
