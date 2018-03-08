using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/merge-two-sorted-lists/description/
    // Merge two sorted linked lists and return it as a new list. 
    //The new list should be made by splicing together the nodes of the first two lists.
    //Example:
    //Input: 1->2->4, 1->3->4
    //Output: 1->1->2->3->4->4
    public class MergeSortedLists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode nextNode = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val >= l2.val)
                {
                    nextNode.next = l2;
                    l2 = l2.next;

                }
                else
                {
                    nextNode.next = l1;
                    l1 = l1.next;
                }

                nextNode = nextNode.next;
            }

            while (l1 != null)
            {
                nextNode.next = l1;
                l1 = l1.next;

                nextNode = nextNode.next;
            }

            while (l2 != null)
            {
                nextNode.next = l2;
                l2 = l2.next;

                nextNode = nextNode.next;
            }

            return dummy.next;
        }
    
    }
}
