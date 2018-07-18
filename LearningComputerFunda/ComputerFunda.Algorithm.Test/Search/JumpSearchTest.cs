using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.Algorithm.Search;
using Prime = ComputerFunda.ProgrammingProblem.Math.MathProblems;
using System.Collections.Generic;

namespace ComputerFunda.Algorithm.Test.Search
{
    [TestClass]
    public class JumpSearchTest
    {
        [TestMethod]
        public void JumpSearch_Test_No_Match()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int itemToBeSearched = 11;

            Algorithm.Search.JumpSearch search = new Algorithm.Search.JumpSearch(input);

            int expectedIndex = -1;

            int actualIndex = search.Search(itemToBeSearched);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void BinarySearch_Test_Match_Found()
        {
            int[] input = Prime.PrimeNumber(1000).ToArray();

            int itemToBeSearched = 911;

            Algorithm.Search.JumpSearch search = new Algorithm.Search.JumpSearch(input);

            int expectedIndex = 155;

            int actualIndex = search.Search(itemToBeSearched);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
