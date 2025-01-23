using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class climbing_stairs
{
    public int ClimbStairsDynamic(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        int[] dpTable = new int[n];
        dpTable[0] = 1;
        dpTable[1] = 2;
        for (int i = 2; i < n; i++)
        {
            dpTable[i] = dpTable[i - 1] + dpTable[i - 2];
        }

        return dpTable[n - 1];
    }

    public int ClimbStairsRecursive(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }
        else
        {
            return ClimbStairsRecursive(n - 1) + ClimbStairsRecursive(n - 2);
        }
    }
}
