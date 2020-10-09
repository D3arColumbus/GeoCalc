using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeoCalc.UnitTests
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void Create2DPoint()
        {
            Point point = new Point(10, 10);
        }

        [TestMethod]
        public void Create3DPoint()
        {
            Point point = new Point(10, 10, 10);
        }

        [TestMethod]
        public void Create10DPoint()
        { 
            Point point = new Point(10, 10, 10, 7444444, 895222, 4444554, 45, 4545, 488445545, 879);
        }

        [TestMethod]
        public void SettingXandYCoordinates()
        {
            Point point = new Point(10, 10);
            point.set(20, 20);
        }

        [TestMethod]
        public void ValDReturnsValueOfDimensionD()
        {
            Point point = new Point(10, 20);
            Assert.AreEqual(10,point.GetVal(1));
        }

        [TestMethod]
        public void ValDThrowsExceptions_IfDimensionIsInvalid()
        {
            Point point = new Point(10, 20);
            try
            {
                Assert.AreEqual(10, point.GetVal(0));
            }
            catch
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void GetDistance_ReturnsCorrectDistanceBetweenTwoPoints()
        {
            Point point = new Point(10, 10);
            Assert.AreEqual(7, point.GetDistance(new Point(5, 5)));
        }

        [TestMethod]
        public void GetDistance_ThrowsExceptionIfTooManyOrFewDimensions()
        {
            Point point = new Point(10, 10,20,30);
            try
            {
                point.GetDistance(new Point(50, 60, 70, 80));
            }
            catch
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void GetDistance_ThrowsExceptionIfTheTwoPointsHaveDifferentDimensions()
        {
            Point point = new Point(10, 10, 20);
            try
            {
                point.GetDistance(new Point(50, 60, 70, 80));
            }
            catch
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsFalse(true);
        }
    }
}
