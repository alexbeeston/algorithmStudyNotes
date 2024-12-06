namespace Algorithms.LeetCode;

/*
 * - processing a sorted list in a certain order may allow you to prune out everything above or below a certain point.
 * - optimizing the function without changing the run time may get you past the timeout period; don't be afraid to try.
 * - in trying to optimize the function without changing the run time, that may help you see a solution in a shorter runtime.
 */

public class container_with_most_water
{
	public int MaxArea(int[] height)
	{
		int maxArea = 0;
		for (int i = height.Length - 1; i > 0; i--)
		{
			int maxAreaOfI = 0;
			int bestHeightForI = -1;
			for (int j = 0; j < i; j++)
			{
				if (height[j] > bestHeightForI)
				{
					int candidateArea = Math.Min(height[i], height[j]) * (i - j);
					if (candidateArea > maxAreaOfI)
					{
						maxAreaOfI = candidateArea;
						bestHeightForI = height[j];
					}

					if (height[j] >= height[i])
					{
						break;
					}
				}
			}

			maxArea = Math.Max(maxArea, maxAreaOfI);
		}

		return maxArea;
	}
}
