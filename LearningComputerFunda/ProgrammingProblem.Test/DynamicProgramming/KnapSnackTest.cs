using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.ProgrammingProblem.DynamicProgramming;
using System.Collections.Generic;

namespace ProgrammingProblem.Test.DynamicProgramming
{
    [TestClass]
    public class KnapSnackTest
    {
        [TestCategory("DynamicProgramming")]
        [TestMethod]
        public void Test_KnapSnack_Calculate()
        {
            List<int> weights = new List<int>() { 2, 3, 1, 4 };
            List<int> profits = new List<int>() { 4, 5, 3, 7 };
            int capacity = 5;

            KnapSnack obj = new KnapSnack(weights, profits, capacity);
            obj.Calculate(capacity);
            int expected = 10;

            Assert.AreEqual(expected, obj._maxProfit);
        }
    }
}
