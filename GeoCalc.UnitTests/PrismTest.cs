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
            Assert.AreEqual(43, prism.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(30, prism.GetCircumference());
        }

        [TestMethod]
        public void GetVolumenReturnsCorrectValue()
        {
            Assert.AreEqual(430, prism.GetVolume());
        }

        [TestMethod]
        public void GetSurfaceAreaReturnsCorrectValue()
        {
            Assert.AreEqual(386, prism.GetSurfaceArea());
        }
   

    [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Prism 43 30", prism.Println());
        }
    }
}
