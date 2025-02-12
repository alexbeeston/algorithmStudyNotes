namespace Algorithms.LeetCode;

public class jump_game_ii
{
	public int Jump(int[] nums)
	{
		int[] distances = Enumerable.Repeat(int.MaxValue, nums.Length).ToArray();
		distances[0] = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = 1; j <= nums[i] && (j + i < nums.Length); j++)
			{
				int index = i + j;
				distances[index] = Math.Min(distances[index], distances[i] + 1);
			}
		}

		return distances[nums.Length - 1];
	}
}
