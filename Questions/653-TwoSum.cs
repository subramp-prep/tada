using System;
using System.Collections.Generic;

namespace questions
{
    //https://leetcode.com/problems/two-sum-iv-input-is-a-bst/description/
    //Given a Binary Search Tree and a target number, return true if 
    //there exist two elements in the BST such that their sum is equal to the given target.

    //Example 1:
    //Input: 
    //    5
    //   / \
    //  3   6
    // / \   \
    //2   4   7

    //Target = 9
    //Output: True

    //Example 2:
    //Input: 
    //    5
    //   / \
    //  3   6
    // / \   \
    //2   4   7

    //Target = 28
    //Output: False

    public class TwoSumBST
    {
        public static bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> visited = new HashSet<int>();

            return FindTarget(root, k, visited);
        }

        private static bool FindTarget(TreeNode root, int k, HashSet<int> visited)
        {
            if (root == null)
            {
                return false;
            }

            int delta = k - root.val;

            if (visited.Contains(delta))
            {
                return true;
            }
            visited.Add(root.val);


            return FindTarget(root.left, k, visited) || 
                FindTarget(root.right, k, visited);
        }
    }
}
