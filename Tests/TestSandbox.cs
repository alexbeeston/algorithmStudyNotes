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
        maximal_rectangle s = new();
        s.MaximalRectangle([['1', '0', '1', '0', '0'], ['1', '0', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['1', '0', '0', '1', '0']]);
        //int dog = s.MaximalRectangle([['1']]);
    }
}
