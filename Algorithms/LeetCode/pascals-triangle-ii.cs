namespace Algorithms.LeetCode;

public class pascals_triangle_ii
{
    public IList<int> GetRow(int rowIndex)
    {
        int[] row = new int[rowIndex + 1];
        for (int i = 0; i <= rowIndex; i++)
        {
            Worker(row, i);
        }

        return row;
    }

    public void Worker(int[] row, int i)
    {
        int nextValue = 1;
        for (int j = 0; j <= i + 1; j++) // on jth iteration, prepare to insert into row[j-1] on iteration j+1
        {
            if (j == 0)
            {
                nextValue = 1;
            }
            else if (j < i)
            {
                int temp = row[j - 1] + row[j];
                row[j - 1] = nextValue;
                nextValue = temp;
            }
            else if (j == i)
            {
                row[j - 1] = nextValue;
                nextValue = 1;
            }
            else // j == i + 1
            {
                row[i] = 1;
            }
        }
    }
}
