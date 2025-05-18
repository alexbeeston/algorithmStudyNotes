namespace Algorithms.LeetCode;

public class swap_nodes_in_pairs
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        else if (head.next == null)
        {
            return head;
        }

        ListNode newHead = Swap(head);
        Worker(newHead.next, newHead.next.next);
        return newHead;
    }

    public void Worker(ListNode B, ListNode C)
    {
        // Given A -> B -> C, where A and B have already undergone swapping
        if (C == null || C.next == null)
        {
            return;
        }

        B.next = Swap(C);
        Worker(B.next.next, B.next.next?.next);
    }

    public ListNode Swap(ListNode A) // assumes that A.next isn't null (?)
    {
        // Given A -> B -> C, modify to B -> A -> C
        ListNode B = A.next;
        A.next = A.next.next;
        B.next = A;
        return B;
    }
}
