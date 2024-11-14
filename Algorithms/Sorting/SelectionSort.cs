namespace Algorithms.Sorting;

public static class SelectionSort
{
    public static void Main(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int indexOfSmallestUnsortedElement = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[indexOfSmallestUnsortedElement])
                {
                    indexOfSmallestUnsortedElement = j;
                }
            }

            Utils.SwapItems(arr, i, indexOfSmallestUnsortedElement);
        }
    }
}
