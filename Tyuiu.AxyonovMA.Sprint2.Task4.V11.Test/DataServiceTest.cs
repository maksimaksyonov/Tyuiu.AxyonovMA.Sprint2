using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task4.V11.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_IfBranch_Example_9_4()
        {
            var ds = new DataService();
            double actual = ds.Calculate(9, 4);
            Assert.AreEqual(228.719, actual);
        }

        [TestMethod]
        public void Calculate_IfBranch_Small_2_3()
        {
            var ds = new DataService();
            double actual = ds.Calculate(2, 3); // (3 + 8/2)^3 = 7^3
            Assert.AreEqual(343.000, actual);
        }

        [TestMethod]
        public void Calculate_ElseBranch_NegativeY()
        {
            var ds = new DataService();
            double actual = ds.Calculate(3, -42); // else-ветка
            Assert.AreEqual(-41.999, actual);
        }
    }
}
