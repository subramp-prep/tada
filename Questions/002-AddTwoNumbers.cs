namespace questions
{
    //Question URL : https://leetcode.com/problems/add-two-numbers/description/
    //You are given two non-empty linked lists representing two non-negative integers.
    //The digits are stored in reverse order and each of their nodes contain a single digit.
    //Add the two numbers and return it as a linked list.
    //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    //Example
    //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    //Output: 7 -> 0 -> 8
    //Explanation: 342 + 465 = 807.
    public class AddTwoNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The perform.</returns>
        /// <param name="l1">L1.</param>
        /// <param name="l2">L2.</param>
        public ListNode Perform(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode result = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                int n1 = 0;
                int n2 = 0;
                int sum = 0;

                if (l1 != null)
                {
                    n1 = l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    n2 = l2.val;
                    l2 = l2.next;
                }

                sum = n1 + n2 + carry;
                carry = sum / 10;

                result.next = new ListNode(sum % 10);
                result = result.next;
            }

            return dummy.next;
        }
    }
}
