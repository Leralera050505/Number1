using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Number14;

namespace Number14T
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            double num1 = 1;
            double num2 = 2;
            double num3 = 3;
            double correct = 3;

            double res = MySearch.MyMax(num1, num2, num3);

            Assert.AreEqual(correct, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double num1 = 1;
            double num2 = -2;
            double num3 = 3;
            double correct = 3;

            double res = MySearch.MyMax(num1, num2, num3);

            Assert.AreEqual(correct, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double num1 = 1.4;
            double num2 = -2;
            double num3 = -3;
            double correct = 1.4;

            double res = MySearch.MyMax(num1, num2, num3);

            Assert.AreEqual(correct, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double num1 = -1;
            double num2 = -2;
            double num3 = -3;
            double correct = -1;

            double res = MySearch.MyMax(num1, num2, num3);

            Assert.AreEqual(correct, res);
        }
        [TestMethod]
        public void TestMethod5()
        {
            double num1 = 1.12;
            double num2 = 2.22;
            double num3 = -3;
            double correct = 2.22;

            double res = MySearch.MyMax(num1, num2, num3);

            Assert.AreEqual(correct, res);
        }
    }
}
