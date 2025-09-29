using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void NextDay_Normal()
        {
            var ds = new DataService();
            Assert.AreEqual("09.09.2023", ds.FindDateOfNextDay(2023, 9, 8));
        }

        [TestMethod]
        public void NextDay_EndOfMonth_31()
        {
            var ds = new DataService();
            Assert.AreEqual("01.02.2025", ds.FindDateOfNextDay(2025, 1, 31));
        }

        [TestMethod]
        public void NextDay_EndOfMonth_30()
        {
            var ds = new DataService();
            Assert.AreEqual("01.05.2025", ds.FindDateOfNextDay(2025, 4, 30));
        }

        [TestMethod]
        public void NextDay_February_NonLeap()
        {
            var ds = new DataService();
            Assert.AreEqual("01.03.2025", ds.FindDateOfNextDay(2025, 2, 28));
        }

        [TestMethod]
        public void NextDay_EndOfYear()
        {
            var ds = new DataService();
            Assert.AreEqual("01.01.2026", ds.FindDateOfNextDay(2025, 12, 31));
        }
    }
}
