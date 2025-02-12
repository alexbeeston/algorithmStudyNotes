namespace Algorithms.LeetCode;

// #64
internal class minimum_path_sum
{
    public int MinPathSum(int[][] grid)
    {
        for (int j = 1; j < grid[0].Length; j++)
        {
            grid[0][j] += grid[0][j - 1];
        }

        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 0;  j < grid[i].Length; j++)
            {
                if (j > 0)
                {
                    grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                }
                else
                {
                    grid[i][j] += grid[i - 1][j];
                }
            }
        }
    }
}
