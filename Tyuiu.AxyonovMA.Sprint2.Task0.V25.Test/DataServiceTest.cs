using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task0.V25.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] result = ds.GetCompareOperations(x, y);
            bool[] wait = { true, true, true, false, false, false };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}