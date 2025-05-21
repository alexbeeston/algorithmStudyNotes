namespace Algorithms.LeetCode;

public class merge_k_sorted_lists
{
	public ListNode MergeKLists(ListNode[] lists)
	{
		if (lists.Length == 0)
		{
			return null;
		}

		ListNode head = GetMinHead(lists);
		if (head == null)
		{
			return head;
		}

		Helper(lists, head);
		return head;
	}

	private void Helper(ListNode[] lists, ListNode tail)
	{
		ListNode minNode = GetMinHead(lists);
		if (minNode == null)
		{
			return;
		}

		tail.next = minNode;
		Helper(lists, tail.next);
	}

	private ListNode? GetMinHead(ListNode[] lists)
	{
		int minValue = int.MaxValue;
		int indexOfMinValue = -1;
		for (int i = 0; i < lists.Length; i++)
		{
			if (lists[i] != null && lists[i].val < minValue)
			{
				minValue = lists[i].val;
				indexOfMinValue = i;
			}
		}

		if (indexOfMinValue == -1)
		{
			return null;
		}
		else
		{
			ListNode node = lists[indexOfMinValue];
			lists[indexOfMinValue] = node.next;
			return node;
		}
	}
}
