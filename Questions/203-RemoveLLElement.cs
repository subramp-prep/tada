using System;
namespace questions
{
    //Question URL: https://leetcode.com/problems/remove-linked-list-elements/description/
    //Remove all elements from a linked list of integers that have value val.

    //Example
    //Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
    //Return: 1 --> 2 --> 3 --> 4 --> 5
    public class RemoveLLElement
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummy = new ListNode(0);
            ListNode final = dummy;

            while (head != null)
            {
                if (head.val != val)
                {
                    final.next = new ListNode(head.val);
                    final = final.next;
                }

                head = head.next;
            }
                
            return dummy.next;
        }
    }
}
