using System;
namespace questions
{
    // https://leetcode.com/problems/minimum-absolute-difference-in-bst/description/
    //Given a binary search tree with non-negative values, find the minimum 
    //absolute difference between values of any two nodes.

    //Example:
    //Input:

    //   1
    //    \
    //     3
    //    /
    //   2

    //Output:
    //1

    //Explanation:
    //The minimum absolute difference is 1, which is the difference between 
    //2 and 1 (or between 2 and 3).
    //Note: There are at least two nodes in this BST.
    public class MinAbsDiffBST
    {
        public static int GetMinimumDifference_Gut(TreeNode root)
        {
            int? minimum = null;
            GetMinimumDifference(root, null, ref minimum);

            return minimum.Value;
        }

        private static int min = int.MaxValue;
        private static int? prev;
        public static int GetMinimumDifference(TreeNode root)
        {
            if (root == null) return min;

            GetMinimumDifference(root.left);

            if (prev != null)
            {
                min = Math.Min(min, root.val - prev.Value);
            }
            prev = root.val;

            GetMinimumDifference(root.right);

            return min;
        }

        private static void InOrderTraverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraverse(root.left);
            Console.WriteLine(root.val);
            InOrderTraverse(root.right);
        }

        private static void GetMinimumDifference(TreeNode root, int? previ,ref int? mins)
        {
            if (root == null)
            {
                return;
            }

            GetMinimumDifference(root.left, previ,ref mins);


            if (previ != null)
            {
                min = Math.Min(mins.Value, Math.Abs(previ.Value - root.val) );
            }
            prev = root.val;


            GetMinimumDifference(root.right, prev, ref mins);
        }
    }
}
