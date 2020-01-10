using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Tree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
    public class HeightOfBinaryTree
    {
        public int FindHeight(Node head)
        {
            return InOrderTraversal(head) - 1;
        }

        public int InOrderTraversal(Node node)
        {
            int response = 1;
            int left = 0;
            int right = 0;
            if(node.Left != null)
            {
                left = InOrderTraversal(node.Left);
            }

            if(node.Right != null)
            {
                right = InOrderTraversal(node.Right);
            }

            return response + System.Math.Max(left, right);
        }
    }
}
