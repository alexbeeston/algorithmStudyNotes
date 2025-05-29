using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        palindrome_partitioning s = new();
        s.Partition("aabbcecb");
    }
}
