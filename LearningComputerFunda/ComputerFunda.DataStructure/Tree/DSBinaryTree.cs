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
            if(node.Left != null)
            {
                Postorder(node.Left);
            }

            if(node.Right != null)
            {
                Postorder(node.Right);
            }

            _TempDataConsole.Add(node.Data);
        }
    }
}
