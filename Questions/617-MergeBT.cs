using System;
namespace questions
{
    // https://leetcode.com/problems/merge-two-binary-trees/description/
    //Given two binary trees and imagine that when you put one of them to cover the other, 
    //some nodes of the two trees are overlapped while the others are not.

    //You need to merge them into a new binary tree.The merge rule is that if two nodes overlap, 
    //then sum node values up as the new value of the merged node.Otherwise, the NOT null node 
    //will be used as the node of new tree.

    //Example 1:
    //Input: 
    //    Tree 1                     Tree 2                  
    //          1                         2                             
    //         / \                       / \                            
    //        3   2                     1   3                        
    //       /                           \   \                      
    //      5                             4   7                  
    //Output: 
    //Merged tree:
    //         3
    //        / \
    //       4   5
    //      / \   \ 
    //     5   4   7
    //Note: The merging process must start from the root nodes of both trees.
    public class MergeBT
    {
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            return MergeHelper(t1, t2, null);
        }

        private static TreeNode MergeHelper(TreeNode root1, TreeNode root2, TreeNode root)
        {
            if (root1 == null && root2 == null)
            {
                return null;
            }

            int sum = 0;
            if (root1 != null)
            {
                sum = sum + root1.val;
            }

            if (root2 != null)
            {
                sum = sum + root2.val;
            }

            root = new TreeNode(sum);

            root.left = MergeHelper(root1!= null ? root1.left: null, root2!=null ? root2.left: null, root.left);
            root.right = MergeHelper(root1!=null ? root1.right: null, root2!= null ? root2.right: null, root.right);

            return root;
        }
    }
}
