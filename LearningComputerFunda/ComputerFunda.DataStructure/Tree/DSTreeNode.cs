using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Tree
{
    public class DSTreeNode<T>
    {
        public T Data { get; set; }
        public DSTreeNode<T> Left { get; set; }
        public DSTreeNode<T> Right { get; set; }

        public DSTreeNode(T item)
        {
            this.Data = item;
        }
    }
}
