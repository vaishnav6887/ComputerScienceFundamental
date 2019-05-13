using ComputerFunda.Common;
using ComputerFunda.DataStructure.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.LinkedList
{
    [TestCategory("LinkedList")]
    [TestClass]
    public class DetectLoop
    {
        [TestMethod]
        [Ignore]
        ///Need to fix the logic of finding the start point of loop in linkedList with out using extra space. using runner technique
        public void FindLoopStartPoint_Positive_Test()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();
            lnkLst.Add(-1);
            lnkLst.Add(-7);
            lnkLst.Add(7);
            lnkLst.Add(-4);
            lnkLst.Add(19);
            lnkLst.Add(6);
            lnkLst.Add(-9);
            lnkLst.Add(-5);
            lnkLst.Add(2);
            lnkLst.Add(-5);

            lnkLst._current.Next = lnkLst._head.Next.Next.Next.Next.Next.Next;

            DSNode<int> expected = lnkLst._head.Next.Next.Next.Next.Next.Next;

            IntDSNodeEqualityComparer intDSNodeEqualityComparer = new IntDSNodeEqualityComparer();

            DSNode<int> actual = lnkLst.FindLoopStartPoint();

            Assert.IsNotNull(actual);

            Assert.AreEqual(expected, actual);
        }
    }
}
