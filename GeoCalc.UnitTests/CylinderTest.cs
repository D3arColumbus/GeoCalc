using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoCalc;

namespace GeoCalc.UnitTests
{
    [TestClass]
    public class CylinderTest
    {
        Cylinder cylinder;

        [TestInitialize]
        public void setup()
        {
            cylinder = new Cylinder("Cylinder", new Circle("Circle", new Point(0, 0), new Point(0, 10)), 10);
        }

        [TestMethod]
        public void getArea_ReturnsCorrectValue()
        {
            Assert.AreEqual(3140, cylinder.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(62, cylinder.GetCircumference());
        }

        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Cylinder 3140 62", cylinder.Println());
        }
    }

}
