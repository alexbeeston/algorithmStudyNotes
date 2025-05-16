using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        next_permutation s = new();
        int[] testCase = [3, 2, 1];
        s.NextPermutation(testCase);
    }
}
