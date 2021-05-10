using System;

namespace DelegateChainApp
{
    class Program
    {
        delegate int Calculate(int a, int b); //계산 대리자를 선언
        static void Main(string[] args)
        {
            #region
            FireStation station = new FireStation();
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShoutOut);
            fireHouse += new ThereIsAFire(station.Escape);

            //대리자 실행
            fireHouse("우리집");
            Console.WriteLine();

            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);
            // 대리자 실행
            fireWoorim("우림라이온밸리");
            #endregion

            Calculate calc;
            //무명함수 표현1 = 일반식
            /*calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"a + b = {calc(3, 5)}");*/

            //무명함수 표현2 = 람다식
            calc = (a, b) => a + b;
            Console.WriteLine($"a + b ={calc(3, 5)}");


        }
    }
}
