using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task4.V11.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_ConditionTrue()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 50.0;
            double result = ds.Calculate(x, y);
            // x*20*2 = 40, y+4 = 54 → 40 < 54 → true
            double wait = Math.Pow(3 + 8 / Math.Pow(1, 2), 50);
            Assert.AreEqual(Math.Round(wait, 3), result);
        }

        [TestMethod]
        public void ValidCalculate_ConditionFalse()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            double result = ds.Calculate(x, y);
            // x*20*2 = 80, y+4 = 5 → 80 < 5 → false
            double wait = 1 - Math.Pow((2 + 1) / (1 + 2), 2);
            Assert.AreEqual(Math.Round(wait, 3), result);
        }

        [TestMethod]
        public void ValidCalculate_BorderCase()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 36.0;
            double result = ds.Calculate(x, y);
            // x*20*2 = 40, y+4 = 40 → 40 < 40 → false
            double wait = 36 - Math.Pow((1 + 1) / (36 + 2), 1);
            Assert.AreEqual(Math.Round(wait, 3), result);
        }
    }
}