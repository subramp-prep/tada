using System;
namespace questions
{
    // https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/
    //Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
    //For this problem, a height-balanced binary tree is defined as a binary tree 
    //in which the depth of the two subtrees of every node never differ by more than 1.

    //Example:

    //Given the sorted array: [-10,-3,0,5,9],
    //One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:

     //     0
     //    / \
     //  -3   9
     //  /   /
     //-10  5
    public class SortedArrayToBinaryST
    {
        // TODO more tweaks required, final answer not arrived
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return BSTHelper(nums, 0, nums.Length - 1);
        }

        private static TreeNode BSTHelper(int[] nums, int low, int high)
        {
            if (low > high)
            {
                return null;
            }

            int mid = (low + high) / 2;

            TreeNode root = new TreeNode(nums[mid]);

            root.left = BSTHelper(nums, low, mid - 1);
            root.right =  BSTHelper(nums, mid + 1, high);

            return root;
        }
    }
}
