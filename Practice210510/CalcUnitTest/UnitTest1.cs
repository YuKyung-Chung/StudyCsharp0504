using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace CalcUnitTest
{
    [TestClass] //�׽�Ʈ Ŭ����
    public class UnitTest1
    {
        [TestMethod] //�׽�Ʈ �޼���
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3, b = 5;
            var result = myClass.Plus(a,b);

            Assert.AreEqual(8, result); // �׽�Ʈ ��� ����
        }


    }
}
