using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Number13T
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //Важно писать эту строчку перед каждым методом
        public void TestMethod1()
        {
            double val = Number13.Program.Mul(2, 2);//Обращение к Task13Console и вызов метода

            Assert.AreEqual(4, val); //Проверка умножения
        }

        [TestMethod]
        public void TestMethod2()
        {
            double val = Number13.Program.Mul(2.1, 2.3);

            Assert.AreEqual(4.83, val);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double val = Number13.Program.Mul(0, 100);

            Assert.AreEqual(0, val);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double val = Number13.Program.Mul(-2, 1.5);

            Assert.AreEqual(-3, val);
        }

        [TestMethod]
        public void TestMethod5()
        {
            double val = Number13.Program.Mul(-1, -1);

            Assert.AreEqual(1, val);
        }
    }
}
