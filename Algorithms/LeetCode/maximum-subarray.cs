using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode
{
    public class maximum_subarray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (sum < 0)
                {
                    sum = nums[i];
                }
                else
                {
                    sum += nums[i];
                }

                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
