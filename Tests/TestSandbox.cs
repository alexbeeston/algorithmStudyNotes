using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        string_to_integer_atoi s = new();
        Assert.IsTrue(s.MyAtoi("42") == 42);
    }
}
