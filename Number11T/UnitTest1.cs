using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Number_11;

namespace Number11T
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double num1 = 1;
            double num2 = 2;
            double sum = 3;

            double res = MyMath.MySum(num1, num2);

            Assert.AreEqual(sum, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double num1 = -1;
            double num2 = 2;
            double sum = 1;

            double res = MyMath.MySum(num1, num2);

            Assert.AreEqual(sum, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double num1 = 1;
            double num2 = -2.2;
            double sum = -1.2;

            double res = MyMath.MySum(num1, num2);

            Assert.AreEqual(sum, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double num1 = -1;
            double num2 = -2;
            double sum = -3;

            double res = MyMath.MySum(num1, num2);

            Assert.AreEqual(sum, res);
        }
        [TestMethod]
        public void TestMethod5()
        {
            double num1 = 1.11;
            double num2 = 2.05;
            double sum = 3.16;

            double res = MyMath.MySum(num1, num2);

            Assert.AreEqual(sum, res);
        }
    }
}
