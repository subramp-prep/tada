using System;
namespace questions
{
    public class BST : TreeNode
    {
        BST(int x) : base(x)
        {

        }

        public void Insert(TreeNode head, int data)
        {
            if (head == null)
            {
                head = new TreeNode(data);
                return;
            }

            if (data >= head.val)
            {
                // Insert to the RIGHT

                if (head.right != null)
                {
                    Insert(head.right, data);
                }
                else
                {
                    head.right = new TreeNode(data);
                }
            }
            else
            {
                // Insert to the LEFT

                if (head.left != null)
                {
                    Insert(head.left, data);
                }
                else
                {
                    head.left = new TreeNode(data);
                }
            }
        }

        public void Delete(TreeNode head, int data)
        {
            TreeNode current = head;
            TreeNode parent = head;
            bool isLeftNode = false;

            if (head.val == data)
            {
                head = null;
                return;
            }

            while (current != null && current.val != data)
            {
                parent = current;

                if (current.val > data)
                {
                    current = current.right;
                    isLeftNode = true;
                }
                else
                {
                    current = current.left;
                }
            }

            if (current.right == null && current.left == null)
            {
                // case where current's LEFT & RIGHT are NULL

                if (current == head)
                {
                    head = null;
                }
                else
                {
                    if (isLeftNode)
                    {
                        parent.left = null;
                    }
                    else
                    {
                        parent.right = null;
                    }
                }
            }
            else if (current.right == null)
            {
                // case where RIGHT node is NULL

                if (current == head)
                {
                    head = current.left;
                }
                else if (isLeftNode)
                {
                    parent.left = current.left;
                }
                else
                {
                    parent.right = current.left;
                }
            }
            else if (current.left == null)
            {
                // case where LEFT node is NULL

                if (current == head)
                {
                    head = current.right;
                }
                else if (isLeftNode)
                {
                    parent.left = current.right;
                }
                else
                {
                    parent.right = current.right;
                }
            }
            else
            {
                // case where the node has both LEFT & RIGHT
            }
        }

        public int FindLargest_Recursive(TreeNode head)
        {
            if (head.right == null)
                return head.val;

            return FindLargest_Recursive(head.right);
        }

        public int FindSmallest_Recursive(TreeNode head)
        {
            if (head.left == null)
            {
                return head.val;
            }

            return FindSmallest_Recursive(head.left);
        }

        public int FindSmallest_Iterative(TreeNode head)
        {
            if (head == null)
            {
                return -1;
            }

            int min = head.val;

            while (head.left != null)
            {
                min = head.left.val;
                head = head.left;
            }

            return min;
        }
    }
}
