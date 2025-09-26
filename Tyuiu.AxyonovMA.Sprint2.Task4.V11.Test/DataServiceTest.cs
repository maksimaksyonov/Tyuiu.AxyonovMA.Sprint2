using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task4.V11.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_IfBranch()
        {
            var ds = new DataService();
            // x=2, y=3 => condition true => (3 + 8/2)^3 = 7^3 = 343
            double actual = ds.Calculate(2, 3);
            Assert.AreEqual(343.000, actual, 0.0001);
        }

        [TestMethod]
        public void Calculate_ElseBranch()
        {
            var ds = new DataService();
            // x=3, y=-42 => condition false; y - ((x+1)/(y+2))^x
            // (4 / -40)^3 = (-0.1)^3 = -0.001;  -42 - (-0.001) = -41.999 => -41.999
            double actual = ds.Calculate(3, -42);
            Assert.AreEqual(-41.999, actual, 0.0001);
        }
    }
}
