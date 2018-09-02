using System;
namespace questions
{
    // https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/description/

    //Given a sorted linked list, delete all nodes that have duplicate numbers, 
    //leaving only distinct numbers from the original list.
    //Example 1:
    //Input: 1->2->3->3->4->4->5
    //Output: 1->2->5
    //Example 2:
    //Input: 1->1->1->2->3
    //Output: 2->3
    public class RemoveDuplicateII
    {
        //TODO
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode fast = head.next;
            int last = fast.val;

            while (fast.next != null)
            {
                if (fast.next != null &&
                    fast.val == fast.next.val &&
                    fast.val == last)
                {
                    fast.next = fast.next.next;
                }
                else
                {
                    last = fast.next.val;
                    fast = fast.next;
                }
            }

            return head;
        }
    }
}
