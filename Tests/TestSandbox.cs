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
        integer_to_roman s = new();
        var dog = s.IntToRoman(3000);
        var dog2 = s.IntToRoman(70);
        var dog3 = s.IntToRoman(800);
    }
}
