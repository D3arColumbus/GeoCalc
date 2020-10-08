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
    }
}
