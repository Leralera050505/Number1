using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Number12T
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] arr = new double[5] { 16, 243, 34, 85, 56 };  //Тестовый массив

            double res = Number12.Arr.MaxFromArr(arr); //Обращение к Task12Console

            Assert.AreEqual(243, res); //Проверка самого большого числа о котором мы знаем (243) с результатом метода MaxFromArr(arr)
        }


        [TestMethod]
        public void TestMethod2()
        {
            double[] arr = new double[5] { 16, 2, 34, 556.6, 566.7 };

            double res = Number12.Arr.MaxFromArr(arr);

            Assert.AreEqual(566.7, res);
        }



        [TestMethod]
        public void TestMethod3()
        {
            double[] arr = new double[5] { 16, 2, 34, 85, Double.MaxValue };

            double res = Number12.Arr.MaxFromArr(arr);

            Assert.AreEqual(Double.MaxValue, res);
        }


        [TestMethod]
        public void TestMethod4()
        {
            double[] arr = new double[5] { 16, 2, 34, 85, -34 };

            double res = Number12.Arr.MaxFromArr(arr);

            Assert.AreEqual(85, res);
        }


        [TestMethod]
        public void TestMethod5()
        {
            double[] arr = new double[0];

            double res = Number12.Arr.MaxFromArr(arr);

            Assert.AreEqual(0, res);
        }
    }
}
