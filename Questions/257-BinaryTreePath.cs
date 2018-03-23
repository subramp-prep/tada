using System;
using System.Collections.Generic;

namespace questions
{
    public class BinaryTreePath
    {
        // Question: https://leetcode.com/problems/binary-tree-paths/description/
        //Given a binary tree, return all root-to-leaf paths.
        //For example, given the following binary tree:
        //   1
        // /   \
        //2     3
        // \
        //  5
        //All root-to-leaf paths are:
        //["1->2->5", "1->3"]

        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> paths = new List<string>();

            if(root != null)
                BinaryTreeHelper(root, "", paths);

            return paths;
        }

        private static void BinaryTreeHelper(TreeNode root, string path, IList<string> paths)
        {
            if (root.left == null && root.right == null)
            {
                paths.Add(!string.IsNullOrEmpty(path) ? (path + "->" + root.val) : root.val.ToString());
            }

            if (root.left != null) 
                BinaryTreeHelper(root.left, !string.IsNullOrEmpty(path) ? (path + "->" + root.val) : root.val.ToString(), paths);
            
            if (root.right != null)
                BinaryTreeHelper(root.right, !string.IsNullOrEmpty(path) ? (path + "->" + root.val) : root.val.ToString(), paths);
        }
    }
}
