namespace Algorithms.Sorting;

public static class BubbleSort
{
    public static void Main(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return;
        }

        for (int maxCompareIndex = arr.Length - 1; maxCompareIndex > 0; maxCompareIndex--)
        {
            bool didASwap = false;
            for (int i = 0; i < maxCompareIndex; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    didASwap = true;
                    Utils.SwapItems(arr, i, i + 1);
                }
            }

            if (!didASwap)
            {
                return;
            }
        }
    }
}
