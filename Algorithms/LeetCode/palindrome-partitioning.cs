using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// #131
namespace Algorithms.LeetCode
{
    public class palindrome_partitioning
    {
        // good test case: acacbcb & eedeedfdedfd
        public IList<IList<string>> Partition(string s)
        {
            bool[,] dpTable = new bool[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j < s.Length; j++)
                {
                    string substring = s.Substring(i, j - i + 1);
                    dpTable[i, j] = substring == substring.Reverse();
                }
            }

        }

        private void Dog(string s, int startingIndex, bool[,] dpTable, List<string> currentPalindromes, List<IList<string>> allTime)
        {
            if (startingIndex == s.Length)
            {
                return;
            }
            if (startingIndex == s.Length - 1)
            {

            }

            for (int i = startingIndex; i < s.Length; i++)
            {
                if (dpTable[startingIndex, i])
                {
                    List<string> copy = currentPalindromes.ToArray().ToList();
                    copy.Add(s.Substring(startingIndex, i - startingIndex + 1));
                    Dog(s, startingIndex + 1, dpTable, copy, allTime);
                }
            }
        }
    }
}
