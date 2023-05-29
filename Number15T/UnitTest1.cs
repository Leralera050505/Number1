using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Number15T
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string word = "Hello!";
            int countLitters = Number15.Litter.CountLitters(word);
            Assert.AreEqual(6, countLitters);
        }


        [TestMethod]
        public void TestMethod2()
        {
            string word = "Hello !";
            int countLitters = Number15.Litter.CountLitters(word);
            Assert.AreEqual(6, countLitters);
        }


        [TestMethod]
        public void TestMethod3()
        {
            string word = "H e l l o !";
            int countLitters = Number15.Litter.CountLitters(word);
            Assert.AreEqual(6, countLitters);
        }



        [TestMethod]
        public void TestMethod4()
        {
            string word = "";
            int countLitters = Number15.Litter.CountLitters(word);
            Assert.AreEqual(0, countLitters);
        }



        [TestMethod]
        public void TestMethod5()
        {
            double word = Double.MaxValue;
            int countLitters = Number15.Litter.CountLitters(word.ToString());
            Assert.AreEqual(Double.MaxValue.ToString().Length, countLitters);
        }
    }
}
