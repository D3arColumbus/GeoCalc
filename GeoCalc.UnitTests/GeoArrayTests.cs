using GeoCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeoCalc.UnitTests
{
    [TestClass]
    public class GeoArrayTests
    {
        GeoArray array;

        [TestInitialize]
        public void Setup()
        {
            array = new GeoArray();
        }

        [TestMethod]
        public void CreatingNewArray_LengthIs10()
        {
            for(int i = 0; i < 10; i++)
                array[i] = new Circle("Cirlce", new Point(0, 0), new Point(10, 10));

        }





       


    }
}
