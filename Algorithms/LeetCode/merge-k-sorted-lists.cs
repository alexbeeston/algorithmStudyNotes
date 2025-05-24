namespace Algorithms.LeetCode;

public class merge_k_sorted_lists
{
	public ListNode MergeKLists(ListNode[] lists)
	{
		if (lists.Length == 0)
		{
			return null;
		}

		List<ListNode> listOfLists = lists.Where(x => x != null).ToList();
		(ListNode head, ListNode tail) = GetMinHead(listOfLists);
		if (head == null)
		{
			return null;
		}

		Helper(listOfLists, tail);
		return head;
	}

	private void Helper(List<ListNode> lists, ListNode tail)
	{
		(ListNode newHead, ListNode newTail) = GetMinHead(lists);
		if (newHead == null)
		{
			return;
		}

		tail.next = newHead;
		Helper(lists, newTail);
	}

	private (ListNode head, ListNode tail) GetMinHead(List<ListNode> lists) // assumes each value is not null
	{
		int minValue = int.MaxValue;
		List<int> indiciesOfMinValue = new List<int>();
		for (int i = 0; i < lists.Count(); i++)
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

		if (indiciesOfMinValue.Count == 0)
		{
			return (null, null);
		}
		else
		{
			List<int> emptyLists = new List<int>();
			ListNode head = lists[indiciesOfMinValue[0]];
			if (AdvanceListHead(lists, indiciesOfMinValue[0]))
			{
				emptyLists.Add(0);
			}

			ListNode tail = head;
			for (int j = 1; j < indiciesOfMinValue.Count; j++)
			{
				tail.next = lists[indiciesOfMinValue[j]];
				tail = tail.next;
				if (AdvanceListHead(lists, indiciesOfMinValue[j]))
				{
					emptyLists.Add(j);
				}
			}

			for (int j = emptyLists.Count - 1; j >= 0; j++)
			{
				lists.RemoveAt(emptyLists[j]);
			}

			return (head, tail);
		}
	}

	private bool AdvanceListHead(List<ListNode> lists, int i)
	{
		lists[i] = lists[i].next;
		return lists[i] == null;
	}
}
