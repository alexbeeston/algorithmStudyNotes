namespace Algorithms.LeetCode;

public class mergeTwoLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }

        ListNode head = new ListNode();
        Helper(head, list1, list2);
        return head;
    }

    public void Helper(ListNode tail, ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            tail.val = list2.val;
            list2 = list2.next;
        }
        else if (list2 == null)
        {
            tail.val = list1.val;
            list1 = list1.next;
        }
        else if (list1.val <= list2.val)
        {
            tail.val = list1.val;
            list1 = list1.next;
        }
        else
        {
            tail.val = list2.val;
            list2 = list2.next;
        }

        if (list1 == null && list2 == null)
        {
            return;
        }
        else
        {
            tail.next = new ListNode();
            tail = tail.next;
            Helper(tail, list1, list2);
        }
    }
}