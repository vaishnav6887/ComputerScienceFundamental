using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Tree.BinarySearchTree
{
    public class DSBinarySearchTree
    {
        public DSBinarySearchNode<int> Head { get; set; }

        public int Count { get; set; }

        public List<int> consoleList { get; set; }

        public void Insert(int item)
        {
            if (this.Head == null)
            {
                this.Head = new DSBinarySearchNode<int>(item);
                this.Count++;
                return;
            }

            this.FindSpotToInsert(this.Head, item);
        }

        public bool Search(int key)
        {
            this.consoleList = new List<int>();
            if(this.Head == null)
            {
                return false;
            }

            return this.Traverse(this.Head, key);
        }

        public void Delete(int item)
        {

        }

        private void FindSpotToInsert(DSBinarySearchNode<int> node, int data)
        {
            if(node == null)
            {
                node = new DSBinarySearchNode<int>(data);
                this.Count++;
                return;
            }

            if(node.Data == data)
            {
                throw new InvalidOperationException("Can not add duplicate keys in Binary search tree");
            }

            if(node.Data > data)
            {
                FindSpotToInsert(node.Left, data);
            }
            else
            {
                FindSpotToInsert(node.Right, data);
            }
        }

        private bool Traverse(DSBinarySearchNode<int> node, int key)
        {
            if(node == null || node.Data == key)
            {
                return true;
            }

            if(node.Left != null && node.Data > key)
            {
                return Traverse(node.Left, key);
            }
            else
            {
                return Traverse(node.Right, key);
            }
        }
    }
}
