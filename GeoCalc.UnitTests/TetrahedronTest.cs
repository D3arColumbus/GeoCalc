using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Dorner Christof 4CHIF
namespace GeoCalc.UnitTests
{
    [TestClass]
    public class TetrahedronTest
    {
        Tetrahedron tetrahedron;

        [TestInitialize]
        public void setup()
        {
            tetrahedron = new Tetrahedron("Tetrahedron", new Triangle("Square", new Point(0, 0), new Point(0, 10)), 10);
        }

        [TestMethod]
        public void getArea_ReturnsCorrectValue()
        {
            Assert.AreEqual(43, tetrahedron.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(30, tetrahedron.GetCircumference());
        }

        [TestMethod]
        public void GetVolumenReturnsCorrectValue()
        {
            Assert.AreEqual(130, tetrahedron.GetVolume());
        }

        [TestMethod]
        public void GetSurfaceAreaReturnsCorrectValue()
        {
            Assert.AreEqual(143, tetrahedron.GetSurfaceArea());
        }
  

    [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Tetrahedron 43 30 130 143", tetrahedron.Println());
        }
    }
}
