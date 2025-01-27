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
        distinct_subsequences s = new();
        int d = s.NumDistinct("rabbbit", "rabbit");
    }
}
