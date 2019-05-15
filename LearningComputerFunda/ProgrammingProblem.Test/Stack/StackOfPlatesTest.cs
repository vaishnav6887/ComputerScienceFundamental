using ComputerFunda.ProgrammingProblem.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Stack
{
    [TestCategory("Stack")]
    [TestClass]
    public class StackOfPlatesTest
    {
        [TestMethod]
        public void Push_Test()
        {
            StackOfPlates stackOfPlates = new StackOfPlates(10);

            stackOfPlates.Push(1);
            stackOfPlates.Push(2);
            stackOfPlates.Push(3);
            stackOfPlates.Push(4);
            stackOfPlates.Push(5);
            stackOfPlates.Push(6);
            stackOfPlates.Push(7);
            stackOfPlates.Push(8);
            stackOfPlates.Push(9);
            stackOfPlates.Push(10);
            stackOfPlates.Push(11);

            Assert.AreEqual(2, stackOfPlates.HeadLength);
            Assert.AreEqual(11, stackOfPlates.Count);
        }

        [TestMethod]
        public void Pop_Test()
        {
            StackOfPlates stackOfPlates = new StackOfPlates(10);

            stackOfPlates.Push(1);
            stackOfPlates.Push(2);
            stackOfPlates.Push(3);
            stackOfPlates.Push(4);
            stackOfPlates.Push(5);
            stackOfPlates.Push(6);
            stackOfPlates.Push(7);
            stackOfPlates.Push(8);
            stackOfPlates.Push(9);
            stackOfPlates.Push(10);

            stackOfPlates.Push(11);

            for (int i = 11; i > 0; i--)
            {
                Assert.AreEqual(i, stackOfPlates.Pop());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void PopWithIndex_Test_Negative()
        {
            StackOfPlates stackOfPlates = new StackOfPlates(10);

            stackOfPlates.Push(1);
            stackOfPlates.Push(2);
            stackOfPlates.Push(3);
            stackOfPlates.Push(4);
            stackOfPlates.Push(5);
            stackOfPlates.Push(6);
            stackOfPlates.Push(7);
            stackOfPlates.Push(8);
            stackOfPlates.Push(9);
            stackOfPlates.Push(10);

            stackOfPlates.Push(11);

            int latestremoved = stackOfPlates.Pop(1);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);
            stackOfPlates.Pop(0);

            Assert.AreEqual(11, latestremoved);
        }

        [TestMethod]
        public void PopWithIndex_Test_Positive()
        {
            StackOfPlates stackOfPlates = new StackOfPlates(10);

            stackOfPlates.Push(1);
            stackOfPlates.Push(2);
            stackOfPlates.Push(3);
            stackOfPlates.Push(4);
            stackOfPlates.Push(5);
            stackOfPlates.Push(6);
            stackOfPlates.Push(7);
            stackOfPlates.Push(8);
            stackOfPlates.Push(9);
            stackOfPlates.Push(10);
            stackOfPlates.Push(11);

            int latestremoved = stackOfPlates.Pop(1);
            int latestremoved2 = stackOfPlates.Pop(0);

            Assert.AreEqual(11, latestremoved);
            Assert.AreEqual(10, latestremoved2);
        }
    }
}
