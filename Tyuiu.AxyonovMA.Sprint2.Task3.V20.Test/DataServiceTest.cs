using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task3.V20.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_XGreaterThanOne()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double result = ds.Calculate(x);
            double wait = 2.0 * Math.Pow(3.0 / 1.0, 2.0);
            Assert.AreEqual(Math.Round(wait, 3), result);
        }

        [TestMethod]
        public void ValidCalculate_XEqualToZero()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double result = ds.Calculate(x);
            double numerator = 0 - Math.Cos(0) + 10;
            double denominator = 0 - Math.Sin(0) + 12;
            double wait = numerator / denominator;
            Assert.AreEqual(Math.Round(wait, 3), result);
        }

        [TestMethod]
        public void ValidCalculate_XBetweenMinus24AndOne()
        {
            DataService ds = new DataService();
            double x = -10.0;
            double result = ds.Calculate(x);
            double wait = Math.Pow(1 + 1 / Math.Pow(-10, 2), -10);
            Assert.AreEqual(Math.Round(wait, 3), result);
        }

        [TestMethod]
        public void ValidCalculate_XLessThanMinus24()
        {
            DataService ds = new DataService();
            double x = -30.0;
            double result = ds.Calculate(x);
            double wait = -30 + 10 * (-30) - (1 / -30);
            Assert.AreEqual(Math.Round(wait, 3), result);
        }
    }
}