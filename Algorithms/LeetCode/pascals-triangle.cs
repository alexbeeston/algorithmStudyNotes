using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class pascals_triangle
{
    public IList<IList<int>> GenerateRecursive(int numRows)
    {
        List<IList<int>> triangle = new List<IList<int>>();
        for (int i = 1; i <= numRows; i++)
        {
            triangle.Add(GetPascalRow(i));
        }

        return triangle;
    }

    private List<int> GetPascalRow(int rowNumber)
    {
        if (rowNumber == 1)
        {
            return [1];
        }
        else
        {
            List<int> previousRow = GetPascalRow(rowNumber - 1);
            int[] currentRow = new int[rowNumber];
            for (int i = 0; i < rowNumber; i++)
            {
                if (i == 0 || i == rowNumber - 1)
                {
                    currentRow[i] = 1;
                }
                else
                {
                    currentRow[i] = previousRow[i - 1] + previousRow[i];
                }
            }

            return currentRow.ToList();
        }
    }

    public IList<IList<int>> GenerateDynamic(int numRows)
    {
        List<IList<int>> triangle = [[1]];
        for (int rowNumber = 2; rowNumber <= numRows; rowNumber++)
        {
            List<int> currentRow = new List<int>(rowNumber);
            for (int j = 0; j < rowNumber; j++)
            {
                if (j == 0 || j == rowNumber - 1)
                {
                    currentRow.Add(1);
                }
                else
                {
                    currentRow.Add(triangle[rowNumber - 2][j] + triangle[rowNumber - 2][j - 1]);
                }
            }
            triangle.Add(currentRow);
        }

        return triangle;
    }
}
