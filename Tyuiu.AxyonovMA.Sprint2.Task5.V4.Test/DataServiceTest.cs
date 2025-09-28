using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint2.Task5.V4.Lib;

namespace Tyuiu.AxyonovMA.Sprint2.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod] public void Suit1() { Assert.AreEqual("пики", new DataService().FindCardSuit(1)); }
        [TestMethod] public void Suit2() { Assert.AreEqual("трефы", new DataService().FindCardSuit(2)); }
        [TestMethod] public void Suit3() { Assert.AreEqual("бубны", new DataService().FindCardSuit(3)); }
        [TestMethod] public void Suit4() { Assert.AreEqual("червы", new DataService().FindCardSuit(4)); }
        [TestMethod] public void SuitInvalid() { Assert.AreEqual("неизвестно", new DataService().FindCardSuit(0)); }
    }
}
