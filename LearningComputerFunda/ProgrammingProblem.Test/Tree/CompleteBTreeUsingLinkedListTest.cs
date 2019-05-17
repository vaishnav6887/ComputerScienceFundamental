using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.DataStructure.Tree;
using ComputerFunda.ProgrammingProblem.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Tree
{
    [TestCategory("BinaryTree")]
    [TestClass]
    public class CompleteBTreeUsingLinkedListTest
    {
        [TestMethod]
        public void Contruct_Test_Positive()
        {
            DSNode<int> list = new DSNode<int>()
            {
                Data = 1,
                Next = new DSNode<int>()
                {
                    Data = 2,
                    Next = new DSNode<int>()
                    {
                        Data = 3,
                        Next = new DSNode<int>()
                        {
                            Data = 4,
                            Next = new DSNode<int>()
                            {
                                Data = 5,
                                Next = new DSNode<int>()
                                {
                                    Data = 6,
                                    Next = new DSNode<int>()
                                    {
                                        Data = 7,
                                        Next = new DSNode<int>()
                                        {
                                            Data = 8,
                                            Next = new DSNode<int>()
                                            {
                                                Data = 9
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            CompleteBTreeUsingLinkedList obj = new CompleteBTreeUsingLinkedList(list);

            DSTreeNode<int> head = obj.Construct();

            var traversal = obj.LevelOrderTraversal();

            int i = 1;
            foreach (var item in traversal)
            {
                Assert.AreEqual(item, i);
                i++;
            }
        }
    }
}
