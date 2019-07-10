using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_22_first_test;

namespace tests_MSTest
{
    [TestClass]
    public class MSTests
    {
        [TestMethod]
        public void SumTotalOfArrayTest()
        {
            // range
            int[] myArray = { 10, 20, 30 };

            var tExpected = 60;
            var tActual = LabWork.SumTotalOfArrayMembers(myArray);

            Assert.AreEqual(tExpected, tActual);
        }
    }
}
