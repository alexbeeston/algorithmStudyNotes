namespace Algorithms.LeetCode;

public class longest_valid_parentheses
{
	public int LongestValidParentheses(string s)
	{
		int longestValidParenthesis = 0;
		Stack<int> stack = new Stack<int>();
		int startIndexOfCurrentCandidate = 0;

		for (int i = 0; i < s.Length; i++)
		{
			if (s[i] == '(')
			{
				stack.Push(i);
			}
			else
			{
				if (stack.Count == 0)
				{
					// we didn't find a new max length

				}
				else
				{
					stack.Pop();
				}
			}
		}

		while (i < s.Length)
		{
			if (s[i] == '(')
			{
				stack.Push(i);
			}
			else
			{
				if (stack.Count == 0)
				{
					longestValidParenthesis = Math.Max(longestValidParenthesis, i - startIndexOfCurrentCandidate);
					startIndexOfCurrentCandidate = i + 1;
				}
				else
				{
					stack.Pop();
				}
			}

			i++;
		}

		int startOfValid = stack.Count == 0 ? startIndexOfCurrentCandidate : stack.Peek() + 1;
		return Math.Max(longestValidParenthesis, i - startOfValid);
	}
}
