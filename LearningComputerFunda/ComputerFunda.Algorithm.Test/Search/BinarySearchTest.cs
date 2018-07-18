using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.Algorithm.Search;
using Prime = ComputerFunda.ProgrammingProblem.Math.MathProblems;
using System.Collections.Generic;

namespace ComputerFunda.Algorithm.Test.Search
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void BinarySearch_Test_No_Match()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int itemToBeSearched = 11;

            Algorithm.Search.BinarySearch search = new Algorithm.Search.BinarySearch(input);

            int expectedIndex = -1;

            int actualIndex = search.Search(itemToBeSearched);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void BinarySearch_Test_Match_Found()
        {
            int[] input = Prime.PrimeNumber(100).ToArray();

            int itemToBeSearched = 11;

            Algorithm.Search.BinarySearch search = new Algorithm.Search.BinarySearch(input);

            int expectedIndex = 4;

            int actualIndex = search.Search(itemToBeSearched);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
