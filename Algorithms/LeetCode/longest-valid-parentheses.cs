namespace Algorithms.LeetCode;

public class longest_valid_parentheses
{
	public int LongestValidParentheses(string s)
	{
			// ()(()
			// ()(())
			// ()(()))
			// "(()(((()" stack size 4, numPops = 2, last pop @ i = 2 maxI = 7

		int i = 0;
		int maxFoundValidParentheses = 0;
		int lastValidSize = 0;
		while (i < s.Length)
		{
			int numPops = 0;
			int stackSize = 0;
			do
			{
				if (s[i] == '(')
				{
					stackSize++;
				}
				else
				{
					if (stackSize > 0)
					{
						numPops++;
					}

					stackSize--;
				}

				i++;
			}
			while (i < s.Length && stackSize > 0);

			int currentValidSize = numPops * 2;
			if (stackSize == 0)
			{
				currentValidSize += lastValidSize;
			}

			maxFoundValidParentheses = Math.Max(maxFoundValidParentheses, currentValidSize);
			lastValidSize = currentValidSize;
		}

		return maxFoundValidParentheses;
	}
}
