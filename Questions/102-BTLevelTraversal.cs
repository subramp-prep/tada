using System;
using System.Collections.Generic;

namespace questions
{
    //Question URL: https://leetcode.com/problems/binary-tree-level-order-traversal/description/
    //Given a binary tree, return the level order traversal of its nodes' 
    //values. (ie, from left to right, level by level).

    //For example:
    //Given binary tree[3, 9, 20, null, null, 15, 7],
    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7
    //return its level order traversal as:
    //[
    //  [3],
    //  [9,20],
    //  [15,7]
    //]
    public class BTLevelTraversal
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> output = new List<IList<int>>();
            if (root != null)
            {
                LeverOrderHelper(root, output, 0);
            }

            return output;
        }

        private static void LeverOrderHelper(TreeNode root, IList<IList<int>> output, int height)
        {
            if (root == null)
            {
                return;
            }

            if (output.Count < height + 1)
            {
                output.Add(new List<int>());
            }

            output[height].Add(root.val);

            LeverOrderHelper(root.left, output, height + 1);
            LeverOrderHelper(root.right, output, height + 1);
        }
    }
}
