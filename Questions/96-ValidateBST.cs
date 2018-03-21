﻿using System;
namespace questions
{
    public class ValidateBST
    {
        //questions URL: https://leetcode.com/problems/validate-binary-search-tree/description/

        //Given a binary tree, determine if it is a valid binary search tree(BST).
        //Assume a BST is defined as follows:

        //The left subtree of a node contains only nodes with keys less than the node's key.
        //The right subtree of a node contains only nodes with keys greater than the node's key.
        //Both the left and right subtrees must also be binary search trees.
        //Example 1:
        //    2
        //   / \
        //  1   3
        //Binary tree [2,1,3], return true.
        //Example 2:
        //    1
        //   / \
        //  2   3
        //Binary tree [1,2,3], return false.

        //TODO Requires optimization
        public static bool IsValidBST(TreeNode root)
        {
            //return IsValidBST(root, int.MinValue, int.MaxValue);

            return IsValidBST(root, null, null);
        }

        //private static bool IsValidBST(TreeNode root, int min, int max)
        //{
        //    if (root == null) return true;

        //    if (root.val < min || root.val > max)
        //        return false;

        //    if(!IsValidBST(root.left, min, root.val) ||
        //       !IsValidBST(root.right, root.val, max))
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        private static bool IsValidBST(TreeNode root, int? min, int? max)
        {
            if (root == null)
                return true;

            if ((min != null && root.val <= min) || 
                (max != null && root.val >= max))
                return false;

            return IsValidBST(root.left, min, root.val) && 
                IsValidBST(root.right, root.val, max);
        }
    }
}
