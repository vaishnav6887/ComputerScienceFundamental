using ComputerFunda.Algorithm.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Algorithm.Test.Sort
{
    [TestClass]
    public class SelectionSortTest
    {
        [TestMethod]
        public void Sort_SelectionSort_Test()
        {
            int[] data = new int[] { 64, 25, 12, 22, 11 };

            SelectionSort sort = new SelectionSort();

            int[] actual = sort.Sort(data);

            int[] expected = new int[] { 11, 12, 22, 25, 64 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_SelectionSortDesc_Test()
        {
            int[] data = new int[] { 64, 25, 12, 22, 11 };

            SelectionSort sort = new SelectionSort();

            int[] actual = sort.SortDesc(data);

            int[] expected = new int[] { 64, 25, 22, 12, 11 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
