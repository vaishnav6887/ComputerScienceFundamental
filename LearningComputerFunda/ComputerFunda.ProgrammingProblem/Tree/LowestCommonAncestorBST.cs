using ComputerFunda.DataStructure.Tree.BinarySearchTree;

namespace ComputerFunda.ProgrammingProblem.Tree
{
    public class LowestCommonAncestorBST
    {
        public int? LowestCommonAncestor(DSBinarySearchNode<int> root, int v1, int v2)
        {
            if(root == null)
            {
                return null;
            }
            if(v1 < root.Data && root.Data > v2)
            {
                return LowestCommonAncestor(root.Left, v1, v2);
            }
            else if(v1> root.Data && root.Data < v2)
            {
                return LowestCommonAncestor(root.Right, v1, v2);
            }

            return root.Data;
        }
    }
}
