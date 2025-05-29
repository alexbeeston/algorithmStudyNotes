
// #131
namespace Algorithms.LeetCode
{
    public class palindrome_partitioning
    {
        // good test case: acacbcb & eedeedfdedfd
        public IList<IList<string>> Partition(string s)
        {
            List<int>[] palindromeLengths = new List<int>[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                palindromeLengths[i] = ComputePalindromes(s, i);
            }

            List<IList<string>> partitions = new List<IList<string>>();
            Worker(palindromeLengths, partitions, s, 0, []);
            return partitions;
        }

        private List<int> ComputePalindromes(string s, int i)
        {
            List<int> palindromeLengths = new List<int>();
            int length = 1;
            while (i + length <= s.Length)
            {
                string subString = s.Substring(i, length);
                if (subString == new string(subString.Reverse().ToArray()))
                {
                    palindromeLengths.Add(length);
                }

                length++;
            }

            return palindromeLengths;
        }

        private void Worker(List<int>[] palindromeLengths, List<IList<string>> partitions, string s, int i, string[] previousPartitions)
        {
            if (i == s.Length)
            {
                partitions.Add(previousPartitions);
                return;
            }

            foreach (int palindromeLength in palindromeLengths[i])
            {
                Worker(palindromeLengths, partitions, s, i + palindromeLength, [..previousPartitions, s.Substring(i, palindromeLength)]);
            }
        }
    }
}
