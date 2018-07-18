using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Tree.BinarySearchTree
{
    public class DSBinarySearchNode<T>
    {
        public T Data { get; set; }

        public DSBinarySearchNode<T> Left { get; set; }

        public DSBinarySearchNode<T> Right { get; set; }

        public DSBinarySearchNode(T data)
        {
            this.Data = data;
        }
    }
}
