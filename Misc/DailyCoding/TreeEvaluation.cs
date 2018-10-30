using System;
namespace Misc
{
    //Suppose an arithmetic expression is given as a binary tree.
    //Each leaf is an integer and each internal node is one of '+', '−', '∗', or '/'.

    //Given the root to such a tree, write a function to evaluate it.

    //For example, given the following tree:

    //    *
    //   / \
    //  +    +
    // / \  / \
    //3  2  4  5
    //You should return 45, as it is (3 + 2) * (4 + 5).
    public class TreeEvaluation
    {
        public class TreeNode
        {
            public TreeNode(string c)
            {
                val = c;
            }
            
            public TreeNode left;
            public TreeNode right;
            public string val;
        }

        public TreeNode BuildTree(string[] chars, int index, TreeNode root)
        {
            if (index < chars.Length)
            {
                root = new TreeNode(chars[index]);

                root.left = BuildTree(chars, 2 * index + 1, root.left);
                root.right = BuildTree(chars, 2 * index + 2, root.right);
            }

            return root;
        }

        public int Evaluate(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return int.Parse(root.val);
            
            if (root.val == "+")
            {
                return Evaluate(root.left) + Evaluate(root.right);
            }
            else if (root.val == "-")
            {
                return Evaluate(root.left) - Evaluate(root.right);
            }
            else if (root.val == "*")
            {
                return Evaluate(root.left) * Evaluate(root.right);
            }

            return Evaluate(root.left) / Evaluate(root.right);

        }
    }
}
