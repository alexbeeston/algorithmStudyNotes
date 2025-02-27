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
        decode_ways s = new();
        s.NumDecodings("01323432423423424");
        Assert.IsTrue(true);
    }   
}
