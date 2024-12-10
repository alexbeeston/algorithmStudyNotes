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
			int leftOdd = GetLeftMostPalindromicIndex(s, i, i);
			int leftEven = GetLeftMostPalindromicIndex(s, i, i + 1);

			int oddLength = (i - leftOdd) * 2 + 1;
			if (oddLength > maxLength)
			{
				maxStartingIndex = leftOdd;
				maxLength = oddLength;
			}

			int evenLength = (i - leftEven) * 2 + 2;
			if (evenLength > maxLength)
			{
				maxStartingIndex = leftEven;
				maxLength = evenLength;
			}
		}

		return s.Substring(maxStartingIndex, maxLength);
	}

	public int GetLeftMostPalindromicIndex(string s, int left, int right)
	{
		if (left < 0 || right > s.Length - 1)
		{
			return left + 1;
		}
		else if (s[left] == s[right])
		{
			return GetLeftMostPalindromicIndex(s, left - 1, right + 1);
		}
		else
		{
			return left + 1;
		}
	}
}
