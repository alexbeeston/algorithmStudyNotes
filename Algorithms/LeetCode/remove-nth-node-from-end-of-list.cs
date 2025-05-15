namespace Algorithms.LeetCode;

 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> nodes = new();
        ListNode current = head;
        while (current != null){
            nodes.Add(current);
            current = current.next;
        }

        if (n == nodes.Count) {
            if (n == 1) {
                return null;
            }
            else {
                head = nodes[1];
                return head;
            }
        }
        else if (n == 1) {
            nodes[nodes.Count - 2].next = null; // nodes.Length > 1 otherwise first if would execute
        }
        else {
            nodes[nodes.Count - n - 1].next = nodes[nodes.Count - n + 1];
        }

        return head;        
    }
}