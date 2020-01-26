using System;
using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.ProgrammingProblem.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.LinkedList
{
    [TestClass]
    public class SwapPairsTest
    {
        [TestCategory("LinkedList")]
        [TestMethod]
        public void SwapTest()
        {
            DSNode<int> head = new DSNode<int>();
            head.Data = 1;
            head.Next = new DSNode<int>()
            {
                Data = 2,
                Next = new DSNode<int>()
                {
                    Data = 3,
                    Next = new DSNode<int>()
                    {
                        Data = 4
                    }
                }
            };

            DSNode<int> expected = new DSNode<int>();
            expected.Data = 2;
            expected.Next = new DSNode<int>()
            {
                Data = 1,
                Next = new DSNode<int>()
                {
                    Data = 4,
                    Next = new DSNode<int>()
                    {
                        Data = 3
                    }
                }
            };

            SwapPairs pairs = new SwapPairs(head);

            DSNode<int> actual =  pairs.Swap();

            while(actual.Next != null && expected.Next != null)
            {
                Assert.AreEqual(actual.Data, expected.Data);
                actual = actual.Next;
                expected = expected.Next;
            }
        }
    }
}
