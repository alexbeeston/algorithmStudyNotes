using algorithms.leetcode;
using Algorithms.LeetCode;
using Newtonsoft.Json;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        maximum_subarray s = new();
        int a = s.MaxSubArrayDivideAndConquer([-1, 1000, 3, 2, -2, 1, -100, 4, 4]);
    }
}
