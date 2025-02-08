using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

// #62
public static class unique_paths
{
    // Method 1: Pure recursion, causes recomputations.
    public static int Recursive(int m, int n)
    {
        int total = 0;
        RecursiveHelper(m, n, 1, 1, ref total);
        return total;
    }

    private static void RecursiveHelper(int m, int n, int i, int j, ref int total)
    {
        if (i == m && j == n)
        {
            total++;
        }

        if (i < m)
        {
            RecursiveHelper(m, n, i + 1, j, ref total);
        }

        if (j < n)
        {
            RecursiveHelper(m, n, i, j + 1, ref total);
        }
    }

    // Method 2: Dynamic: better, but for some reason using recursion for the DP Table is faster than doing an m x n dpTable
    public static int Dynamic(int m, int n)
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

    // Method 3: Recursive Dynamic: Not sure why, but does better.
    public static int RecursiveDynamic(int m, int n)
    {
        int[] dpTable = new int[m];
        for (int i = 0; i < m; i++)
        {
            dpTable[i] = 1;
        }

        return RecursiveDynamicHelper(dpTable, m, n, 1);
    }

    private static int RecursiveDynamicHelper(int[] dpTable, int m, int n, int j)
    {
        if (j == n)
        {
            return dpTable[m - 1];
        }

        for (int i = 1; i < m; i++)
        {
            dpTable[i] += dpTable[i - 1];
        }

        return RecursiveDynamicHelper(dpTable, m, n, j + 1);
    }
}
