using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        mergeTwoLists s = new();
        ListNode list1 = new ListNode
        {
            val = 1,
            next = new ListNode
            {
                val = 2,
                next = new ListNode
                {
                    val = 4,
                    next = null,
                },
            },
        };

        ListNode list2 = new ListNode
        {
            val = 1,
            next = new ListNode
            {
                val = 3,
                next = new ListNode
                {
                    val = 4,
                    next = null,
                },
            },
        };

        s.MergeTwoLists(list1, list2);
    }
}
