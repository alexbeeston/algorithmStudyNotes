namespace Algorithms.LeetCode;

public class longest_valid_parentheses
{
    public int LongestValidParentheses(string s)
    {
        int i = 0;
        int longestValidParenthesis = 0;
        Stack<int> stack = new Stack<int>();
        int startIndexOfCurrentCandidate = 0;
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
