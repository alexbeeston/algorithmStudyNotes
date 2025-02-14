using System.Diagnostics;

namespace Algorithms.LeetCode;

public class jump_game_ii
{
    // #45


    // Recursive; honestly, this is more intuitive to me than the iterative approach below, even though
    // they're exactly the same
    public int JumpRecursive(int[] nums)
    {
        return RecursiveHelper(nums, 0, 0, 0);
    }

    private int RecursiveHelper(int[] nums, int start, int end, int numJumps)
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

        return RecursiveHelper(nums, end + 1, maxIndex, numJumps + 1);
    }

    // Iterative
    public int JumpIterative(int[] nums)
    {
        int start = 0;
        int maxIndex = 0;
        int numJumps = 0;
        while (maxIndex < nums.Length - 1)
        {
            int end = maxIndex;
            for (int i = start; i <= end; i++)
            {
                maxIndex = Math.Max(i + nums[i], maxIndex);
            }

            start = end + 1;
            numJumps++;
        }

        return numJumps;
    }
}
