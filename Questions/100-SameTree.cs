using System;
namespace questions
{
    /// <summary>
    /// Question URL: https://leetcode.com/problems/same-tree/description/
    /// Given two binary trees, write a function to check if they are the same or not.
    /// Two binary trees are considered the same if they are structurally identical and the nodes have the same value.
    /// </summary>

    public class SameTree
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;

            if (p == null || q == null) return false;

            if (p.val == q.val)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
            
            return false;
        }
    }
}
