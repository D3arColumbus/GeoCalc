using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoCalc;

namespace GeoCalc.UnitTests
{
    [TestClass]
    public class CubeTest
    {
        Cube cube;

        [TestInitialize]
        public void setup()
        {
            cube = new Cube("Cube", new Square("Square", new Point(0, 0), new Point(0, 10)), 10);
        }

        [TestMethod]
        public void getArea_ReturnsCorrectValue()
        {
            Assert.AreEqual(100, cube.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(40, cube.GetCircumference());
        }

        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Cube 100 40", cube.Println());
        }

        [TestMethod]
        public void GetVolumenReturnsCorrectValue()
        {
            Assert.AreEqual(1000, cube.GetVolume());
        }

        [TestMethod]
        public void GetSurfaceAreaReturnsCorrectValue()
        {
            Assert.AreEqual(600, cube.GetSurfaceArea());
        }
    }

}
