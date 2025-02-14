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
        jump_game_ii s = new();
        s.JumpRecursive([7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3]);
        s.JumpRecursive([0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 2, 0, 3, 0]);
    }
}
