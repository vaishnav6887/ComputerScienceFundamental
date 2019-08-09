using ComputerFunda.DataStructure.Tree.BinarySearchTree;

namespace ComputerFunda.ProgrammingProblem.Tree
{
    public static class BinarySearchTree
    {
        public static bool IsBinarySearchTree(DSBinarySearchNode<int> root)
        {
            /// Implement method to identify if the given tree is binary search tree or not. Return true if yes or else return false.

            return isValid(root);
        }

        private static bool isValid(DSBinarySearchNode<int> root)
        {
            if(root == null)
            {
                return true;
            }

            bool isLeftValid = true;
            bool isRightValid = true;

            if(root.Left != null)
            {
                if(root.Left.Data < root.Data)
                {
                    isLeftValid = isValid(root.Left);
                }
                else
                {
                    return false;
                }
            }

            if(root.Right != null)
            {
                if(root.Right.Data > root.Data)
                {
                    isRightValid = isValid(root.Right);
                }
                else
                {
                    return false;
                }
            }

            return isLeftValid && isRightValid;
        }
    }
}
