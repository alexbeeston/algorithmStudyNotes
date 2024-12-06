using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

/* Things I learned
 * - consider the processing order, especially of a sorted list e.g., if you have a list of line numbers in a file to edit, start from the bottom and work up so the line numbers are preserved as you work up.
 */

public class container_with_most_water
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        for (int i = height.Length - 1; i < 0; i--)
        {
            int heightOfMaxArea = -1;
            for (int j = 0; j < i; j++)
            {
                if (height[j] > heightOfMaxArea)
                {
                    int candidateArea = Math.Min(height[i], height[j]) * (i - j);
                    maxArea = Math.Max(maxArea, candidateArea);
                    heightOfMaxArea = height[j];
                }
            }
        }

        return maxArea;
    }
}
