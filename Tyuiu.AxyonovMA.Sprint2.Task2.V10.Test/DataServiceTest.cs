using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task2.V10.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea_InShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;
            bool result = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_NotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            bool result = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea_BorderCase()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;
            bool result = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, result);
        }
    }
}