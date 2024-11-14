namespace Algorithms.Sorting
{
    public static class InsertionSort
    {
        public static void Main(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int stopIndex = i - 1;
                while (stopIndex >= 0 && arr[i] < arr[stopIndex])
                {
                    stopIndex--;
                }

                for (int j = i - 1; j > stopIndex; j--)
                {
                    Utils.SwapItems(arr, j, j + 1);
                }
            }
        }
    }
}
