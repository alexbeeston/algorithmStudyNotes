using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class MinWindow
{
    [TestMethod]
    public void MinWindowTest()
    {

        List<ThreeStrings> list = new List<ThreeStrings>()
        {
            //new ThreeStrings("aaaaPPaq", "PPq", "PPaq")
            new ThreeStrings("abc", "bc", "bc")
        };

        minimum_window_substring s = new();
        foreach (var testCase in list)
        {
            string solution = s.MinWindow(testCase.s, testCase.t);
            Assert.IsTrue(testCase.a == solution, $"s = '{testCase.s}', t = '{testCase.t}', a = '{testCase.a}', solution = '{solution}'");
        }
    }
}

public class ThreeStrings
{
    public ThreeStrings(string s, string t, string answer)
    {
        this.s = s;
        this.t = t;
        this.a = answer;
    }

    public string s { get; set; }

    public string t { get; set; }

    public string a { get; set; }
}
