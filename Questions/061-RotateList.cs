using System;
namespace questions
{
    //Question URL: https://leetcode.com/problems/rotate-list/description/
    //Given a list, rotate the list to the right by k places, where k is non-negative.
    //Example:
    //Given 1->2->3->4->5->NULL and k = 2,
    //return 4->5->1->2->3->NULL.
    public class RotateList
    {
        public static ListNode RotateRight(ListNode head, int k)
        {
            ListNode temp = head;
            ListNode tail = head;
            int count = 1;

            while (tail.next != null)
            {
                tail = tail.next;
                count++;
            }

            tail.next = head; // connected head to tail to make circular list

            k %= count;
            int pivot = count - k;
            while (pivot > 0)
            {
                tail = tail.next;
                pivot--;
            }

            ListNode newHead = tail.next;
            tail.next = null;

            return newHead;
        }
    }
}
