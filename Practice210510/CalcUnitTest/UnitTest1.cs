using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace CalcUnitTest
{
    [TestClass] //테스트 클래스
    public class UnitTest1
    {
        [TestMethod] //테스트 메서드
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3, b = 5;
            var result = myClass.Plus(a,b);

            Assert.AreEqual(8, result); // 테스트 결과 보기
        }


    }
}
