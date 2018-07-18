using ComputerFunda.DataStructure.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Tree
{
    public class DSBinaryTree<T>
    {
        public DSTreeNode<T> Head { get; set; }

        /// <summary>
        ///  this is only for returning the testing data. This will not be actual part of the BSBinaryTree implementation
        /// </summary>
        public List<T> _TempDataConsole { get; set; }

        public void InOrderTraversal()
        {
            this._TempDataConsole = new List<T>();
            if (this.Head == null)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                Inorder(this.Head);
            }
        }

        public void PreOrderTraversal()
        {
            this._TempDataConsole = new List<T>();
            if (this.Head == null)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                Preorder(this.Head);
            }
        }

        public void PostOrderTraversal()
        {
            this._TempDataConsole = new List<T>();
            if (this.Head == null)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                Postorder(this.Head);
            }
        }

        public void LevelOrderTraversal()
        {
            /// Find the height of the tree
            /// Travers each level of the tree from height = 0 to height = h and print each element from left to right order.
            this._TempDataConsole = new List<T>();
            int height = findHeightOfTree(this.Head);

            for (int i = 1; i <= height; i++)
            {
                this.traverseLevel(this.Head, i);
            }
        }

        public List<T> LevelOrderTraversalUsingQueue()
        {
            var newList = new List<T>();

            if(this.Head != null)
            {
                DSQueue<DSTreeNode<T>> queue = new DSQueue<DSTreeNode<T>>();

                queue.Enqueue(this.Head);

                this.traverseUsingQueue(this.Head, queue, newList);
            }

            return newList;
        }

        public void Add(T value)
        {
            /// check if we have root? 
            /// if not then add new root element and then return.
            /// If yes then traverse its children from left to right. find first free spot and add the node in that spot.

            DSTreeNode<T> newNode = new DSTreeNode<T>(value);

            if(this.Head == null)
            {
                this.Head = newNode;
                return;
            }

            DSQueue<DSTreeNode<T>> dSQueue = new DSQueue<DSTreeNode<T>>();

            dSQueue.Enqueue(this.Head);

            while(dSQueue.Count > 0)
            {
                var current = dSQueue.Dequeue();

                if(current.Data.Left == null)
                {
                    current.Data.Left = newNode;
                    break;
                }
                else
                {
                    dSQueue.Enqueue(current.Data.Left);
                }

                if(current.Data.Right == null)
                {
                    current.Data.Right = newNode;
                    break;
                }
                else
                {
                    dSQueue.Enqueue(current.Data.Right);
                }
            }
        }

        private void traverseUsingQueue(DSTreeNode<T> node, DSQueue<DSTreeNode<T>> queue, List<T> newList)
        {
            while(queue.Count != 0)
            {
                var current = queue.Dequeue();

                newList.Add(current.Data.Data);

                if(current.Data.Left != null)
                {
                    queue.Enqueue(current.Data.Left);
                }

                if(current.Data.Right != null)
                {
                    queue.Enqueue(current.Data.Right);
                }
            }
        }

        private int findHeightOfTree(DSTreeNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            int hLeft = findHeightOfTree(node.Left);
            int hRight = findHeightOfTree(node.Right);

            if (hRight > hLeft)
            {
                return hRight + 1;
            }
            else
            {
                return hLeft + 1;
            }
        }

        private void traverseLevel(DSTreeNode<T> node, int level)
        {
            if (node != null)
            {
                if(level == 1)
                {
                    this._TempDataConsole.Add(node.Data);
                    return;
                }

                this.traverseLevel(node.Left, level - 1);
                this.traverseLevel(node.Right, level - 1);
            }
        }

        private void Inorder(DSTreeNode<T> node)
        {
            if (node.Left != null)
            {
                Inorder(node.Left);
            }

            _TempDataConsole.Add(node.Data);

            if (node.Right != null)
            {
                Inorder(node.Right);
            }
        }

        private void Preorder(DSTreeNode<T> node)
        {
            _TempDataConsole.Add(node.Data);

            if (node.Left != null)
            {
                Preorder(node.Left);
            }

            if (node.Right != null)
            {
                Preorder(node.Right);
            }
        }

        private void Postorder(DSTreeNode<T> node)
        {
            if (node.Left != null)
            {
                Postorder(node.Left);
            }

            if (node.Right != null)
            {
                Postorder(node.Right);
            }

            _TempDataConsole.Add(node.Data);
        }
    }
}
