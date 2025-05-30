namespace Algorithms.LeetCode;

public class unique_paths_ii
{
    private int Counter = 0;

    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        Worker(obstacleGrid, 0, 0, obstacleGrid.Length - 1, obstacleGrid[0].Length - 1);
        return Counter;
    }

    private void Worker(int[][] obstacleGrid, int m, int n, int maxM, int maxN) // assumes m and n are valid squares; could be initial, obstacle, or destination
    {
        if (obstacleGrid[m][n] == 1)
        {
            return;
        }
        else if (m == maxM && n == maxN)
        {
            Counter++;
            return;
        }

        if (m < maxM)
        {
            Worker(obstacleGrid, m + 1, n, maxM, maxN);
        }

        if (n < maxN)
        {
            Worker(obstacleGrid, m, n + 1, maxM, maxN);
        }
    }
}
