using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

// #62
public class unique_paths
{
    public int UniquePathsDynamic(int m, int n)
    {
        int[,] dpTable = new int[m, n];
        
        for (int i = 0; i < m; i++)
        {
            dpTable[i, 0] = 1;
        }
        for (int i = 0; i < n; i++)
        {
            dpTable[0, i] = 1;
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dpTable[i, j] = dpTable[i, j - 1] + dpTable[i - 1, j];
            }
        }

        return dpTable[m - 1, n - 1];
    }

    public int UniquePathsRecursive(int m, int n)
    {
        int total = 0;
        Step(m, n, 1, 1, ref total);
        return total;
    }

    public void Step(int m, int n, int i, int j, ref int total)
    {
        if (i == m && j == n)
        {
            total++;
        }

        if (i < m)
        {
            Step(m, n, i + 1, j, ref total);
        }

        if (j < n)
        {
            Step(m, n, i, j + 1, ref total);
        }
    }
}
