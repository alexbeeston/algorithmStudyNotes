using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

// #97
public class interleaving_string
{
	public bool IsInterleave(string s1, string s2, string s3)
	{
		if (s1.Length == 0 && s2.Length == 0 && s3.Length == 0)
		{
			return true;
		}
		else if (s1.Length + s2.Length != s3.Length)
		{
			return false;
		}

		bool[,] dpTable = new bool[s1.Length + 1, s2.Length + 1];
		dpTable[0, 0] = true;
		for (int i = 0; i < dpTable.GetLength(0); i++)
		{
			for (int j = 0; j < dpTable.GetLength(1); j++)
			{
				if (dpTable[i, j] && (i != dpTable.GetLength(0) - 1 || j != dpTable.GetLength(1) - 1))
				{
					char charWeNeed = s3[i + j];
					if (i + 1 < dpTable.GetLength(0) && s1[i] == charWeNeed)
					{
						dpTable[i + 1, j] = true;
					}

					if (j + 1 < dpTable.GetLength(1) && s2[j] == charWeNeed)
					{
						dpTable[i, j + 1] = true;
					}
				}
			}
		}

		return dpTable[s1.Length, s2.Length];
	}
}
