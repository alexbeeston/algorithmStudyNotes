using Algorithms.LeetCode;

namespace algorithms.leetcode;

public class edit_distance
{
    private int AllTimeMaxDistance = 0;
    public int MinDistance(string word1, string word2)
    {
        int[,] dpTable = new int[word1.Length + 1,word2.Length + 1];
        for (int i = 0; i < word1.Length + 1; i++)
        {
            dpTable[i,0] = i;
        }
        for (int j = 0; j < word2.Length + 1; j++)
        {
            dpTable[0, j] = j;
        }

        for (int i = 1; i < word1.Length + 1; i++)
        {
            for (int j = 1; j < word2.Length + 1; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    dpTable[i, j] = dpTable[i - 1, j - 1];
                }
                else
                {
                    int minValue = Math.Min(dpTable[i - 1, j], dpTable[i - 1, j - 1]);
                    minValue = Math.Min(minValue, dpTable[i, j - 1]);
                    dpTable[i, j] = minValue + 1;
                }
            }
        }

        return dpTable[word1.Length,word2.Length];
    }
}
