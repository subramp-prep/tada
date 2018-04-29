using System;
namespace questions
{
    //https://leetcode.com/problems/linked-list-cycle/description/
    //Given a linked list, determine if it has a cycle in it.
    //Follow up:
    //Can you solve it without using extra space?
    public class LLCycle
    {
        public static bool HasCycle(ListNode head)
        {
            ListNode p1 = head;
            ListNode p2 = head;

            while (p1 != null && p2 != null && p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;

                if (p2 != null && p1.val == p2.val)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
