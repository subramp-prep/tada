using System;
namespace questions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode AddNodeToTail(ListNode head, ListNode node)
        {
            if (head == null)
            {
                return node;
            }

            ListNode cache = null;
            ListNode temp = head;

            while (temp != null)
            {
                cache = temp;
                temp = temp.next;
            }
            cache.next = node;

            return head;
        }

        public static ListNode Reverse(ListNode head)
        {
            ListNode result = null;
            while (head != null)
            {
                ListNode next = head.next;  // cache next
                head.next = result;         // assign next
                result = head;              // cache head
                head = next;                // assign head
            }

            return result;
        }

        public static int GetCount(ListNode head)
        {
            int count = 0;

            while (head != null)
            {
                head = head.next;
                count++;
            }

            return count;
        }
    }
}
