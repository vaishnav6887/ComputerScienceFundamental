using ComputerFunda.ProgrammingProblem.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblem.Test.Sorting
{
    [TestCategory("Sorting")]
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void BubbleSortTest_Positive()
        {
            int Min = 0;
            int Max = 20;
            Random randNum = new Random();
            int[] input = Enumerable
                .Repeat(Min, Max)
                .Select(i => randNum.Next(Min, Max)).OrderByDescending(s => s).Distinct()
                .ToArray();

            ISort sort = new BubbleSort(input);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] actual = sort.Sort();
            timer.Stop();
            input = input.OrderBy(s => s).ToArray();

            for (int expected = 0; expected < input.Length; expected++)
            {
                Assert.AreEqual(input[expected], actual[expected]);
            }
        }
    }
}
