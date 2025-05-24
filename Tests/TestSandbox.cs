using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        simplify_path s = new();
        s.SimplifyPath("/../");
    }
}
