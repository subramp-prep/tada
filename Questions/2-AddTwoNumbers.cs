namespace questions
{
    public class AddTwoNumbers
    {
        /// <summary>
        /// Question URL : https://leetcode.com/problems/add-two-numbers/description/
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
