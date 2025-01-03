namespace Algorithms.LeetCode;

public class Generate_parentheses
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new List<string>();
        Helper(result, string.Empty, 0, n);
        return result;
    }

    private void Helper(List<string> possibilities, string prefix, int openPairs, int remainingPairs)
    {
        if (openPairs == 0 && remainingPairs == 0)
        {
            possibilities.Add(prefix);
        }

        if (remainingPairs > 0)
        {
            Helper(possibilities, prefix + "(", openPairs + 1, remainingPairs - 1);
        }

        if (openPairs > 0)
        {
            Helper(possibilities, prefix + ")", openPairs - 1, remainingPairs);
        }
    }
}
