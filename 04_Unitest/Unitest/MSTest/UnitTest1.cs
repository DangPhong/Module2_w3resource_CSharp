using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unitest.Calculator;
namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator cal = new Calculator();
        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(cal.Add(1, 1) == 2);
            Assert.IsTrue(cal.Add(2, 2) == 4);
            Assert.IsTrue(cal.Add(2, 'a') == 99);
            Assert.AreEqual(20, cal.Add(10,10));
        }

        [TestMethod]
        public void SubTest()
        {
            Assert.AreEqual(3, cal.Subtract(6, 3));
        }


    }
}
