using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/find-duplicate-subtrees/description/
    // Given a binary tree, return all duplicate subtrees.For each kind of duplicate subtrees, 
    // you only need to return the root node of any one of them.
    // Two trees are duplicate if they have the same structure with same node values.

    //Example 1: 
    //        1
    //       / \
    //      2   3
    //     /   / \
    //    4   2   4
    //       /
    //      4
    //The following are two duplicate subtrees:
    //      2
    //     /
    //    4
    //and
    //    4
    //Therefore, you need to return above trees' root in the form of a list.
    public class DuplicateSubtrees
    {
        public static IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            IDictionary<string, int> duplicateNodes = new Dictionary<string, int>();
            IList<TreeNode> output = new List<TreeNode>();
            WalkTree(root, duplicateNodes, output);

            return output;
        }

        private static string WalkTree(TreeNode root, IDictionary<string, int> dups, IList<TreeNode> output)
        {
            if (root == null)
            {
                return "#";
            }

            // construct path
            string combo = root.val + "," + 
                           WalkTree(root.left, dups, output) + "," + 
                           WalkTree(root.right, dups, output);

            // check if path exists
            if (!dups.ContainsKey(combo))
                dups.Add(combo, 1);
            else
                dups[combo] += 1;

            // if path exists, has to be spitted out
            if (dups[combo] == 2)
            {
                output.Add(root);
            }

            return combo;
        }
    }
}
