namespace Algorithms.LeetCode;

public class mergeTwoLists
{
	public ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		// init
		ListNode head;
		if (list1 == null && list2 == null)
		{
			return null;
		}
		else if (list1 == null)
		{
			head = list2;
			list2 = list2.next;
		}
		else if (list2 == null)
		{
			head = list1;
			list1 = list1.next;
		}
		else if (list1.val <= list2.val)
		{
			head = list1;
			list1 = list1.next;
		}
		else
		{
			head = list2;
			list2 = list2.next;
		}

		ListNode sortedList = head;
		while (list1 != null && list2 != null)
		{
			if (list1 == null)
			{
				sortedList.next = list2;
				list2 = list2.next;
			}
			else if (list2 == null)
			{
				sortedList.next = list1;
				list1 = list1.next;
			}
			else if (list1.val <= list2.val)
			{
				sortedList.next = list1;
				list1 = list1.next;
			}
			else
			{
				sortedList.next = list2;
				list2 = list2.next;
			}

			sortedList = sortedList.next;
		}

		return head;
	}
}