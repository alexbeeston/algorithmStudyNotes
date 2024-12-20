using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox
{
    [TestMethod]
    public void Sandbox()
    {
        palindrome_number s = new();
        Assert.IsTrue(s.IsPalindrome(1000110001));
        Assert.IsTrue(s.IsPalindrome(1221));
        Assert.IsTrue(s.IsPalindrome(2222));
        Assert.IsTrue(s.IsPalindrome(0));
        Assert.IsTrue(s.IsPalindrome(1));
        Assert.IsTrue(s.IsPalindrome(909));
        Assert.IsTrue(s.IsPalindrome(121212121));
        Assert.IsTrue(s.IsPalindrome(4004));
        Assert.IsTrue(s.IsPalindrome(400004));
        Assert.IsTrue(s.IsPalindrome(4664));
        Assert.IsTrue(s.IsPalindrome(46664));

        Assert.IsFalse(s.IsPalindrome(10));
        Assert.IsFalse(s.IsPalindrome(90000));
        Assert.IsFalse(s.IsPalindrome(100));
        Assert.IsFalse(s.IsPalindrome(1000000));
        Assert.IsFalse(s.IsPalindrome(38283721));
        Assert.IsFalse(s.IsPalindrome(45561));
        Assert.IsFalse(s.IsPalindrome(1561));
        Assert.IsFalse(s.IsPalindrome(9933));
    }
}
