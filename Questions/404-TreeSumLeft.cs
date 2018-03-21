using System;
namespace questions
{
    //Question URL: https://leetcode.com/problems/sum-of-left-leaves/description/
    //Find the sum of all left leaves in a given binary tree.
    //Example:

    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7

    //There are two left leaves in the binary tree, with values 9 and 15 respectively.Return 24.
    public class TreeSumLeft
    {
        public static int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;

            SumHelper(root, ref sum);

            return sum;
        }

        private static void SumHelper(TreeNode root, ref int sum)
        {
            if (root == null)
                return;

            TreeNode leftNode = root.left;
            if (leftNode != null && 
                (leftNode.left == null && leftNode.right == null))
                sum += root.left.val;

            SumHelper(root.left, ref sum);
            SumHelper(root.right, ref sum);
        }
    }
}
