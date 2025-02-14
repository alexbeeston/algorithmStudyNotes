using System.Diagnostics;

namespace Algorithms.LeetCode;

public class jump_game_ii
{
    // #45
    public int Jump(int[] nums)
    {
        return Helper(nums, 0, 0, 0);
    }

    public int Helper(int[] nums, int start, int end, int numJumps)
    {
        if (end >= nums.Length - 1)
        {
            return numJumps;
        }

        int maxIndex = end;
        for (int i = start; i <= end; i++)
        {
            maxIndex = Math.Max(i + nums[i], maxIndex);
        }

        return Helper(nums, end + 1, maxIndex, numJumps + 1);
    }
}
