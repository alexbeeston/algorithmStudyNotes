using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class distinct_subsequences
{
	public int NumDistinct(string s, string t)
	{
		int[] dpTable = new int[s.Length];
		return Helper(s, t, 0, dpTable);
	}

	private int Helper(string s, string t, int T, int[] dpTable)
	{
		int total = T == 0 ? 1 : 0;
		int returnTotal = 0;
		for (int S = 0; S < s.Length; S++)
		{
			if (s[S] == t[T])
			{
				int temp = dpTable[S];
				dpTable[S] = total;
				total += temp;
			}
			else
			{
				total += dpTable[S];
				dpTable[S] = 0;
			}

			if (T == t.Length - 1)
			{
				returnTotal += dpTable[S];
			}
		}

		if (T == t.Length - 1)
		{
			return returnTotal;
		}
		else
		{
			return Helper(s, t, T + 1, dpTable);
		}
	}
}
