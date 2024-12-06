namespace Algorithms.LeetCode;

/*
 * - processing a sorted list in a certain order may allow you to prune out everything above or below a certain point.
 * - processing a list from both left and right sides is a thing.
 * - optimizing the function without changing the run time may get you past the timeout period; don't be afraid to try.
 * - in trying to optimize the function without changing the run time, that may help you see a solution in a shorter runtime.
 * - consider what you're moving away from in addition to what you may be moving towards.
 */

public class container_with_most_water
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            int candidateArea = Math.Min(height[left], height[right]) * (right - left);
            if (candidateArea > maxArea)
            {
                maxArea = candidateArea;
            }

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
