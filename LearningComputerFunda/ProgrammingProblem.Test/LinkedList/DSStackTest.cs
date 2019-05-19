using ComputerFunda.DataStructure.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.LinkedList
{
    [TestCategory("Stack")]
    [TestClass]
    public class DSStackTest
    {
        [TestMethod]
        public void Push_Pop_Stack_Test()
        {
            DSStack<int> stack = new DSStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            stack.Pop();

            Assert.AreEqual(5, stack.Head.Data);

            Assert.IsNull(stack.Head.Prev);

            Assert.IsNotNull(stack.Head.Next);

            Assert.IsNotNull(stack.Head.Next.Next);

            Assert.IsNotNull(stack.Head.Next.Next.Next);

            Assert.IsNotNull(stack.Head.Next.Next.Next.Next);

            Assert.IsNull(stack.Head.Next.Next.Next.Next.Next);
        }
    }
}
