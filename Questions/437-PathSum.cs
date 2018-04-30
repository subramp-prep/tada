using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/path-sum-iii/description/
    // You are given a binary tree in which each node contains an integer value.
	// 
    // Find the number of paths that sum to a given value.
	// 
    // The path does not need to start or end at the root or a leaf, 
    // but it must go downwards(traveling only from parent nodes to child nodes).
	// 
    // The tree has no more than 1,000 nodes and the values are in the range -1,000,000 to 1,000,000.
	// 
    // Example:
	// 
    // root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8
    //       10
    //      /  \
    //     5   -3
    //    / \    \
    //   3   2   11
    //  / \   \
    // 3  -2   1
	// 
    // Return 3. The paths that sum to 8 are:
	// 
    // 1.  5 -> 3
    // 2.  5 -> 2 -> 1
    // 3. -3 -> 11
    public class PathSumIII
    {
        public static int PathSum(TreeNode root, int sum)
        {
            int count = 0;

            if (root != null)
            {
                List<int> nodes = new List<int>();
                InOrderTraversal(root, sum, nodes, ref count);
            }

            return count;
        }

        private static void InOrderTraversal(TreeNode root, int sum, IList<int> nodes,ref int count)
        {
            if (root == null)
            {
                return;
            }

            nodes.Add(root.val);
            InOrderTraversal(root.left, sum, nodes,ref count);
            InOrderTraversal(root.right, sum, nodes,ref count);

            int localSum = 0;
            for (int i = nodes.Count - 1; i >= 0; i--)
            {
                localSum += nodes[i]; 
                if (localSum == sum)
                {
                    count += 1;
                    break;
                }
            }

            nodes.RemoveAt(nodes.Count - 1);
        }

        // WRONG IMPL
        private static int PathSum(TreeNode root, int target, int count)
        {
            if (root == null)
                return 0;

            int sum = root.val + PathSum(root.left, target, count) + PathSum(root.right, target, count);

            Console.WriteLine(sum);
            if (sum == target)
            {
                count++;
            }

            return sum;
        }


        //Dead code... trial 1 DFS
        private static void PathSumHelper(TreeNode root, int sum, IList<int> nodes, int count)
        {
            if (root.left == null && root.right == null)
            {
                nodes.Add(root.val);

                //int localsum = 0;
                foreach (var node in nodes)
                {
                    Console.Write("{0}->", node);
                }

                Console.WriteLine();

                nodes.RemoveAt(nodes.Count - 1);
            }

            if (root.left != null)
            {
                nodes.Add(root.val);

                PathSumHelper(root.left, sum, nodes, count);

                nodes.RemoveAt(nodes.Count - 1);
            }

            if (root.right != null)
            {
                nodes.Add(root.val);

                PathSumHelper(root.right, sum, nodes, count);

                nodes.RemoveAt(nodes.Count - 1);
            }
        }
    }
}
