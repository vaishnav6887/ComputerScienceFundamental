using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.DataStructure.Tree;
using ComputerFunda.ProgrammingProblem.Queue;
using System.Collections.Generic;

namespace ComputerFunda.ProgrammingProblem.Tree
{
    public class CompleteBTreeUsingLinkedList
    {
        private DSNode<int> _listHead;

        public CompleteBTreeUsingLinkedList(DSNode<int> head)
        {
            _listHead = head;
        }

        public DSTreeNode<int> Construct()
        {
            if(_listHead == null)
            {
                return null;
            }

            DSQueue<DSTreeNode<int>> queue = new DSQueue<DSTreeNode<int>>();

            DSTreeNode<int> treeNode = new DSTreeNode<int>(_listHead.Data);

            queue.Enqueue(treeNode);

            var current = _listHead;

            while(current != null)
            {
                DSTreeNode<int> de = null;
                if (queue.Count > 0)
                {
                    de = queue.Dequeue();
                }
                
                if(current.Next != null)
                {
                    de.Left = new DSTreeNode<int>(current.Next.Data);
                    queue.Enqueue(de.Left);
                    current = current.Next;

                    if (current.Next != null)
                    {
                        de.Right = new DSTreeNode<int>(current.Next.Data);
                        queue.Enqueue(de.Right);
                        current = current.Next;
                    }
                }
                else
                {
                    break;
                }
            }

            return treeNode;
        }

        public int[] LevelOrderTraversal()
        {
            DSTreeNode<int> _treeHead = Construct();

            List<int> arr = new List<int>();

            DSQueue<DSTreeNode<int>> queue = new DSQueue<DSTreeNode<int>>();

            var tempNode = _treeHead;

            while(tempNode != null)
            {
                arr.Add(tempNode.Data);

                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                }

                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                }

                if(queue.Count > 0)
                {
                    tempNode = queue.Dequeue();
                }
                else
                {
                    tempNode = null;
                }
            }

            return arr.ToArray();
        }
    }
}
