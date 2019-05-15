using ComputerFunda.ProgrammingProblem.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Stack
{
    [TestCategory("Stack")]
    [TestClass]
    public class MaxStackTest
    {
        [TestMethod]
        public void MaxStack()
        {
            MaxStack node = new MaxStack();
            node.Push(1);
            node.Push(5);
            node.Push(2);

            node.Push(10);

            node.Pop();

            int actual = node.Max();
            int expected = 5;

            Assert.AreEqual(actual, expected);
        }
    }
}
