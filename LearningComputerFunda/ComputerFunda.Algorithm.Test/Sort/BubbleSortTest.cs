﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.Algorithm.Sort;
using Prime = ComputerFunda.ProgrammingProblem.Math.MathProblems;
using System.Collections.Generic;

namespace ComputerFunda.Algorithm.Test.Sort
{
    [TestCategory("SortingAlgorithm")]
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void Sort_BubbleSort_Test()
        {
            int[] arr = new int[] { 1, 4, 2, 3, 5, 6 };

            BubbleSort sort = new BubbleSort();

            int[] accual = sort.Sort(arr);

            int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };

            CollectionAssert.AreEqual(expected, accual);
        }

        [TestMethod]
        public void Sort_BubbleSortDesc_Test()
        {
            int[] arr = new int[] { 3, 4, 2, 1, 5, 6 };

            BubbleSort sort = new BubbleSort();

            int[] accual = sort.SortDesc(arr);

            int[] expected = new int[] { 6, 5, 4, 3, 2, 1 };

            CollectionAssert.AreEqual(expected, accual);
        }

        [TestMethod]
        public void Sort_BubbleSortDesc_WhenArraySizeBig_Test()
        {
            var primeNumbers = Prime.PrimeNumber(200000);

            int[] arr = primeNumbers.ToArray();

            BubbleSort sort = new BubbleSort();

            int[] accual = sort.SortDesc(arr);

            primeNumbers.Reverse();

            var expected = primeNumbers.ToArray();

            CollectionAssert.AreEqual(expected, accual);
        }
    }
}
