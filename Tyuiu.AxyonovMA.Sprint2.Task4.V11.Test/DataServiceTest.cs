using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task4.V11.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Returns_92_205_For_9_4()
        {
            var ds = new DataService();
            double actual = ds.Calculate(9, 4);
            Assert.AreEqual(92.205, actual);
        }
    }
}
