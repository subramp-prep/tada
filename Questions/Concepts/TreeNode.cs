using System;
namespace questions
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x) 
        { 
            val = x; 
        }

        public static TreeNode BuildSampleTree()
        {
            TreeNode root = new TreeNode(3);
            TreeNode B = root.left = new TreeNode(9);
            TreeNode C = root.right = new TreeNode(20);
            C.left = new TreeNode(15);
            C.right = new TreeNode(7);

            return root;
        }

        public static TreeNode BuildTree(int[] nums)
        {
            return BuildTreeLevelOrder(nums, null, 0);
        }

        private static TreeNode BuildTreeLevelOrder(int[] nums, TreeNode root, int i)
        {
            if (i < nums.Length)
            {
                root = new TreeNode(nums[i]);

                root.left = BuildTreeLevelOrder(nums, root.left, 2 * i + 1);
                root.right = BuildTreeLevelOrder(nums, root.right, 2 * i + 2);
            }

            return root;
        }

        public static TreeNode BuildNullableTree(int?[] nums)
        {
            return BuildNullableTreeLevelOrder(nums, null, 0);
        }

        private static TreeNode BuildNullableTreeLevelOrder(int?[] nums, TreeNode root, int i)
        {
            if (i < nums.Length )
            {
                root = nums[i].HasValue? new TreeNode(nums[i].Value) : null;

                if (root != null)
                {
                    root.left = BuildNullableTreeLevelOrder(nums, root.left, 2 * i + 1);
                    root.right = BuildNullableTreeLevelOrder(nums, root.right, 2 * i + 2);
                }
            }

            return root;
        }

        public static void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left);
            Console.WriteLine(root.val);
            InOrder(root.right);
        }

        public static void PreOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.val);
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public static void PostOrder(TreeNode root)
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
