using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ComputerFunda.ProgrammingProblem.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Sorting
{
    [TestCategory("Sorting")]
    [TestClass]
    public class SortingLoadTest
    {
        [TestMethod]
        public void HighData_Test()
        {
            int Min = 0;
            int Max = 20000;
            Random randNum = new Random();
            int[] input = Enumerable
                .Repeat(Min, Max)
                .Select(i => randNum.Next(Min, Max)).OrderByDescending(s => s).Distinct()
                .ToArray();

            ISort bubbleSort = new BubbleSort(input);
            ISort heapSort = new HeapSort(input);
            ISort insertionSort = new InsertionSort(input);
            ISort quickSort = new QuickSort(input);
            ISort selectionSort = new SelectionSort(input);

            Stopwatch timer = new Stopwatch();
            timer.Start();
            var bubble = new int[input.Length];
            var heap = new int[input.Length];
            var insertion = new int[input.Length];
            var quick = new int[input.Length];
            var selection = new int[input.Length];

            Parallel.Invoke(() => bubble = bubbleSort.Sort(), 
                            () => heap = heapSort.Sort(),
                            () => insertion = insertionSort.Sort(),
                            () => quick = quickSort.Sort(),
                            () => selection = selectionSort.Sort());
            timer.Stop();

            CollectionAssert.AreEqual(bubble, insertion);
            CollectionAssert.AreEqual(quick, insertion);
            CollectionAssert.AreEqual(selection, quick);
            CollectionAssert.AreEqual(bubble, selection);
        }
    }
}
