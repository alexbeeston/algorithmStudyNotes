namespace Algorithms.LeetCode;

public class decode_ways
{
	// #91
	public int NumDecodings(string s)
	{
		int[] possibilities = new int[s.Length];
		for (int i = 0; i < s.Length; i++)
		{
			if (i == 0)
			{
				possibilities[0] = IsValid(s.Substring(0, 1)) ? 1 : 0;
			}
			else
			{
				if (IsValid(s.Substring(i, 1)))
				{
					possibilities[i] = possibilities[i - 1];
				}

				if (IsValid(s.Substring(i - 1, 2)))
				{
					possibilities[i] += i == 1 ? 1 : possibilities[i - 2];
				}
			}
		}

		return possibilities[s.Length - 1];
	}

	private bool IsValid(string subString)
	{
		if (subString.Length == 1)
		{
			return subString[0] != '0';
		}
		else
		{
			if (subString[0] == '1')
			{
				return true;
			}
			else if (subString[0] == '2')
			{
				return
					subString[1] == '0' ||
					subString[1] == '1' ||
					subString[1] == '2' ||
					subString[1] == '3' ||
					subString[1] == '4' ||
					subString[1] == '5' ||
					subString[1] == '6';
			}
			else
			{
				return false;
			}
		}
	}
}
