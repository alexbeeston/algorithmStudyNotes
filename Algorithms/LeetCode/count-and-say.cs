using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class count_and_say
{
	// recursive
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
