namespace Algorithms.LeetCode;

public class unique_paths_ii
{
    private int Counter = 0;

    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int[,] dpTable = new int[obstacleGrid.Length, obstacleGrid[0].Length];
        for (int i = 0; i < dpTable.GetLength(0); i++)
        {
            for (int j = 0; j < dpTable.GetLength(1); j++)
            {
                if (i == 0 && j == 0 && obstacleGrid[i][j] == 0)
                {
                    dpTable[i, j] = 1;
                }
                else if (obstacleGrid[i][j] == 1)
                {
                    dpTable[i, j] = 0;
                }
                else
                {
                    int aboveAmount = i > 0 ? dpTable[i - 1, j] : 0;
                    int leftAmount = j > 0 ? dpTable[i, j - 1] : 0;
                    dpTable[i, j] = aboveAmount + leftAmount;
                }
            }
        }

        return dpTable[dpTable.GetLength(0) - 1, dpTable.GetLength(1) - 1];
    }
}
