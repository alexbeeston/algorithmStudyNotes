namespace Algorithms.LeetCode;

public class restore_valid_ip_addresses
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> validIps = new List<string>();
        Worker(s, 0, validIps, 1, string.Empty);
        return validIps;
    }

    public void Worker(string s, int i, List<string> validIps, int currentOctet, string currentIp)
    {
        if (currentOctet == 5)
        {
            if (i == s.Length)
            {
                validIps.Add(currentIp.Substring(0, currentIp.Length - 1));
            }

            return;
        }
        else if (i == s.Length)
        {
            return;
        }

        // take just one digit
        Worker(s, i + 1, validIps, currentOctet + 1, currentIp + s[i] + ".");

        // take two digits if no leading zero and length permits
        int remainingDigits = s.Length - i;
        if (s[i] != '0' && remainingDigits >= 2)
        {
            Worker(s, i + 2, validIps, currentOctet + 1, currentIp + s.Substring(i, 2) + ".");
        }

        // take three digits if no leading zero, length permits, and less than 256
        if (s[i] != '0' && remainingDigits >= 3)
        {
            int parseInt = int.Parse(s.Substring(i, 3));
            if (parseInt < 256)
            {
                Worker(s, i + 3, validIps, currentOctet + 1, currentIp + s.Substring(i, 3) + ".");
            }
        }
    }
}
