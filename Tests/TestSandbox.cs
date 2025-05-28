using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        restore_valid_ip_addresses s = new();
        IList<string> a = s.RestoreIpAddresses("101023");
    }
}
