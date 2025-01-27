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
        int[,] dpTable = new int[t.Length, s.Length];
        int total = 0;
        for (int T = 0; T < t.Length; T++)
        {
            total = T == 0 ? 1 : 0;
            for (int S = 0; S < s.Length; S++)
            {
                if (s[S] == t[T])
                {
                    dpTable[T, S] = total;
                }

                if (T > 0)
                {
                    total += dpTable[T - 1, S];
                }
            }
        }

        total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            total += dpTable[t.Length - 1, i];
        }

        return total;
    }
}
