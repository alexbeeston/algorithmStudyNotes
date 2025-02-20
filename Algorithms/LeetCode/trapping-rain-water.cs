using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

// #42 
public class trapping_rain_water
{
    public int Trap(int[] height)
    {
        int[] maxToLeft = new int[height.Length];
        int[] maxToRight = new int[height.Length];

        // do left
        int max = height[0];
        for (int i = 1; i < height.Length - 1; i++)
        {
            maxToLeft[i] = max;
            max = Math.Max(max, height[i]);
        }

        // do right
        max = height[height.Length - 1];
        for (int i = height.Length - 2; i > 0; i--)
        {
            maxToRight[i] = max;
            max = Math.Max(max, height[i]);
        }

        int total = 0;
        for (int i = 1; i <= height.Length - 2; i++)
        {
            int j = Math.Min(maxToRight[i], maxToLeft[i]);
            if (j > height[i])
            {
                total += j - height[i];
            }
        }

        return total;
    }
}
