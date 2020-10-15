using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoCalc;
//Dorner Christof 4CHIF
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
            Assert.AreEqual(314, cylinder.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(62, cylinder.GetCircumference());
        }

        [TestMethod]
        public void GetVolumenReturnsCorrectValue()
        {
            Assert.AreEqual(3140, cylinder.GetVolume());

        }

        [TestMethod]
        public void GetSurfaceAreaReturnsCorrectValue()
        {
            Assert.AreEqual(1248, cylinder.GetSurfaceArea());

        }


        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Cylinder 314 62 3140 1248", cylinder.Println());
        }
    }
}
