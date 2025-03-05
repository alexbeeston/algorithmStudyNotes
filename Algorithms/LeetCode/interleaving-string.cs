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
        return Helper(s1, s2, s3, 0, 0, 0);
    }

    public bool Helper(string s1, string s2, string target, int i, int j, int k)
    {
        // base cases
        if (k == target.Length)
        {
            return i == s1.Length && j == s2.Length;
        }
        else if (i == s1.Length)
        {
            if (j < s2.Length && target[k] == s2[j])
            {
                return Helper(s1, s2, target, i, j + 1, k + 1);
            }
            else
            {
                return false;
            }
        }
        else if (j == s2.Length)
        {
            if (i < s1.Length && target[k] == s1[i])
            {
                return Helper(s1, s2, target, i + 1, j, k + 1);
            }
            else
            {
                return false;
            }
        }

        // recursive cases
        else if (target[k] == s1[i] && target[k] == s2[j])
        {
            return
                Helper(s1, s2, target, i + 1, j, k + 1) ||
                Helper(s1, s2, target, i, j + 1, k + 1);
        }
        else if (target[k] == s1[i])
        {
            return Helper(s1, s2, target, i + 1, j, k + 1);
        }
        else if (target[k] == s2[j])
        {
            return Helper(s1, s2, target, i, j + 1, k + 1);
        }
        else
        {
            return false;
        }
    }
}
