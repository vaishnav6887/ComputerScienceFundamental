using System;
using ComputerFunda.DataStructure.Tree;
using ComputerFunda.ProgrammingProblem.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.BinarySearchTree
{
    [TestClass]
    [TestCategory("BinarySearchTree")]
    public class InOrderSuccessorBSTTest
    {
        [TestMethod]
        public void Successor_Test_Right_Tree_Not_Null_Scenario()
        {
            InOrderSuccessorBST obj = new InOrderSuccessorBST(new DSTreeNode<int>(10)
            {
                Left = new DSTreeNode<int>(5)
                {
                    Left = new DSTreeNode<int>(3)
                    {
                        Left = new DSTreeNode<int>(1),
                        Right = new DSTreeNode<int>(4)
                    },
                    Right = new DSTreeNode<int>(6)
                    {
                        Right = new DSTreeNode<int>(7)
                        {
                            Right = new DSTreeNode<int>(8)
                        }
                    }
                },
                Right = new DSTreeNode<int>(15)
                {
                    Left = new DSTreeNode<int>(13)
                    {
                        Left = new DSTreeNode<int>(11),
                        Right = new DSTreeNode<int>(14)
                    },
                    Right = new DSTreeNode<int>(16)
                }
            });

            int actual = obj.Find(6);
            int expected = 7;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Successor_Test_Right_Tree_Null_Scenario()
        {
            InOrderSuccessorBST obj = new InOrderSuccessorBST(new DSTreeNode<int>(10)
            {
                Left = new DSTreeNode<int>(5)
                {
                    Left = new DSTreeNode<int>(3)
                    {
                        Left = new DSTreeNode<int>(1),
                        Right = new DSTreeNode<int>(4)
                    },
                    Right = new DSTreeNode<int>(6)
                    {
                        Right = new DSTreeNode<int>(7)
                        {
                            Right = new DSTreeNode<int>(8)
                        }
                    }
                },
                Right = new DSTreeNode<int>(15)
                {
                    Left = new DSTreeNode<int>(13)
                    {
                        Left = new DSTreeNode<int>(11),
                        Right = new DSTreeNode<int>(14)
                    },
                    Right = new DSTreeNode<int>(16)
                }
            });

            int actual = obj.Find(8);
            int expected = 10;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Successor_Test_No_Further_Successor_In_Tree()
        {
            InOrderSuccessorBST obj = new InOrderSuccessorBST(new DSTreeNode<int>(10)
            {
                Left = new DSTreeNode<int>(5)
                {
                    Left = new DSTreeNode<int>(3)
                    {
                        Left = new DSTreeNode<int>(1),
                        Right = new DSTreeNode<int>(4)
                    },
                    Right = new DSTreeNode<int>(6)
                    {
                        Right = new DSTreeNode<int>(7)
                        {
                            Right = new DSTreeNode<int>(8)
                        }
                    }
                },
                Right = new DSTreeNode<int>(15)
                {
                    Left = new DSTreeNode<int>(13)
                    {
                        Left = new DSTreeNode<int>(11),
                        Right = new DSTreeNode<int>(14)
                    },
                    Right = new DSTreeNode<int>(16)
                }
            });

            int actual = obj.Find(16);
            int expected = -1;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Successor_Test_Element_Not_Found_In_Tree()
        {
            InOrderSuccessorBST obj = new InOrderSuccessorBST(new DSTreeNode<int>(10)
            {
                Left = new DSTreeNode<int>(5)
                {
                    Left = new DSTreeNode<int>(3)
                    {
                        Left = new DSTreeNode<int>(1),
                        Right = new DSTreeNode<int>(4)
                    },
                    Right = new DSTreeNode<int>(6)
                    {
                        Right = new DSTreeNode<int>(7)
                        {
                            Right = new DSTreeNode<int>(8)
                        }
                    }
                },
                Right = new DSTreeNode<int>(15)
                {
                    Left = new DSTreeNode<int>(13)
                    {
                        Left = new DSTreeNode<int>(11),
                        Right = new DSTreeNode<int>(14)
                    },
                    Right = new DSTreeNode<int>(16)
                }
            });

            int actual = obj.Find(17);
            int expected = -1;
            Assert.AreEqual(actual, expected);
        }
    }
}
