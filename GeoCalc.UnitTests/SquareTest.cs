using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
//Dorner Christof 4CHIF
namespace GeoCalc.UnitTests
{

    [TestClass]
    public class SquareTest
    {

        Square square;

        [TestInitialize]
        public void setup()
        {
            square = new Square("Square", new Point(0, 0), new Point(0, 10));
        }

        [TestMethod]
        public void getArea_ReturnsCorrectValue()
        {
            Assert.AreEqual(100, square.GetArea());
        }

        [TestMethod]
        public void getCircumference_ReturnsCorrectValue()
        {
            Assert.AreEqual(40, square.GetCircumference());
        }

        [TestMethod]
        public void PrintLnReturnsCorrectValue()
        {
            Assert.AreEqual("Square 100 40" , square.Println());
        }
    }
}
