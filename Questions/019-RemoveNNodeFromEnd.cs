using System;
namespace questions
{
	/// <summary>
	/// Question URL: https://leetcode.com/problems/remove-nth-node-from-end-of-list
	/// </summary>
	public class RemoveNNodeFromEnd
    {
        /// <summary>
        /// Removes the nth from end.
        /// </summary>
        /// <returns>The nth from end.</returns>
        /// <param name="head">Head.</param>
        /// <param name="n">N.</param>
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
