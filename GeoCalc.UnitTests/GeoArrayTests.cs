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
            Assert.AreEqual(array.Length, 10);
        }

        [TestMethod]
        public void CreateNewArrayWithCostumeLength()
        {
            array = new GeoArray(20);
            Assert.AreEqual(array.Length, 20);
        }

       


    }
}
