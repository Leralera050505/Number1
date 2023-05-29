using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Number17T
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string text = "abc-абв.¿¡";
            int cost = 4;

            int res = Number17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string text = "‿︵‿ヽ(°□° )ノ︵‿︵";
            int cost = 14;

            int res = Number17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string text = "ʕ ᵔᴥᵔ ʔ";
            int cost = 7;

            int res = Number17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string text = "(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧";
            int cost = 12;

            int res = Number17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string text = "ଲ(ⓛ ω ⓛ)ଲ";
            int cost = 9;

            int res = Number17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
    }
}
