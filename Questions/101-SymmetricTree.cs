using System;
namespace questions
{
    // https://leetcode.com/problems/symmetric-tree/description/
    //Given a binary tree, check whether it is a 
    //mirror of itself(ie, symmetric around its center).

    //For example, this binary tree [1,2,2,3,4,4,3] is symmetric:

    //    1
    //   / \
    //  2   2
    // / \ / \
    //3  4 4  3
    //But the following[1, 2, 2, null, 3, null, 3] is not:
    //    1
    //   / \
    //  2   2
    //   \   \
    //   3    3
    //Note:
    //Bonus points if you could solve it both recursively and iteratively.
    public class SymmetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetric(root.left, root.right);
        }

        private static bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            else if(left != null && right != null)
            {
                return left.val == right.val &&
                    IsSymmetric(left.left, right.right) &&
                    IsSymmetric(left.right, right.left);
            }

            return false;
        }
    }
}
