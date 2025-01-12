using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class find_the_index_of_the_first_occurrence_in_a_string
{
    public int StrStr(string haystack, string needle)
    {
        int i = 0;
        int startingIndex = -1;
        while (true)
        {
            while (i < haystack.Length && haystack[i] != needle[0])
            {
                i++;
            }

            if (i == haystack.Length)
            {
                return -1;
            }

            startingIndex = i;
            int j = 0;
            while (i < haystack.Length && j < needle.Length && needle[j] == haystack[i])
            {
                i++;
                j++;
            }

            if (j == needle.Length)
            {
                return startingIndex;
            }
        }
    }
}
