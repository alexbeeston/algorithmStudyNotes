using System.Reflection.Metadata.Ecma335;

namespace Algorithms.LeetCode;

public class median_of_two_sorted_arrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // assume for now sum of lengths is odd
        int rank = nums1.Length + nums2.Length / 2;
        return GetMedian(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, rank);
    }

    private double GetMedian(int[] array1, int array1_left, int array1_right, int[] array2, int array2_left, int array2_right, int rank)
    {
        if (array1.Length == 0 && array2.Length == 0)
        {
            throw new Exception("Both arrays are empty.");
        }
        else if (array1.Length == 0)
        {
            if (array2)
            return array2[array2]
        }
        else if (array2.Length == 0)
        {
            return GetMedian(array1);
        }
        else
        {
            // what if other array is length 1?
            int arr1Partition = array1.Length / 2;




            return 10;
        }
    }

    /// <summary>
    /// Returns the median and the index at which it and all elements to its left are guaranteed to be less than or equal to the median.
    /// </summary>
    private (double, int) GetMedian(int[] arr, int left, int right)
    {
        int diff = right - left;
        if (diff < 0)
        {
            throw new Exception("Can't get median of an empty array");
        }
        else if (diff == 0)
        {
            return (arr[left], left);
        }
        else if (diff % 2 == 0) // odd number of elements
        {
            return (arr[diff], diff);
        }
        else // even number of elements
        {
            double median = ((double)arr[diff] + arr[diff + 1]) / 2;
            return (median, diff);
        }
    }
}
