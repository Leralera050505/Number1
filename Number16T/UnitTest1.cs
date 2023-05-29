using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Number16T
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "1234567890";

            int test = Number16.Program.Nums(s);

            Assert.AreEqual(10, test);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string s = "Сатана666Бафомет13";

            int test = Number16.Program.Nums(s);

            Assert.AreEqual(5, test);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string s = "-2=(1)ЪХ{}3>4  </?";

            int test = Number16.Program.Nums(s);

            Assert.AreEqual(4, test);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string s = "ЦифарНету";

            int test = Number16.Program.Nums(s);

            Assert.AreEqual(0, test);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string s = "-1.5.3.5  4 54657-1";

            int test = Number16.Program.Nums(s);

            Assert.AreEqual(11, test);
        }
    }
}
