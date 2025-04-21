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
        median_of_two_sorted_arrays s = new();
        var r = s.FindMedianSortedArrays([1], []);
    }
}
