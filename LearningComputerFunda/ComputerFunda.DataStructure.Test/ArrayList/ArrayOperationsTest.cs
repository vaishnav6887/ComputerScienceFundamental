using ComputerFunda.DataStructure.ArrayList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerFunda.DataStructure.Test.ArrayList
{
    [TestClass]
    public class ArrayOperationsTest
    {
        [TestMethod]
        public void TestLeftRotation_RotationLessThanSize()
        {
            int[] intput = new int[] { 1, 2, 3, 4, 5 };
            int operations = 2;
            int[] expected = new int[] { 3, 4, 5, 1, 2 };
            int[] actual = ArrayOperations.LeftRotation(intput, operations);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestLeftRotation_SizeLessThanRotation()
        {
            int[] intput = new int[] { 1, 2, 3, 4, 5 };
            int operations = 6;
            int[] expected = new int[] { 2, 3, 4, 5, 1 };
            int[] actual = ArrayOperations.LeftRotation(intput, operations);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMinimumBribes_CorrectSwaps()
        {
            int[] intput = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };

            string expected = "7";
            string actual = ArrayOperations.MinimumBribes(intput);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMinimumBribes_WrongSwaps()
        {
            int[] intput = new int[] { 2, 5, 1, 3, 4 };

            string expected = "Too chaotic";
            string actual = ArrayOperations.MinimumBribes(intput);
            Assert.AreEqual(expected, actual);
        }
    }
}
