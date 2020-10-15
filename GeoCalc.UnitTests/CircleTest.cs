using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Dorner Christof 4CHIF
namespace GeoCalc.UnitTests
{
    [TestClass]
    public class CircleTest
    {
        Circle circle;

        [TestInitialize]
        public void setup()
        {
            circle = new Circle("Circle", new Point(0, 0), new Point(0, 10));
        }

        [TestMethod]
        public void getArea_ReturnsCorrectValue()
        {
            Assert.AreEqual(314, circle.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(62, circle.GetCircumference());
        }

        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Circle 314 62", circle.Println());
        }
    }
}
