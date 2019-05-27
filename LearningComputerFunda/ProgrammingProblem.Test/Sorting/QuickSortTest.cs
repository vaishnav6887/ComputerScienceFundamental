using System;
using ComputerFunda.ProgrammingProblem.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Sorting
{
    [TestClass]
    [TestCategory("Sorting")]
    public class QuickSortTest
    {
        [TestMethod]
        public void QuickSort_Test_Positive()
        {
            int[] data = new int[10] { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };

            QuickSort obj = new QuickSort(data);

            int[] actual = obj.Sort();

            int[] expected = new int[10] { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            Assert.IsNotNull(actual);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
