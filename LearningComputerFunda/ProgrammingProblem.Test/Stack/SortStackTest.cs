using ComputerFunda.ProgrammingProblem.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Stack
{
    [TestCategory("Stack")]
    [TestClass]
    public class SortStackTest
    {
        [TestMethod]
        public void Sort_Stack_Test()
        {
            int[] arr = new int[] 
            {
                3,
                5,
                9,
                1,
                24
            };
            SortStack sortStack = new SortStack(arr);
            StackNode actual = sortStack.Sort();

            StackNode expected = new StackNode(1)
            {
                Next = new StackNode(3)
                {
                    Next = new StackNode(5)
                    {
                        Next = new StackNode(9)
                        {
                            Next = new StackNode(24)
                        }
                    }
                }
            };

            while (actual != null)
            {
                Assert.AreEqual(actual.Data, expected.Data);
                actual = actual.Next;
                expected = expected.Next;
            }
        }
    }
}
