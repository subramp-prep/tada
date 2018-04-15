using System;
namespace questions
{
	// Question URL: https://leetcode.com/problems/remove-nth-node-from-end-of-list
    //Given a linked list, remove the n-th node from the end of list and return its head.

    //Example:
    //Given linked list: 1->2->3->4->5, and n = 2.

    //After removing the second node from the end, the linked list becomes 1->2->3->5.
    //Note:
    //Given n will always be valid.

    //Follow up:
    //Could you do this in one pass?
	public class RemoveNNodeFromEnd
    {
		public static ListNode RemoveNthFromEnd(ListNode head, int n)
		{
            ListNode dummmy = new ListNode(0)
            {
                next = head
            };

            ListNode fast = dummmy;
            ListNode slow = dummmy;

            for (int index = 0; fast != null; index++)
            {
                fast = fast.next;

                // to start iterating when the 
                // limit is reached on the fast
                // so that the slow stops when 
                // the fast pointer reaches null
                if (index > n)
                {
                    slow = slow.next;
                }
            }

            slow.next = slow.next.next;

            return dummmy.next;
        }
    }
}
