using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        swap_nodes_in_pairs s = new();
        s.SwapPairs(new ListNode
        {
            val = 1,
            next = new ListNode
            {
                val = 2,
                next = new ListNode
                {
                    val = 3,
                    next = new ListNode
                    {
                        val = 4,
                        next = new ListNode
                        {
                            val = 5,
                            //next = new ListNode
                            //{
                            //    val = 6,
                            //},
                        }
                    }
                }
            }
        });
    }
}
