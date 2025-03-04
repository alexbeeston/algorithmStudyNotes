using System.Diagnostics.Tracing;

namespace Algorithms.LeetCode;

// # 85. Maximal Rectangle
public class maximal_rectangle
{
    public int MaximalRectangle(char[][] matrix)
    {
        int[,] atOrAbove = new int[matrix.Length, matrix[0].Length];
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (i == 0)
                {
                    atOrAbove[0, j] = matrix[0][j] == '1' ? 1 : 0;
                }
                else
                {
                    atOrAbove[i, j] = matrix[i][j] == '0' ? 0 : 1 + atOrAbove[i - 1, j];
                }
            }
        }

        int maxArea = 0;
        for (int i = 0; i < atOrAbove.GetLength(0); i++)
        {
            int left = 0;
            while (left < atOrAbove.GetLength(1))
            {
                if (atOrAbove[i, left] != 0)
                {
                    int minHeight = atOrAbove[i, left];
                    int right = left;
                    while (right < atOrAbove.GetLength(1) && atOrAbove[i, right] != 0)
                    {
                        minHeight = Math.Min(minHeight, atOrAbove[i, right]);
                        right++;
                        maxArea = Math.Max(maxArea, minHeight * (right - left));
                    }
                }

                left++;
            }
        }

        return maxArea;
    }
}
