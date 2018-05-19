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

        // construct a B-Tree
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

        //construct a B-Tree with NULL elements
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

        // construct a BST
        public static TreeNode BuildBST(int[] nums)
        {
            return BuildBST(nums, 0, nums.Length - 1);
        }

        private static TreeNode BuildBST(int[] nums, int low, int high)
        {
            if (low > high)
            {
                return null;
            }

            int mid = (low + high) / 2;
            TreeNode root = new TreeNode(nums[mid]);

            root.left = BuildBST(nums, low, mid-1);
            root.right = BuildBST(nums, mid + 1, high);

            return root;
        }

        // Left -> Root -> Right
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

        // Root -> Left -> Right
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

        // Left -> Right -> Root
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

        // Identify height of a tree
        // WARNING - THIS METHOD IS EXPENSIVE
        public static int GetTreeHeight_Expensive(TreeNode root)
        {
            if (root == null)
                return 0;

            return Math.Max(GetTreeHeight_Expensive(root.left), 
                            GetTreeHeight_Expensive(root.right)) + 1;
        }

        // Is Tree balanced?
        // WARNING - THIS METHOD IS EXPENSIVE
        public static bool IsTreeBalanced_Expensive(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int diff = GetTreeHeight_Expensive(root.left) - GetTreeHeight_Expensive(root.right);
            if (Math.Abs(diff) > 1)
            {
                return false;
            }
            else
            {
                return IsTreeBalanced_Expensive(root.left) && IsTreeBalanced_Expensive(root.right);
            }
        }

        public static int GetTreeHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftHeight = GetTreeHeight(root.left);
            if (leftHeight == -1)
            {
                return -1;
            }

            int rightHeight = GetTreeHeight(root.right);
            if (rightHeight == -1)
            {
                return -1;
            }

            int diff = leftHeight - rightHeight;
            if (Math.Abs(diff) > 1)
            {
                return -1;
            }
            else
            {
                return Math.Max(GetTreeHeight(root.left),GetTreeHeight(root.right)) + 1;
            }
        }

        public static bool IsTreeBalanced(TreeNode root)
        {
            if (GetTreeHeight(root) == -1)
            {
                return false;
            }

            return true;
        }

        public static TreeNode LCAForBST(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val > Math.Max(p.val, q.val))
            {
                return LCAForBST(root.left, p, q);
            }
            else if (root.val < Math.Min(p.val, q.val))
            {
                return LCAForBST(root.right, p, q);
            }
            else
            {
                return root;
            }
        }

        public static bool IsTreeSymmetric(TreeNode root)
        {
            return IsTreeSymmetric(root.left, root.right);
        }

        private static bool IsTreeSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            else if (left != null && right != null)
            {
                return left.val == right.val &&
                    IsTreeSymmetric(left.left, right.right) &&
                    IsTreeSymmetric(left.right, right.left);
            }
            else
            {
                return false;
            }
        }
    }
}