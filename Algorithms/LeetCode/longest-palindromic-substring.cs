using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class longest_palindromic_substring
{
	public string LongestPalindrome(string s)
	{
		int maxLength = -1;
		int maxStartingIndex = -1;
		for (int i = 0; i < s.Length; i++)
		{
			int oddLength = GetPalindromicSize(s, i, false) * 2 + 1;
			int evenLength = 0;
			if (i < s.Length - 1 && s[i] == s[i + 1])
			{
				evenLength = GetPalindromicSize(s, i, true) * 2 + 2;
			}

			if (oddLength > maxLength)
			{
				maxLength = oddLength;
				maxStartingIndex = i - ((oddLength - 1) / 2);
			}

			if (evenLength > maxLength)
			{
				maxLength = evenLength;
				maxStartingIndex = i - ((evenLength - 2) / 2);

			}
		}

		return s.Substring(maxStartingIndex, maxLength);
	}

	public int GetPalindromicSize(string s, int center, bool isEven, int knownPalindromicLength = 0)
	{
		int leftTest = center - knownPalindromicLength - 1;
		int rightTest = center + knownPalindromicLength + 1;
		if (isEven)
		{
			rightTest++;
		}

		if (leftTest < 0)
		{
			return knownPalindromicLength;
		}
		else if (rightTest > s.Length - 1)
		{
			return knownPalindromicLength;
		}
		else
		{
			return s[leftTest] == s[rightTest] ? GetPalindromicSize(s, center, isEven, knownPalindromicLength + 1) : knownPalindromicLength;
		}
	}
}
