using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        int numColumns = ((s.Length / (2 * numRows)) + 1) * numRows;
        char[,] chars = new char[numRows, numColumns];
        for (int i = 0; i < s.Length; i++)
        {
            (int rowInsertIndex, int columnInsertIndex) = GetCoordinates(i, numRows, s.Length);
            chars[rowInsertIndex, columnInsertIndex] = s[i];
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numColumns; j++)
            {
                if (chars[i, j] != default)
                {
                    sb.Append(chars[i, j]);
                }
            }
        }

        return sb.ToString();
    }

    public static (int row, int column) GetCoordinates(int stoppingIndex, int numRows, int stringLength)
    {
        int row;
        int columnOffset;
        int remainder = stoppingIndex % (2 * (numRows - 1));
        if (remainder < numRows)
        {
            row = remainder;
            columnOffset = 0;
        }
        else
        {
            row = (2 * (numRows - 1)) - remainder;
            columnOffset = remainder - numRows + 1;
        }

        int zigGroup = stoppingIndex / (2 * (numRows - 1));
        return (row, zigGroup * (numRows - 1) + columnOffset);
    }
}