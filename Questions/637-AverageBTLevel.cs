using System;
using System.Collections.Generic;

namespace questions
{
    //Question URL: 
    // https://leetcode.com/problems/average-of-levels-in-binary-tree/description/
    //Given a non-empty binary tree, return the average 
    //value of the nodes on each level in the form of an array.
    //Example 1:
    //Input:
    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7
    //Output: [3, 14.5, 11]
    //        Explanation:
    //The average value of nodes on level 0 is 3,  on level 1 is 14.5, 
    // and on level 2 is 11. Hence return [3, 14.5, 11].
    //Note:
    //The range of node's value is in the range of 32-bit signed integer.

    public class AverageBTLevel
    {
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> output = new List<double>();

            if (root != null)
            {
                LevelOrderDFS(root, output);
            }

            return output;
        }

        private static void LevelOrderDFS(TreeNode root, IList<double> output)
        {
            IList<List<int>> levelElements = new List<List<int>>();

            LevelOrderDFS(root, levelElements, 0);

            foreach (var level in levelElements)
            {
                double sum = 0;
                for (int i = 0; i < level.Count; i++)
                {
                    sum += level[i];
                }

                output.Add(sum/level.Count);
            }
        }

        private static void LevelOrderDFS(TreeNode root, IList<List<int>> levelElements, int height)
        {
            if (root == null)
            {
                return;
            }

            if (levelElements.Count < height + 1)
            {
                levelElements.Add(new List<int>());
            }

            levelElements[height].Add(root.val);

            LevelOrderDFS(root.left, levelElements, height + 1);
            LevelOrderDFS(root.right, levelElements, height + 1);
        }
    }
}
