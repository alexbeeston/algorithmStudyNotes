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

        // If at this point, I have a row in atOrAbove that is [3, 3, 1, 3], how can I produce the result 6 in linear time?
        // how about if I have [1, 9, 9], how would I get to 18 in linear time? or [1, 9, 7], how would I get to 14? How
        // do I know left and right indices are?

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
