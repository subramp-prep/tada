using System;
namespace questions
{
    public class RemoveDup
    {
        //https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/
        //Given a sorted linked list, delete all duplicates such 
        //that each element appear only once.

        //Example 1:
        //Input: 1->1->2
        //Output: 1->2

        //Example 2:
        //Input: 1->1->2->3->3
        //Output: 1->2->3
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode node = head;

            while (node != null)
            {
                if (node.next != null &&
                    node.next.val == node.val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }


            return head;
        }

        //public static ListNode DeleteDuplicates(ListNode head)
        //{
        //    ListNode slow = head;
        //    ListNode fast = head;
        //    ListNode result = head;

        //    while (fast != null)
        //    {
        //        if (slow.val != fast.val)
        //        {
        //            slow.next = fast;
        //            slow = slow.next;
        //        }

        //        fast = fast.next;
        //    }


        //    return result;
        //}
    }
}
