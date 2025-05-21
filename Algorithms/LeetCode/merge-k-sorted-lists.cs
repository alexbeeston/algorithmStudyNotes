namespace Algorithms.LeetCode;

public class merge_k_sorted_lists
{
	public ListNode MergeKLists(ListNode[] lists)
	{
		if (lists.Length == 0)
		{
			return null;
		}

		(ListNode head, ListNode tail) = GetMinHead(lists);
		if (head == null)
		{
			return null;
		}

		Helper(lists, tail);
		return head;
	}

	private void Helper(ListNode[] lists, ListNode tail)
	{
		(ListNode newHead, ListNode newTail) = GetMinHead(lists);
		if (newHead == null)
		{
			return;
		}

		tail.next = newHead;
		Helper(lists, newTail);
	}

	private (ListNode head, ListNode tail) GetMinHead(ListNode[] lists)
	{
		int minValue = int.MaxValue;
		List<int> indiciesOfMinValue = new List<int>();
		for (int i = 0; i < lists.Length; i++)
		{
			if (lists[i] != null)
			{
				if (lists[i].val < minValue)
				{
					minValue = lists[i].val;
					indiciesOfMinValue = [i];
				}
				else if (lists[i].val == minValue)
				{
					indiciesOfMinValue.Add(i);
				}
			}
		}

		if (indiciesOfMinValue.Count == 0)
		{
			return (null, null);
		}
		else
		{
			ListNode head = lists[indiciesOfMinValue[0]];
			lists[indiciesOfMinValue[0]] = lists[indiciesOfMinValue[0]].next;
			ListNode tail = head;
			for (int j = 1; j < indiciesOfMinValue.Count; j++)
			{
				tail.next = lists[indiciesOfMinValue[j]];
				tail = tail.next;
				lists[indiciesOfMinValue[j]] = lists[indiciesOfMinValue[j]].next;
			}

			return (head, tail);
		}
	}
}
