using System;
using System.Collections.Generic;
using ComputerFunda.ProgrammingProblem.BackTracking;
using ComputerFunda.ProgrammingProblem.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.BackTracking
{
    [TestClass]
    public class CombinationSumTest
    {
        [TestMethod]
        [TestCategory("BackTracking")]
        public void FindCombinationSum_Test()
        {
            int[] arr = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            ISort sort = new QuickSort();
            CombinationSum obj = new CombinationSum(arr, sort);
            var actual = obj.FindCombinationSum(8);
            List<int[]> expected = new List<int[]>()
            {
                new int[] { 1, 7 },
                new int[] { 1, 2, 5 },
                new int[] { 2, 6 },
                new int[] { 1, 1, 6 }
            };
        }
    }
}
