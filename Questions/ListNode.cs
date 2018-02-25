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
	}
}
