using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.Algorithm.Search;
using Prime =  ComputerFunda.ProgrammingProblem.Math.MathProblems;
using System.Collections.Generic;

namespace ComputerFunda.Algorithm.Test.Search
{
    [TestClass]
    public class LinearSearchTest
    {
        [TestMethod]
        public void LinearSearch_Test_No_Match()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15, 10 };

            int itemToBeSearched = 30;

            Algorithm.Search.LinearSearch search = new Algorithm.Search.LinearSearch(input);
            
            int expectedIndex = -1;

            int actualIndex = search.Search(itemToBeSearched);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void LinearSearch_Test_Match()
        {
            int[] input = Prime.PrimeNumber(100).ToArray();

            int itemToBeSearched = 97;

            Algorithm.Search.LinearSearch search = new Algorithm.Search.LinearSearch(input);

            int expectedIndex = 24;

            int actualIndex = search.Search(itemToBeSearched);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
