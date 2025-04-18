namespace Algorithms.LeetCode;

public class median_of_two_sorted_arrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        return GetMedian(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1);
    }

    private double GetMedian(int[] array1, int array1_left, int array1_right, int[] array2, int array2_left, int array2_right)
    {
        if (array1.Length == 0 && array2.Length == 0)
        {
            throw new Exception("Both arrays are empty.");
        }
        else if (array1.Length == 0)
        {
            return GetMedian(array2);
        }
        else if (array2.Length == 0)
        {
            return GetMedian(array1);
        }
        else
        {
            return 10;
        }
    }

    private double GetMedian(int[] arr)
    {
        if (arr.Length == 0)
        {
            throw new Exception("Can't get median of an empty array");
        }
        else if (arr.Length == 1)
        {
            return arr[0];
        }
        else if (arr.Length % 2 == 0)
        {
            int mid = arr.Length / 2;
            return (arr[mid] + (double)arr[mid - 1]) / 2;
        }
        else
        {
            int mid = arr.Length / 2;
            return arr[mid];
        }
    }
}
