using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Determine the minimum number of changes that are required to make to an array of integers
 * such that all subarrays of length k have equal sums.
 */
namespace Study;

public static class Problems
{
	public static int GetMinChanges(List<int> numbers, int k)
	{
		int numRequiredChanges = 0;
		for (int j = 0; j < k; j++)
		{
			Dictionary<int, int> frequencyOfNumbers = new();
			for (int i = j; i < numbers.Count; i += k)
			{
				if (!frequencyOfNumbers.ContainsKey(numbers[i]))
				{
					frequencyOfNumbers.Add(numbers[i], 0);
				}

				frequencyOfNumbers[numbers[i]]++;

			}

			int mostFrequencyNumber = frequencyOfNumbers.MaxBy(x => x.Value).Key;
			numRequiredChanges += frequencyOfNumbers.Where(x => x.Key != mostFrequencyNumber).Select(x => x.Value).Sum();
		}

		return numRequiredChanges;
	}
}
