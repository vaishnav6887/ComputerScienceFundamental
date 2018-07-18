﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFunda.DataStructure.Tree.BinarySearchTree;

namespace ComputerFunda.DataStructure.Test.Tree.BinarySearchTreeTest
{
    [TestClass]
    public class BinarySearchTreeTest
    {
        public DSBinarySearchTree Tree { get; set; }

        public BinarySearchTreeTest()
        {
            this.Tree = new DSBinarySearchTree();
        }

        [TestMethod]
        public void Binary_Search_Tree_Search_Test()
        {
            this.Tree.Insert(10);
            this.Tree.Insert(6);
            this.Tree.Insert(13);
            this.Tree.Insert(3);
            this.Tree.Insert(7);
            this.Tree.Insert(2);
            this.Tree.Insert(4);
            this.Tree.Insert(5);
            this.Tree.Insert(8);

            bool actual = this.Tree.Search(7);

            Assert.IsTrue(actual);
        }
    }
}
