using System.Text;

namespace Algorithms.LeetCode;

public class count_and_say_recursive
{
	public string CountAndSay(int n)
	{
		if (n == 1)
		{
			return "1";
		}
		else
		{
			string lastAnswer = CountAndSay(n - 1);
			int i = 0;
			int j = 0;
			StringBuilder s = new();
			while (i < lastAnswer.Length)
			{
				while (i + j < lastAnswer.Length && lastAnswer[i] == lastAnswer[i + j])
				{
					j++;
				}

				s.Append(j);
				s.Append(lastAnswer[i]);
				i += j;
				j = 0;
			}

			return s.ToString();
		}
	}

}
public class count_and_say_iterative
{
	public string CountAndSay(int n)
	{
		string s = "1";
		for (int loopCounter = 2; loopCounter <= n; loopCounter++)
		{
			int i = 0;
			int j = 0;
			StringBuilder sb = new();
			while (i < s.Length)
			{
				while (i + j < s.Length && s[i] == s[i + j])
				{
					j++;
				}

				sb.Append(j);
				sb.Append(s[i]);
				i += j;
				j = 0;
			}

			s = sb.ToString();
		}

		return s;
	}
}
