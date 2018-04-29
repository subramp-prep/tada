using System;
namespace questions
{
    //https://leetcode.com/problems/linked-list-cycle-ii/description/ 
    //Given a linked list, return the node where the cycle begins.
    //If there is no cycle, return null.

    //Note: Do not modify the linked list.

    //Follow up:
    //Can you solve it without using extra space?
    public class LLCycleII
    {
        public static ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (slow != null && slow.next != null && 
                   fast != null && fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    // cycle detected
                    slow = head;

                    while (slow != fast)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }

                    return slow;
                }
            }

            return null;
        }
    }
}
