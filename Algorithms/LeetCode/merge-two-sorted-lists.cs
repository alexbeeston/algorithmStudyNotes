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
        return head.next;
    }

    public void Helper(ListNode tail, ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            tail.next = list2;
            list2 = list2.next;
        }
        else if (list2 == null)
        {
            tail.next = list1;
            list1 = list1.next;
        }
        else if (list1.val <= list2.val)
        {
            tail.next = list1;
            list1 = list1.next;
        }
        else
        {
            tail.next = list2;
            list2 = list2.next;
        }

        if (list1 == null && list2 == null)
        {
            return;
        }
        else
        {
            Helper(tail.next, list1, list2);
        }
    }
}