using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// #55
namespace Algorithms.LeetCode;

public class jump_game
{
    bool CanJump(int[] nums)
    {
        int largestReachableIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (largestReachableIndex == i && nums[i] == 0)
            {
                return i == nums.Length - 1;
            }
            else
            {
                largestReachableIndex = Math.Max(largestReachableIndex, i + nums[i]);
            }
        }

        return true;
    }
}
