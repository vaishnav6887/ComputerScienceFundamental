using System;
using ComputerFunda.DataStructure.Heap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Heap
{
    [TestCategory("Heap")]
    [TestClass]
    public class MinHeapTest
    {
        [TestMethod]
        public void MinHeap_Test()
        {
            MinHeap minHeap = new MinHeap(7);
            minHeap.Add(3);
            minHeap.Add(6);
            minHeap.Add(5);
            minHeap.Add(9);
            minHeap.Add(8);
            minHeap.Add(1);

            int actual = minHeap.Remove();

            int expected = 1;

            Assert.AreEqual(actual, expected);

            actual = minHeap.Remove();

            expected = 3;

            Assert.AreEqual(actual, expected);
        }
    }
}
