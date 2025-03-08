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
        interleaving_string s = new();
        s.IsInterleave("aabcc", "dbbca", "aadbbcbcac");
    }
}
