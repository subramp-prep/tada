using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/binary-search-tree-iterator/description/
    //Implement an iterator over a binary search tree(BST). 
    //Your iterator will be initialized with the root node of a BST.
    //Calling next() will return the next smallest number in the BST.
    //Note: next() and hasNext() should run in average O(1) time and uses O(h) memory, 
    //where h is the height of the tree.
    public class BSTIterator
    {
        Stack<TreeNode> _nodes = new Stack<TreeNode>();
        public BSTIterator(TreeNode root)
        {
            PushAllNodes(root);
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return _nodes.Count > 0;
        }

        /** @return the next smallest number */
        public int Next()
        {
            var topNode = _nodes.Pop();

            PushAllNodes(topNode.right);

            return topNode.val;
        }

        private void PushAllNodes(TreeNode root)
        {
            while (root != null)
            {
                _nodes.Push(root);
                root = root.left;
            }
        }
    }
}
