using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/intersection-of-two-linked-lists/
    //Write a program to find the node at which the intersection of two singly linked lists begins.
    //For example, the following two linked lists:

    //A:          a1 → a2
    //                   ↘
    //                     c1 → c2 → c3
    //                   ↗            
    //B:     b1 → b2 → b3
    //begin to intersect at node c1.
    //Notes:

    //If the two linked lists have no intersection at all, return null.
    //The linked lists must retain their original structure after the function returns.
    //You may assume there are no cycles anywhere in the entire linked structure.
    //Your code should preferably run in O(n) time and use only O(1) memory.


    public class IntersectionOfLL
    {
        // Brute force mechanism to find the intersection... Trust me.. Very Boring!!!
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
