using ComputerFunda.DataStructure.Stack;
using ComputerFunda.DataStructure.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Tree
{
    public class InOrderSuccessorBST
    {
        public DSTreeNode<int> Tree { get; set; }

        private int _inOrderSuccessorNode = -1;

        public InOrderSuccessorBST(DSTreeNode<int> tree)
        {
            Tree = tree;
        }

        public int Find(int value)
        {
            InOrderTraversal(Tree, value, null);

            return _inOrderSuccessorNode;
        }

        public void InOrderTraversal(DSTreeNode<int> root, int value, DSTreeNode<int> left)
        {
            if(root == null)
            {
                return;
            }

            if(root.Data == value)
            {
                FindSuccessor(root, left);

                return;
            }

            /// If Successor not already found
            if(_inOrderSuccessorNode == -1)
            {
                if (root.Left != null)
                {
                    InOrderTraversal(root.Left, value, root);
                }

                if (root.Right != null)
                {
                    InOrderTraversal(root.Right, value, left);
                }
            }
        }

        private void FindSuccessor(DSTreeNode<int> root, DSTreeNode<int> left)
        {
            // Case 1: If right node is not null
            if(root.Right != null)
            {
                var current = root.Right;
                while (current.Left != null)
                {
                    current = current.Left;
                }

                _inOrderSuccessorNode = current.Data;
            }
            else
            {
                if(left != null)
                {
                    _inOrderSuccessorNode = left.Data;
                }
            }
        }
    }
}
