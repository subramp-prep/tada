using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/inorder-successor-in-bst/description/
    //Given a binary search tree and a node in it, find 
    //the in-order successor of that node in the BST.

    //Note: If the given node has no in-order successor in the tree, return null.
    public class Inorder
    {
        // TODO
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            return null;
        }
    }


//    Successor

//public TreeNode successor(TreeNode root, TreeNode p)
//    {
//        if (root == null)
//            return null;

//        if (root.val <= p.val)
//        {
//            return successor(root.right, p);
//        }
//        else
//        {
//            TreeNode left = successor(root.left, p);
//            return (left != null) ? left : root;
//        }
//    }
//    Predecessor

//public TreeNode predecessor(TreeNode root, TreeNode p)
    //{
    //    if (root == null)
    //        return null;

    //    if (root.val >= p.val)
    //    {
    //        return predecessor(root.left, p);
    //    }
    //    else
    //    {
    //        TreeNode right = predecessor(root.right, p);
    //        return (right != null) ? right : root;
    //    }
    //}
}
