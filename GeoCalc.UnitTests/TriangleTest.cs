using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Dorner Christof 4CHIF
namespace GeoCalc.UnitTests
{
    [TestClass]
    public class TriangleTest
    {
        Triangle triangle;

        [TestInitialize]
        public void setup()
        {
            triangle = new Triangle("Triangle", new Point(0, 0), new Point(0, 10));
        }

        [TestMethod]
        public void getArea_ReturnsCorrectValue()
        {
            Assert.AreEqual(43, triangle.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(30, triangle.GetCircumference());
        }

        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Triangle 43 30", triangle.Println());
        }
    }
}
