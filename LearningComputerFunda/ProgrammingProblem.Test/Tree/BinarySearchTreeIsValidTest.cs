using ComputerFunda.DataStructure.Tree;
using ComputerFunda.DataStructure.Tree.BinarySearchTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BT = ComputerFunda.ProgrammingProblem.Tree.BinarySearchTree;

namespace ProgrammingProblem.Test.Tree
{
    [TestCategory("BinaryTree")]
    [TestClass]
    public class BinarySearchTreeIsValidTest
    {
        private DSBinarySearchNode<int> Tree { get; set; }
        public BinarySearchTreeIsValidTest()
        {
            this.Tree = new DSBinarySearchNode<int>(10);
        }

        [TestMethod]
        public void IsValid_BinarySearchTree_Positive()
        {   
            //level 1
            this.Tree.Left = new DSBinarySearchNode<int>(5);
            this.Tree.Right = new DSBinarySearchNode<int>(15);

            //level 2
            this.Tree.Left.Left = new DSBinarySearchNode<int>(2);
            this.Tree.Left.Right = new DSBinarySearchNode<int>(6);
            this.Tree.Right.Left = new DSBinarySearchNode<int>(11);
            this.Tree.Right.Right = new DSBinarySearchNode<int>(16);

            // level 3
            this.Tree.Left.Right.Right = new DSBinarySearchNode<int>(8);

            Assert.IsTrue(BT.IsBinarySearchTree(this.Tree));
        }
    }
}
