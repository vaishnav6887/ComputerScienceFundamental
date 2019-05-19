using ComputerFunda.DataStructure.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ProgrammingProblem.Test.Tree
{
    [TestCategory("BinaryTree")]
    [TestClass]
    public class DSBinaryTreeTest
    {
        public DSBinaryTree<int> Tree { get; set; }
        public DSBinaryTreeTest()
        {
            this.Tree = new DSBinaryTree<int>();
        }

        #region inOrder Traversal test cases
        [TestMethod]
        public void BinaryTree_Inorder_Travesal()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Left = new DSTreeNode<int>(2);
            this.Tree.Head.Right = new DSTreeNode<int>(3);

            //level 2
            this.Tree.Head.Left.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Left.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Left.Left.Left = new DSTreeNode<int>(6);
            this.Tree.Head.Left.Left.Right = new DSTreeNode<int>(7);
            this.Tree.Head.Left.Right.Left = new DSTreeNode<int>(8);
            this.Tree.Head.Left.Right.Right = new DSTreeNode<int>(9);

            this.Tree.InOrderTraversal();

            List<int> expected = new List<int>()
            {
                6,4,7,2,8,5,9,1,3
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Inorder_Travesal_Left_Node_Empty()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Right = new DSTreeNode<int>(2);

            //level 2
            this.Tree.Head.Right.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Right.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Right.Left.Left = new DSTreeNode<int>(6);
            this.Tree.Head.Right.Left.Right = new DSTreeNode<int>(7);
            this.Tree.Head.Right.Right.Left = new DSTreeNode<int>(8);
            this.Tree.Head.Right.Right.Right = new DSTreeNode<int>(9);

            this.Tree.InOrderTraversal();

            List<int> expected = new List<int>()
            {
                1,6,4,7,2,8,5,9
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Inorder_Travesal_LEFT_RIGHT_Node_Empty()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.InOrderTraversal();

            List<int> expected = new List<int>() { 1 };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Inorder_Travesal_Empty_TREE()
        {
            this.Tree.InOrderTraversal();

            List<int> expected = new List<int>();

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        #endregion

        #region PreOrder Traversal test cases
        [TestMethod]
        public void BinaryTree_Preorder_Travesal()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Left = new DSTreeNode<int>(2);
            this.Tree.Head.Right = new DSTreeNode<int>(3);

            //level 2
            this.Tree.Head.Left.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Left.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Left.Left.Left = new DSTreeNode<int>(6);
            this.Tree.Head.Left.Left.Right = new DSTreeNode<int>(7);
            this.Tree.Head.Left.Right.Left = new DSTreeNode<int>(8);
            this.Tree.Head.Left.Right.Right = new DSTreeNode<int>(9);

            this.Tree.PreOrderTraversal();

            List<int> expected = new List<int>()
            {
                1,2,4,6,7,5,8,9,3
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Preorder_Travesal_Left_Node_Empty()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Right = new DSTreeNode<int>(2);

            //level 2
            this.Tree.Head.Right.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Right.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Right.Left.Left = new DSTreeNode<int>(6);
            this.Tree.Head.Right.Left.Right = new DSTreeNode<int>(7);
            this.Tree.Head.Right.Right.Left = new DSTreeNode<int>(8);
            this.Tree.Head.Right.Right.Right = new DSTreeNode<int>(9);

            this.Tree.PreOrderTraversal();

            List<int> expected = new List<int>()
            {
                1,2,4,6,7,5,8,9
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Preorder_Travesal_LEFT_RIGHT_Node_Empty()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.PreOrderTraversal();

            List<int> expected = new List<int>() { 1 };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Preorder_Travesal_Empty_TREE()
        {
            this.Tree.PreOrderTraversal();

            List<int> expected = new List<int>();

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        #endregion

        #region PostOrder Traversal test cases
        [TestMethod]
        public void BinaryTree_Postorder_Travesal()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Left = new DSTreeNode<int>(2);
            this.Tree.Head.Right = new DSTreeNode<int>(3);

            //level 2
            this.Tree.Head.Left.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Left.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Left.Left.Left = new DSTreeNode<int>(6);
            this.Tree.Head.Left.Left.Right = new DSTreeNode<int>(7);
            this.Tree.Head.Left.Right.Left = new DSTreeNode<int>(8);
            this.Tree.Head.Left.Right.Right = new DSTreeNode<int>(9);

            this.Tree.PostOrderTraversal();

            List<int> expected = new List<int>()
            {
                6,7,4,8,9,5,2,3,1
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Postorder_Travesal_Left_Node_Empty()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Right = new DSTreeNode<int>(2);

            //level 2
            this.Tree.Head.Right.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Right.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Right.Left.Left = new DSTreeNode<int>(6);
            this.Tree.Head.Right.Left.Right = new DSTreeNode<int>(7);
            this.Tree.Head.Right.Right.Left = new DSTreeNode<int>(8);
            this.Tree.Head.Right.Right.Right = new DSTreeNode<int>(9);

            this.Tree.PostOrderTraversal();

            List<int> expected = new List<int>()
            {
                6,7,4,8,9,5,2,1
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Postorder_Travesal_LEFT_RIGHT_Node_Empty()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.PostOrderTraversal();

            List<int> expected = new List<int>() { 1 };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void BinaryTree_Postorder_Travesal_Empty_TREE()
        {
            this.Tree.PostOrderTraversal();

            List<int> expected = new List<int>();

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        #endregion

        #region Level Order Traversal
        [TestMethod]
        public void Level_Order_Traversal_TEST()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Left = new DSTreeNode<int>(2);
            this.Tree.Head.Right = new DSTreeNode<int>(3);

            //level 2
            this.Tree.Head.Left.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Left.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Left.Left.Left = new DSTreeNode<int>(9);
            this.Tree.Head.Left.Left.Right = new DSTreeNode<int>(8);
            this.Tree.Head.Left.Right.Left = new DSTreeNode<int>(7);
            this.Tree.Head.Left.Right.Right = new DSTreeNode<int>(6);

            this.Tree.LevelOrderTraversal();

            List<int> expected = new List<int>()
            {
                1,2,3,4,5,9,8,7,6
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void Level_Order_Traversal_TEST_Using_Queue()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Left = new DSTreeNode<int>(2);
            this.Tree.Head.Right = new DSTreeNode<int>(3);

            //level 2
            this.Tree.Head.Left.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Left.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Left.Left.Left = new DSTreeNode<int>(9);
            this.Tree.Head.Left.Left.Right = new DSTreeNode<int>(8);
            this.Tree.Head.Left.Right.Left = new DSTreeNode<int>(7);
            this.Tree.Head.Left.Right.Right = new DSTreeNode<int>(6);

            //this.Tree.LevelOrderTraversal();

            List<int> actual = this.Tree.LevelOrderTraversalUsingQueue();

            List<int> expected = new List<int>()
            {
                1,2,3,4,5,9,8,7,6
            };

            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        #region Add to binary tree
        [TestMethod]
        public void Add_Binary_Tree()
        {
            //level 0
            this.Tree.Head = new DSTreeNode<int>(1);

            //level 1
            this.Tree.Head.Left = new DSTreeNode<int>(2);
            this.Tree.Head.Right = new DSTreeNode<int>(3);

            //level 2
            this.Tree.Head.Left.Left = new DSTreeNode<int>(4);
            this.Tree.Head.Left.Right = new DSTreeNode<int>(5);

            // level 3
            this.Tree.Head.Left.Left.Left = new DSTreeNode<int>(6);
            this.Tree.Head.Left.Left.Right = new DSTreeNode<int>(7);
            this.Tree.Head.Left.Right.Left = new DSTreeNode<int>(8);
            this.Tree.Head.Left.Right.Right = new DSTreeNode<int>(9);

            this.Tree.Add(10);

            this.Tree.InOrderTraversal();

            List<int> expected = new List<int>()
            {
                6,4,7,2,8,5,9,1,10,3
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }

        [TestMethod]
        public void Add_Binary_Tree_Add_At_Node()
        {
            this.Tree.Add(10);

            this.Tree.InOrderTraversal();

            List<int> expected = new List<int>()
            {
                10
            };

            CollectionAssert.AreEqual(expected, this.Tree._TempDataConsole);
        }
        #endregion
    }
}
