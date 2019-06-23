using System;
using System.Diagnostics;
using System.Linq;
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

            QuickSort obj = new QuickSort();

            int[] actual = obj.Sort(data);

            int[] expected = new int[10] { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            Assert.IsNotNull(actual);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuickSort_Algo_Test()
        {
            int Min = 0;
            int Max = 200;
            Random randNum = new Random();
            int[] input = Enumerable
                .Repeat(Min, Max)
                .Select(i => randNum.Next(Min, Max)).OrderByDescending(s => s).Distinct()
                .ToArray();

            ISort sort = new QuickSort();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] actual = sort.Sort(input);
            timer.Stop();
            input = input.OrderBy(s => s).ToArray();

            Assert.IsNotNull(actual);

            CollectionAssert.AreEqual(input, actual);
        }
    }
}
