using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/path-sum-ii/description/
    //Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
    //For example:
    //Given the below binary tree and sum = 22,
    //              5
    //             / \
    //            4   8
    //           /   / \
    //          11  13  4
    //         /  \    / \
    //        7    2  5   1
    //return
    //[
    //   [5,4,11,2],
    //   [5,8,4,5]
    //]

    public class PathSumII
    {
        public static IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            List<IList<int>> paths = new List<IList<int>>();

            if (root != null)
            {
                List<int> path = new List<int>();
                PathSum(root, sum, paths, path);
            }

            return paths;
        }

        private static void PathSum(TreeNode root, int sum, List<IList<int>> paths, List<int> path)
        {
            if(root.left == null && root.right == null)
            {
                // If sume of the elements in the list matches 'sum'
                path.Add(root.val);
                int listsum = 0;
                foreach (var element in path)
                {
                    listsum += element;
                }

                if (listsum == sum)
                {
                    paths.Add( new List<int>( path));
                }

                path.RemoveAt(path.Count - 1);
            }

            if (root.left != null)
            {
                path.Add(root.val);
                PathSum(root.left, sum, paths, path);
                path.RemoveAt(path.Count - 1);
            }

            if (root.right != null)
            {
                path.Add(root.val);
                PathSum(root.right, sum, paths, path);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
