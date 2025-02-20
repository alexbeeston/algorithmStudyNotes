﻿namespace Algorithms.LeetCode;

public class minimum_window_substring
{
	public string MinWindow(string s, string t)
	{
		int minRight = int.MaxValue;
		int minLeft = 0;
		int requirementsMet = 0;

		// initialize requirements array
		int[] requirements = new int[123]; // can optimize space by using length 58 and offsetting by 65
		int[] counts = new int[123];
		foreach (char c in t)
		{
			requirements[c]++;
		}

		// initilize pointers
		int left = 0;
		int right = 0;
		while (right < s.Length && requirements[s[right]] == 0)
		{
			left++;
			right++;
		}

		if (right == s.Length)
		{
			return string.Empty;
		}

		counts[s[right]]++;
		right++;

		while (right < s.Length)
		{
			// 1. advance right until s[r] == s[l]. As you go, if you encouter a letter in t, increment the array
			while (right < s.Length && s[right] != s[left])
			{
				counts[s[right]]++;
				if (counts[s[right]] < requirements[s[right]])
				{
					requirementsMet++;
				}

				right++;
			}

			if (right < s.Length)
			{
				counts[s[right]]++;
				int tempLeft = left + 1;
				bool keep = true;
				while (tempLeft <= right && keep)
				{
					if (requirements[s[tempLeft]] > 0)
					{
						if (counts[s[left]] - 1 >= requirements[s[left]])
						{
							counts[s[left]]--;
							left = tempLeft;
							if (requirementsMet == t.Length && (right - left < minRight - minLeft))
							{
								minRight = right;
								minLeft = left;
							}
						}
						else
						{
							keep = false;
						}
					}

					tempLeft++;
				}

				right++;
			}
		}

		if (requirementsMet == t.Length)
		{
			return s.Substring(minLeft, minRight - minLeft + 1);
		}
		else
		{
			return string.Empty;
		}
	}
}
