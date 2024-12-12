using System.Security.AccessControl;

namespace Algorithms.LeetCode;
internal class _3sum
{
	public IList<IList<int>> ThreeSum(int[] nums)
	{
		// sort list
		List<int> numbers = nums.Order().ToList();

		// deal with three zeros
		List<IList<int>> combos = new List<IList<int>>();
		if (numbers.FindAll(x => x == 0).Count >= 3)
		{
			combos.Add(new List<int> { 0, 0, 0 });
		}

		// create a list of nums equal to or greater than zero
		List<int> positives = numbers.Where(x => x >= 0).ToList();

		// create a list of nums less than zero
		List<int> negatives = numbers.Where(x => x < 0).ToList();

		// for each combination of positive nums, take their sum and use binary search to see if there exists a counterpart in the negatives
		FindMatches(positives, negatives, combos);
		FindMatches(negatives, positives, combos);

		return combos;
	}

	private void FindMatches(List<int> listA, List<int> listB, List<IList<int>> matches)
	{
		for (int i = 0; i < listA.Count - 1; i++)
		{
			if (i > 0 && listA[i-1] == listA[i])
			{
				continue;
			}

			for (int j = i + 1; j < listA.Count; j++)
			{
				int sum = listA[i] + listA[j];
				if (listB.Exists(x => x + sum == 0))
				{
					matches.Add(new List<int> { listA[i], listA[j], sum * -1 });
				}
			}
		}
	}
}
