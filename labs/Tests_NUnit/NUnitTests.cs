using NUnit.Framework;
using lab_22_first_test;
using snap_lab_04_Exam;
using tests;
using System.Threading;

namespace Tests
{
    public class NUnitTests
    {
        // initialise pause variable
        static ManualResetEvent pause = new ManualResetEvent(false);

        [SetUp]
        public void Setup()
        {

        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(10, 15, 20, 3000)]
        public void CubicNumbersTest(int x, int y, int z, int expected)
        {
            // arrange
            //expected = 1000;
            var instance = new LabWork();
            // act
            var actual = instance.CubeNumbers(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(10, 15, 20, 3000)]
        public void CubicNumbersStaticTest(int x, int y, int z, int expected)
        {
            var actual = LabWork.CubeNumbersStatic(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 6)]
        public void GetLengthOfArrayTest(int[] array, int expected)
        {
            var actual = LabWork.GetLengthOfArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 36)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 55)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 21)]
        public void ReturnSumOfArray(int[] array, int expected)
        {
            var actual = LabWork.SumTotalOfArrayMembers(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 2, 16)]
        [TestCase(3, 5, 2, 225)]
        [TestCase(10, 2, 3, 8000)]
        public void MultiplicationAndFactors(double x, double y, double n, double expected)
        {
            var actual = LabWork.MultiplicationAndFactors(x, y, n);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 12, 49, 3 }, new int[] { 3, 12, 49 })]
        [TestCase(new int[] { 8, 1, 200 }, new int[] { 1, 8, 200 })]
        public void ArrayToSort(int[] array, int[] expectedArray)
        {
            var actualArray = LabWork.SortArray(array);
            Assert.AreEqual(expectedArray, actualArray);
        }

        /*
        Cat Cat01 = new Cat(10, "cat01");
        Cat Cat02 = new Cat(7, "cat02");
        Cat Cat03 = new Cat(13, "cat03");
        static Cat[] catArray = new Cat[{Cat01, Cat02, Cat03}]

        [TestCase(new Cat[] { Cat01, Cat02, Cat03 })]
        public void Test()
        {
            var c01 = new Cat(10, "Cat01");
            var c02 = new Cat(7, "Cat01");
            var c03 = new Cat(13, "Cat01");
            Cat[] cats = new Cat[3];
        }
        */

        [TestCase(10,15,1,5)]
        [TestCase(4,9,4,2)]
        [TestCase(4,10,2,3)]
        public void TestForDivisor(int num1, int num2, int divisor, int expected)
        {
            var actual = Eng35Tests.How_Many_Numbers_Divisible_By(num1, num2, divisor);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 20, 30 , 40 }, 1012)]
        [TestCase(new int[] { 3, 3, 3 , 3 }, 132)]
        [TestCase(new int[] { 1, 10, 100 , 1000 }, 11122)]
        public void Array_Loop_Queue_Stack_Test(int[] array, int expected)
        {
            var actual = Eng35Tests.Array_Loop_Queue_Static(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(4, 16)]
        [TestCase(5, 32)]
        //[TestCase(10000, 10)]
        public void RabbitExplosionTest(int seconds, int expected)
        {
            var actual = Eng35Tests.RabbitExplosion(seconds);
            Assert.AreEqual(expected, actual);
        }
    }
}