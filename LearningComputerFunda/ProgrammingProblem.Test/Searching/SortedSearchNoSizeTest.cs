using System;
using ComputerFunda.ProgrammingProblem.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Searching
{
    [TestCategory("Searching")]
    [TestClass]
    public class SortedSearchNoSizeTest
    {
        [TestMethod]
        public void SortedSearchWithNoSize_Test()
        {
            int[] input = new int[12] { 1, 3, 4, 5, 7, 10, 14, 15, 16, 19, 20, 25 };

            SortedSearchNoSize obj = new SortedSearchNoSize(input);

            int actual = obj.Search(20);

            int expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortedSearchWithNoSize_Test_Negative()
        {
            int[] input = new int[12] { 1, 3, 4, 5, 7, 10, 14, 15, 16, 19, 200, 250 };

            SortedSearchNoSize obj = new SortedSearchNoSize(input);

            int actual = obj.Search(245);

            int expected = -1;

            Assert.AreEqual(expected, actual);
        }
    }
}
