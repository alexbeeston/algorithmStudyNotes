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

    private double GetMedian(int[] arr1, int arr1L, int arr1R, int[] arr2, int arr2L, int arr2R, int rank)
    {
        if (arr1.Length == 0 && arr2.Length == 0)
        {
            throw new Exception("Both arrays are empty.");
        }
        else if (arr1.Length == 0)
        {
            // get median or get rank?
        }
        else if (arr2.Length == 0)
        {
            // get median or get rank?
        }
        else
        {
            (double arr1Median, int arr1Partition) = GetMedian(arr1, arr1L, arr1R);
            (double arr2Median, int arr2Partition) = GetMedian(arr2, arr2L, arr2R);
            int numElementsInArr1LeftPartition = arr1Partition - arr1L + 1;
            int numElementsInArr2LeftPartition = arr2Partition - arr2L + 1;

            if (arr1Median >= arr2Median)
            {
                return GetMedian(arr1, )

            }
            else
            {

            }
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
