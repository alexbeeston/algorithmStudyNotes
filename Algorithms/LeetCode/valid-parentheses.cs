namespace Algorithms.LeetCode;

public class valid_parentheses
{
    private enum Chars
    {
        Paran,
        Curly,
        Square,
    }

    private Stack<Chars> stack = new Stack<Chars>();

    public bool IsValid(string s)
    {
        foreach (char c in s)
        {
            if (c == '(')
            {
                stack.Push(Chars.Paran);
            }
            else if (c == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                Chars top = stack.Pop();
                if (top != Chars.Paran)
                {
                    return false;
                }
            }
            else if (c == '[')
            {
                stack.Push(Chars.Square);
            }
            else if (c == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                Chars top = stack.Pop();
                if (top != Chars.Square)
                {
                    return false;
                }
            }
            if (c == '{')
            {
                stack.Push(Chars.Curly);
            }
            else if (c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                Chars top = stack.Pop();
                if (top != Chars.Curly)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
