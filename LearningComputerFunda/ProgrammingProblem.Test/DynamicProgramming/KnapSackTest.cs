using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.ProgrammingProblem.DynamicProgramming;
using System.Collections.Generic;

namespace ProgrammingProblem.Test.DynamicProgramming
{
    [TestClass]
    public class KnapSackTest
    {
        [TestCategory("DynamicProgramming")]
        [TestMethod]
        public void Test_KnapSnack_Calculate()
        {
            List<int> weights = new List<int>() { 2, 3, 1, 4 };
            List<int> profits = new List<int>() { 4, 5, 3, 7 };
            int capacity = 5;

            KnapSack obj = new KnapSack(weights, profits, capacity);
            obj.Calculate(capacity);
            int expected = 10;
            int numberOfIt = obj._numberOfIteration;
            Assert.AreEqual(expected, obj._maxProfit);
        }
    }
}
