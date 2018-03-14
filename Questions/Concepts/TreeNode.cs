using System;
namespace questions
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }


        public void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left);
            Console.WriteLine(root.val);
            InOrder(root.right);
        }

        public void PreOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.val);
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public void PostOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine(root.val);
        }
    }
}
