namespace Algorithms.LeetCode;

public class longest_substring_without_repeating_characters
{
    public int LengthOfLongestSubstring(string s)
    {
        return LengthOfLongestSubstringStartingAt(s.ToCharArray(), 0, 0, 0);
    }

    public int LengthOfLongestSubstringStartingAt(char[] s, int lowerBound, int largestFoundYet, int initialUpperBound)
    {
        if (lowerBound > s.Length - 1)
        {
            return Math.Max(0, largestFoundYet);
        }

        int numUniqueChars = initialUpperBound - lowerBound;
        for (int upperBound = initialUpperBound; upperBound < s.Length; upperBound++)
        {
            for (int i = lowerBound; i < upperBound; i++)
            {
                if (s[i] == s[upperBound])
                {
                    return LengthOfLongestSubstringStartingAt(s, i + 1, Math.Max(largestFoundYet, numUniqueChars), upperBound + 1);
                }
            }

            numUniqueChars++;
        }

        return Math.Max(numUniqueChars, largestFoundYet);
    }
}
