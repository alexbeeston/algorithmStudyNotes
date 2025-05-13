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
        else if (sizeA == 1)
        {
            if (numsA[0] >= numsB[k - 2])
            {
                return Math.Min(numsA[0], numsB[k - 1]);
            }
            else
            {
                return numsB[k - 1];
            }
        }
        else if (sizeB == 1)
        {
            if (numsB[0] >= numsA[k - 2])
            {
                return Math.Min(numsB[0], numsA[k - 1]);
            }
            else
            {
                return numsA[k - 1];
            }
        }

        int aMid = sizeA / 2;
        int bMid = sizeB / 2;
        int totalItems = sizeA + sizeB;
        bool aIsLTE = numsA[aMid] <= numsB[bMid];
        // if k - 1 == size / 2 (and size is odd), then kth smallest cannot be in bright
        return aIsLTE ?
                SelectKthSmallestAssumingAIsSmaller(numsA, aLeft, aMid, aRight, numsB, bLeft, bMid, bRight, totalItems, k) :
                SelectKthSmallestAssumingAIsSmaller(numsB, bLeft, bMid, bRight, numsA, aLeft, aMid, aRight, totalItems, k);
    }

    // if include mid with either left or right halves, you'll always have at least half the element in total

    private int SelectKthSmallestAssumingAIsSmaller(int[] numsA, int aLeft, int aMid, int aRight, int[] numsB, int bLeft, int bMid, int bRight, int totalItems, int k)
    {
        int medianItem = totalItems / 2;
        if (k < medianItem)
        {
            // prune bRight
            int nextBRight;
            if (bLeft == bRight)
            {
                nextBRight = bLeft - 1;
            }
            else if (bMid == bRight)
            {
                nextBRight = bMid - 1;
            }
            else
            {
                nextBRight = bMid;
            }

            return GetKthSmallestItem(numsA, aLeft, aRight, numsB, bLeft, nextBRight, k);
        }
        else
        {
            // prune aLeft
            int nextALeft;
            if (aLeft == aRight)
            {
                k--;
                nextALeft = aLeft + 1;
            }
            else if (aMid == aRight)
            {
                k--;
                nextALeft = aRight;
            }
            else
            {
                k -= aMid - aLeft;
                nextALeft = aMid;
            }

            return GetKthSmallestItem(numsA, nextALeft, aRight, numsB, bLeft, bRight, k);
        }
    }

    public string GetDebugString(int aLeft, int aRight, int bLef, int bRight, int k)
    {
        return $"ALeft = {aLeft}, ARight = {aRight}, BLeft = {bLef}, BRight = {bRight}, k = {k}";
    }
}
