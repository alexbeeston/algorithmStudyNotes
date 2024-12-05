using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class container_with_most_water
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i + 1; j < height.Length; j++)
            {
                int candidateArea = Math.Min(height[i], height[j]) * (j - i);
                maxArea = Math.Max(maxArea, candidateArea);
            }
        }

        return maxArea;
    }
}
