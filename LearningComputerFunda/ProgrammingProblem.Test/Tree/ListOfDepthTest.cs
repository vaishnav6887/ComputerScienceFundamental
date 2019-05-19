using System;
using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.DataStructure.Tree;
using ComputerFunda.ProgrammingProblem.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Tree
{
    [TestClass]
    [TestCategory("BinaryTree")]
    public class ListOfDepthTest
    {
        [TestMethod]
        public void Iterator_Test()
        {
            DSTreeNode<int> dSTreeNode = new DSTreeNode<int>(1);
            dSTreeNode.Left = new DSTreeNode<int>(2)
            {
                Right = new DSTreeNode<int>(5),
                Left = new DSTreeNode<int>(4)
            };

            dSTreeNode.Right = new DSTreeNode<int>(3)
            {
                Right = new DSTreeNode<int>(7),
                Left = new DSTreeNode<int>(6)
            };

            ListOfDepth obj = new ListOfDepth();
            var actual = obj.levelOrder(dSTreeNode);
            var expected = new DSLinkedList<int>[3];
            expected[0] = new DSLinkedList<int>();
            expected[0].Add(1);

            expected[1] = new DSLinkedList<int>();
            expected[1].Add(2);
            expected[1].Add(3);

            expected[2] = new DSLinkedList<int>();
            expected[2].Add(4);
            expected[2].Add(5);
            expected[2].Add(6);
            expected[2].Add(7);

            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.Length, expected.Length);

            for (int i = 0; i < actual.Length; i++)
            {
                var actualData = actual[i]._head;
                var expectedData = expected[i]._head;

                Assert.AreEqual(actual[i].Count, expected[i].Count);

                while(actualData != null)
                {
                    Assert.AreEqual(actualData.Data, expectedData.Data);

                    actualData = actualData.Next;
                    expectedData = expectedData.Next;
                }
            }
        }
    }
}
