using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/reverse-linked-list/description/
    // Reverse a singly linked list.
    public class ReverseLL
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode result = null;

            while(head != null)
            {
                ListNode next = head.next;
                head.next = result;
                result = head;
                head = next;
            }

            return result;
        }
    }
}
