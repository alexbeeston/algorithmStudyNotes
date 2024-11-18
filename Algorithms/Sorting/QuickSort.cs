namespace Algorithms.Sorting;

public static class QuickSort
{
    public static void Main(int[] arr)
    {
        QuickSortWorker(arr, 0, arr.Length - 1);
    }

    private static void QuickSortWorker(int[] arr, int left, int right)
    {
        if (right <= left)
        {
            return;
        }

        int pivot = Utils.Partition(arr, left, right);
        QuickSortWorker(arr, left, pivot - 1);
        QuickSortWorker(arr, pivot + 1, right);
    }
}
