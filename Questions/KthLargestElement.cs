using System;
using System.Collections.Generic;

namespace questions
{
    //GIven the root of a BST and an integer k, design a function
    //that find the k largest elements in the BST. For example, if 
    //the input to your function is the BST
    //          19
    //       /      \
    //     7         43
    //   /   \      /   \
    //  3     11   23   47 
    // / \      \   \     \
    //2   5     17  37     53
    //              /  /  \
    //             13 29  41
    //                 \
    //                 31
    // and k=3, your function should return {54,, 47, 43}
    public class KthLargestElement1
    {
        public static IList<int> FindElements(TreeNode root, int k)
        {
            IList<int> output = new List<int>();

            FindElementsHelper(root, k, output);

            return output;
        }
        
        private static void FindElementsHelper(TreeNode root, int k, IList<int> elements)
        {
            if(root == null) return;

            if (root.right != null && elements.Count < k)
            {
                FindElementsHelper(root.right, k, elements);

                if (elements.Count < k)
                {
                    elements.Add(root.val);

                    FindElementsHelper(root.left, k, elements);
                }
            }
        }
    }
}
