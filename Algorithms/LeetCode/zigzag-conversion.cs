public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        char[] answer = new char[s.Length];
        int answerIndex = 0;
        int zigGroupLength = 2 * (numRows - 1);
        for (int i = 0; i < numRows; i++)
        {
            int stringIndex = i;
            if (i == 0 || i == numRows - 1)
            {
                while (stringIndex < s.Length)
                {
                    answer[answerIndex] = s[stringIndex];
                    stringIndex += zigGroupLength;
                    answerIndex++;
                }
            }
            else
            {
                int gapLength = 2 * (numRows - 1 - i);
                bool invertGap = false;
                while (stringIndex < s.Length)
                {
                    answer[answerIndex] = s[stringIndex];
                    stringIndex += invertGap ? zigGroupLength - gapLength : gapLength;
                    answerIndex++;
                    invertGap = !invertGap;
                }
            }
        }

        return new string(answer);
    }
}