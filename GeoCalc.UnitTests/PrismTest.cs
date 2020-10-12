using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeoCalc.UnitTests
{
    [TestClass]
    public class PrismTest
    {
        Prism prism;

        [TestInitialize]
        public void setup()
        {
            prism = new Prism("Prism", new Triangle("Triangle", new Point(0, 0), new Point(0, 10)), 10);
        }

        [TestMethod]

        public void getArea_ReturnsCorrectValue()
        {
            Assert.AreEqual(430, prism.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(30, prism.GetCircumference());
        }

        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Prism 430 30", prism.Println());
        }
    }
}
