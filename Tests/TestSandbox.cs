using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox
{
    [TestMethod]
    public void Sandbox()
    {
        longest_palindromic_substring s = new();
        s.LongestPalindrome("cbbd");
    }
}
