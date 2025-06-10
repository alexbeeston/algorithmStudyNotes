namespace Algorithms.LeetCode;

// 3442
public class maximum_difference_between_even_and_odd_frequency_i
{
    public int MaxDifference(string s)
    {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!frequencies.ContainsKey(c))
            {
                frequencies[c] = 0;
            }

            frequencies[c]++;
        }

        int maxOdd = 0;
        int minEven = int.MaxValue;
        foreach (char c in frequencies.Keys)
        {
            if (frequencies[c] % 2 == 0)
            {
                minEven = Math.Min(minEven, frequencies[c]);
            }
            else
            {
                maxOdd = Math.Max(maxOdd, frequencies[c]);
            }
        }

        return maxOdd - minEven;
    }
}
