using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoCalc;

namespace GeoCalc.UnitTests
{
    [TestClass]
    public class CubeTest
    {
        Cylinder cube;

        [TestInitialize]
        public void setup()
        {
            cube = new Cylinder("Cube", new Square("Square", new Point(0, 0), new Point(0, 10)), 10);
        }

        [TestMethod]
        public void getArea_ReturnsCorrectValue()
        {
            Assert.AreEqual(1000, cube.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(40, cube.GetCircumference());
        }

        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Cube 1000 40", cube.Println());
        }
    }

}
