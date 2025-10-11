using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task7.V13.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LeftSemicirclePoint_IsTrue()
        {
            var ds = new DataService();
            Assert.IsTrue(ds.IsInShadedArea(-0.5, 0.0));   // слева, внутри круга
        }

        [TestMethod]
        public void RightPartAboveLine_IsTrue()
        {
            var ds = new DataService();
            Assert.IsTrue(ds.IsInShadedArea(0.5, 0.5));    // внутри круга, y >= x-1
        }

        [TestMethod]
        public void RightPartBelowLine_IsFalse()
        {
            var ds = new DataService();
            Assert.IsFalse(ds.IsInShadedArea(0.8, -0.3));  // внутри круга, но y < x-1
        }

        [TestMethod]
        public void OutsideCircle_IsFalse()
        {
            var ds = new DataService();
            Assert.IsFalse(ds.IsInShadedArea(0.5, -0.9));  // вне круга
        }
    }
}
