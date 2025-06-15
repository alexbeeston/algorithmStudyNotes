namespace Algorithms;
public class temp
{
	public int MinTimeToVisitAllPoints(int[][] points)
	{
		if (points.Length == 1) return 0;

		int totalTime = 0;
		for (int i = 0; i < points.Length - 1; i++)
		{
			totalTime += GetTimeBetweenTwoPoints(points[i][0], points[i][1], points[i + 1][0], points[i + 1][1]);
		}

		return totalTime;
	}

	// [[3,2],[-2,2]]

	private int GetTimeBetweenTwoPoints(int x1, int y1, int x2, int y2)
	{
		x1 = Math.Abs(x1);
		x2 = Math.Abs(x2);
		y1 = Math.Abs(y1);
		y2 = Math.Abs(y2);

		int xDiff = Math.Abs(x2 - x1);
		int yDiff = Math.Abs(y2 - y1);

		int totalTime = 0;
		bool eitherIsZero = xDiff == 0 || yDiff == 0;
		if (!eitherIsZero) // simplify this logic
		{
			totalTime = Math.Abs(xDiff - yDiff);
			totalTime += Math.Max(xDiff, yDiff) - totalTime;
			return totalTime;
		}
		else
		{
			return Math.Abs(xDiff - yDiff);
		}
	}
}
