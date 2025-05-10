namespace Algorithms.LeetCode;

public class median_of_two_sorted_arrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if ((nums1.Length + nums2.Length) % 2 == 0)
        {
            // checked
            int k1 = (nums1.Length + nums2.Length) / 2;
            int num1 = GetKthSmallestItem(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, k1);
            int num2 = GetKthSmallestItem(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, k1 + 1);
            return (double)(num1 + num2) / 2;
        }
        else
        {
            // checked
            int k = (nums1.Length + nums2.Length) / 2 + 1;
            return GetKthSmallestItem(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, k);
        }
    }

    private int GetKthSmallestItem(int[] numsA, int aLeft, int aRight, int[] numsB, int bLeft, int bRight, int k)
    {
        int sizeA = Math.Max(0, aRight - aLeft + 1);
        int sizeB = Math.Max(0, bRight - bLeft + 1);
        if (k > sizeA + sizeB)
        {
            throw new Exception($"K is too big. {GetDebugString(aLeft, aRight, bLeft, bRight, k)}");
        }
        else if (sizeA == 0)
        {
            return numsB[bLeft + k - 1];
        }
        else if (sizeB == 0)
        {
            return numsA[aLeft + k - 1];
        }

        int aMid = sizeA / 2;
        int bMid = sizeB / 2;
        bool aIsLTE = numsA[aMid] <= numsB[bMid];
        // if k - 1 == size / 2 (and size is odd), then kth smallest cannot be in bright
        return aIsLTE ?
                SelectKthSmallestAssumingAIsSmaller(numsA, aLeft, aRight, numsB, bLeft, bRight, k) :
                SelectKthSmallestAssumingAIsSmaller(numsB, bLeft, bRight, numsA, aLeft, aRight, k);
    }

    // if include mid with either left or right halves, you'll always have at least half the element in total

    private int SelectKthSmallestAssumingAIsSmaller(int[] numsA, int aLeft, int aRight, int[] numsB, int bLeft, int bRight, int k)
    {
        int sizeA = aRight - aLeft + 1;
        int sizeB = bRight - bLeft + 1;
        int totalItems = sizeA + sizeB;
        int medianIndex = totalItems / 2;
        if (k < medianIndex)
        {
            // remove out bRight
            bRight = bLeft + (sizeB / 2);
            return GetKthSmallestItem(numsA, aLeft, aRight, numsB, bLeft, bRight, k);
        }
        else
        {
            // remove aLeft
            int amid = aLeft + (sizeA / 2);
            k -= (amid - aLeft);
            return GetKthSmallestItem(numsA, amid, aRight, numsB, bLeft, bRight, k);
        }
    }

    public string GetDebugString(int aLeft, int aRight, int bLef, int bRight, int k)
    {
        return $"ALeft = {aLeft}, ARight = {aRight}, BLeft = {bLef}, BRight = {bRight}, k = {k}";
    }
}
