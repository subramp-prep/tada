using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/binary-tree-level-order-traversal-ii/description/
    //Given a binary tree, return the bottom-up level order traversal of its nodes' 
    //values. (ie, from left to right, level by level from leaf to root).
    //For example:
    //Given binary tree[3, 9, 20, null, null, 15, 7],
    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7
    //return its bottom-up level order traversal as:
    //[
    //  [15,7],
    //  [9,20],
    //  [3]
    //]
    public class BTTraversalII
    {
       
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
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

            if (height >= output.Count)
            {
                output.Add(new List<int>());
            }

            LeverOrderHelper(root.left, output, height + 1);
            LeverOrderHelper(root.right, output, height + 1);

            // TODO one of the array elements do not fall in place correctly
            // Since the left side of the tree has lesser leaves compared to
            // the right, it does not place 9 in the right spot
            output[output.Count - height -1].Add(root.val);
        }
    }
}
