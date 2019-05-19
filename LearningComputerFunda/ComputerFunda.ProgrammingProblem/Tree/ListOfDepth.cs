using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.DataStructure.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Tree
{
    public class ListOfDepth
    {
        public DSLinkedList<int>[] levelOrder(DSTreeNode<int> root)
        {
            List<DSLinkedList<int>> _node = new List<DSLinkedList<int>>();

            Iterator(root, 0, _node);

            return _node.ToArray();
        }

        private void Iterator(DSTreeNode<int> root, int level, List<DSLinkedList<int>> _node)
        {
            if(root == null)
            {
                return;
            }

            if(_node.Count == level)
            {
                var list = new DSLinkedList<int>();
                list.Add(root.Data);
                _node.Add(list);
            }
            else
            {
                _node[level].Add(root.Data);
            }

            if(root.Left != null)
            {
                Iterator(root.Left, level + 1, _node);
            }

            if (root.Right != null)
            {
                Iterator(root.Right, level + 1, _node);
            }
        }
    }
}
