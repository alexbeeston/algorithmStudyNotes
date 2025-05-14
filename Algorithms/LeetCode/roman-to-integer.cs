namespace Algorithms.LeetCode;

public class roman_to_integer
{
    public int RomanToInt(string s)
    {
        return Helper(s, 0, 0);
    }

    public int Helper(string s, int i, int cummulative)
    {
        if (i == s.Length)
        {
            return cummulative;
        }
        else if (i < s.Length - 1 && s[i] == 'I' && s[i + 1] == 'V')
        {
            return Helper(s, i + 2, cummulative + 4);
        }
        else if (i < s.Length - 1 && s[i] == 'I' && s[i + 1] == 'X')
        {
            return Helper(s, i + 2, cummulative + 9);
        }
        else if (i < s.Length - 1 && s[i] == 'X' && s[i + 1] == 'L')
        {
            return Helper(s, i + 2, cummulative + 40);
        }
        else if (i < s.Length - 1 && s[i] == 'X' && s[i + 1] == 'C')
        {
            return Helper(s, i + 2, cummulative + 90);
        }
        else if (i < s.Length - 1 && s[i] == 'C' && s[i + 1] == 'D')
        {
            return Helper(s, i + 2, cummulative + 400);
        }
        else if (i < s.Length - 1 && s[i] == 'C' && s[i + 1] == 'M')
        {
            return Helper(s, i + 2, cummulative + 900);
        }
        else if (s[i] == 'I')
        {
            return Helper(s, i + 1, cummulative + 1);
        }
        else if (s[i] == 'V')
        {
            return Helper(s, i + 1, cummulative + 5);
        }
        else if (s[i] == 'X')
        {
            return Helper(s, i + 1, cummulative + 10);
        }
        else if (s[i] == 'L')
        {
            return Helper(s, i + 1, cummulative + 50);
        }
        else if (s[i] == 'C')
        {
            return Helper(s, i + 1, cummulative + 100);
        }
        else if (s[i] == 'D')
        {
            return Helper(s, i + 1, cummulative + 500);
        }
        else if (s[i] == 'M')
        {
            return Helper(s, i + 1, cummulative + 1000);
        }
        else
        {
            throw new Exception("Unreachable");
        }
    }
}
