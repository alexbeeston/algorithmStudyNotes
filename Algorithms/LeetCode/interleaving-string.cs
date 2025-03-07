using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

// #97
public class interleaving_string
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length == 0 && s2.Length == 0 && s3.Length == )
        {
            return true;
        }
        else if (s1.Length + s2.Length != s2.Length)
        {
            return false;
        }

        bool[,] dpTable = new bool[s1.Length + 1, s2.Length + 1];
        for (int i = 0; i < s1.Length + 1; i++)
        {
            for (int j = 0; j < s2.Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    // out of range 
                    dpTable[0, 1] = s1[0] == s3[0];
                    dpTable[1, 0] = s2[0] == s3[0];
                }
                else if (dpTable[i,j])
                {
                    char charWeNeed = s3[i + j - 1];
                    dpTable[i, j + 1] = s1[i - 1] == charWeNeed;
                    dpTable[i + 1, j] = s2[j - 1] == charWeNeed;
                }
            }
        }

        return dpTable[s1.Length, s2.Length];
    }
}
