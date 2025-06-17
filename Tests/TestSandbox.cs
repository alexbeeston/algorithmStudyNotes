using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        word_ladder s = new();
        int d = s.LadderLength("hit", "cog", ["hot", "dot", "dog", "lot", "log", "cog"]); // output is 5
    }
}
