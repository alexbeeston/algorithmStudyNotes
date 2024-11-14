namespace Algorithms;

public static class QuickSelect
{
    /// <summary>
    /// Returns the kth largest element in <paramref name="arr"/>.
    /// </summary>
    public static int Main(int[] arr, int k)
    {
        if (arr.Length < k)
        {
            throw new ArgumentException("Insufficient items in arr");
        }
        else if (arr.Length == 1)
        {
            return arr[0];
        }

        int pivotIndex = Utils.QuickPivot(arr, 0, arr.Length - 1);
        if (pivotIndex == k - 1)
        {
            return arr[pivotIndex];
        }
        else if (arr[k - 1] < arr[pivotIndex])
        {
            int[] copy = new int[pivotIndex];
            Array.Copy(arr, 0, copy, 0, pivotIndex - 1);
            return Main(copy, k);
        }
        else
        {
            int[] copy = new int[arr.Length - pivotIndex - 1];
            Array.Copy(arr, pivotIndex + 1, copy, 0, arr.Length - pivotIndex);
            return Main(copy, k - 1 - pivotIndex);
        }
    }
}
