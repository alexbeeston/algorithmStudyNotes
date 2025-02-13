using System.Diagnostics;

namespace Algorithms.LeetCode;

public class jump_game_ii
{
    // #45
    public int Jump(int[] nums)
    {
        int[] distances = new int[nums.Length];
        int maxDistance = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i + nums[i] > maxDistance)
            {
                maxDistance = i + nums[i];
                distances[i + nums[i]] = distances[i] + 1;
            }

        }

        return 
    }
}
