using System;
namespace questions
{
    /// <summary>
    /// Question URL: https://leetcode.com/problems/intersection-of-two-linked-lists/
    /// </summary>
    public class IntersectionOfLL
    {
        /// <summary>
        /// Brute force mechanism to find the intersection... Trust me.. Very Boring!!!
        /// </summary>
        /// <returns>The intersection node.</returns>
        /// <param name="headA">Head a.</param>
        /// <param name="headB">Head b.</param>
		public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            for (ListNode index1 = headA; index1 != null; index1 = index1.next)
            {
                for (ListNode index2 = headB; index2 != null; index2 = index2.next)
                {
                    if (index1.val == index2.val)
                    {
                        return index1;
                    }
                }
            }

            return null;
        }

        public static ListNode GetIntesectionOptimum(ListNode headA, ListNode headB)
        {
            int count1 = ListNode.GetCount(headA);
            int count2 = ListNode.GetCount(headB);

            if (count1 > count2)
            {
                return FindIntersection(headA, headB, count1 - count2);
            }
            else
            {
                return FindIntersection(headB, headA, count2 - count1);
            }
        }

        private static ListNode FindIntersection(ListNode headA, ListNode headB, int differenceA)
        {
            for (int index = 0; index < differenceA; index++)
            {
                headA = headA.next;
            }

            while (headA != null && headB != null)
            {
                if (headA.val == headB.val)
                {
                    return headA;
                }
                else
                {
                    headA = headA.next;
                    headB = headB.next;
                }
            }

            return null;
        }
    }
}
