using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        simplify_path s = new();
        string a = s.SimplifyPath("/home//foo/");
    }

    [TestMethod]
    public void AllCases()
    {
        simplify_path s = new();
        List<Tuple<string, string>> testCases = new()
        {
            //new Tuple<string, string>("/", "/"),
            //new Tuple<string, string>("/..", "/"),
            //new Tuple<string, string>("/../", "/"),
            //new Tuple<string, string>("/../", "/"),
            //new Tuple<string, string>("/home//foo/", "/home/foo"),
            //new Tuple<string, string>("/home//////foo/", "/home/foo"),
            //new Tuple<string, string>("/home//////foo//////", "/home/foo"),
            //new Tuple<string, string>("/../", "/"),
            //new Tuple<string, string>("/a/./b/../../c/", "/c"),
            //new Tuple<string, string>("/.abc", "/.abc"),
            new Tuple<string, string>("/..hidden", "/..hidden"),
        };

        foreach (var testCase in testCases)
        {
            string answer = s.SimplifyPath(testCase.Item1);
            Assert.IsTrue(answer == testCase.Item2, $"For '{testCase.Item1}' Expected '{testCase.Item2}', got '{answer}'");
        }
    }
}
