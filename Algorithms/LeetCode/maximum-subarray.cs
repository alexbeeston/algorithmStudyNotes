using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode
{
    public class maximum_subarray
    {
        /// <summary>
        /// Kadane's algorithm
        /// </summary>
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

        public int MaxSubArrayDivideAndConquer(int[] nums)
        {
            return MaxSubArrayHelper(nums, 0, nums.Length - 1);
        }

        public int MaxSubArrayHelper(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return nums[left];
            }

            int mid = (left + right) / 2;
            int sum = nums[mid];
            int midToLeftMax = sum;
            for (int i = mid - 1; i >= left; i--)
            {
                sum += nums[i];
                midToLeftMax = Math.Max(midToLeftMax, sum);
            }

            sum = nums[mid + 1];
            int midToRightMax = sum;
            for (int i = mid + 2; i <= right; i++)
            {
                sum += nums[i];
                midToRightMax = Math.Max(midToRightMax, sum);
            }

            int max = Math.Max(midToLeftMax, midToRightMax);
            max = Math.Max(max, midToLeftMax + midToRightMax);
            max = Math.Max(max, MaxSubArrayHelper(nums, left, mid));
            max = Math.Max(max, MaxSubArrayHelper(nums, mid + 1, right));
            return max;
        }
    }
}
