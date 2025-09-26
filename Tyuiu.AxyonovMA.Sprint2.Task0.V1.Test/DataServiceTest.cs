using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task0.V1.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 233;
            int y = 122;
            bool[] result = ds.GetCompareOperations(x, y);
            bool[] wait = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}