using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class distinct_subsequences
{
    public int NumDistinct(string s, string t)
    {
        int[] dpTable = new int[s.Length];
        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == t[0])
            {
                dpTable[i] = 1;
            }
        }

        for (int T = 1; T < t.Length; T++)
        {
            total = 0;
            for (int S = 0; S < s.Length; S++)
            {
                int current = dpTable[S];
                if (s[S] == t[T])
                {
                    dpTable[S] = total;
                }
                else
                {
                    dpTable[S] = 0;
                }

                total += current;
            }
        }

        total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            total += dpTable[s.Length - 1];
        }

        return total;
    }
}
