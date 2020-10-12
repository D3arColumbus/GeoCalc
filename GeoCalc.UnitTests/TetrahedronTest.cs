using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.AreEqual(143, tetrahedron.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(30, tetrahedron.GetCircumference());
        }

        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Tetrahedron 143 30", tetrahedron.Println());
        }
    }
}
