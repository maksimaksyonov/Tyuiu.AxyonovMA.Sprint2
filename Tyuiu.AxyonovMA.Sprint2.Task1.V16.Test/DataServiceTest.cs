using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task1.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;
            bool[] result = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { true, true, true, false, true, false };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}