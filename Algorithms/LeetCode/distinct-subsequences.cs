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
        int[] dp = new int[s.Length];
        int total;
        int letterRequiredQuantity = 1;
        for (int T = 0; T < t.Length; T++)
        {
            if (T > 0 && t[T] == t[T - 1])
            {
                letterRequiredQuantity++;
            }
            else
            {
                letterRequiredQuantity = 1;
            }

            total = T == 0 ? 1 : 0;
            int cummulativeLetterOccurances = 0;
            for (int S = 0; S < s.Length; S++)
            {
                if (s[S] == t[T])
                {
                    if (letterRequiredQuantity > 1)
                    {
                        cummulativeLetterOccurances++;
                        if (cummulativeLetterOccurances >= letterRequiredQuantity)
                        {
                            total += dp[S];
                        }

                        dp[S] = total;
                    }
                    else
                    {
                        dp[S] = total;
                    }
                }
                else
                {
                    if (T > 0 && s[S] == t[T - 1])
                    {
                        total += dp[S];
                    }

                    dp[S] = 0;
                }
            }
        }

        total = 0;
        for (int i = 0; i < dp.Length; i++)
        {
            total += dp[i];
        }

        return total;
    }
}
