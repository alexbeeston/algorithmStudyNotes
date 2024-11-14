using Algorithms.Sorting;

namespace Tests;

[TestClass]
public class TestSorting
{
    /// <summary>
    /// Arrays of integers of variable length, including negative and duplicates.
    /// </summary>
    private List<int[]> UnsortedArrays = new List<int[]>
    {
        new int[] { 1 },
        new int[] { 3, -1, 4, -1, 5, 9, -2, 6, 5, 3, -5, 8, 9, -7, 9, 3, -2, 6, 5, -3 },
        new int[] { -10, 4, 3, -5, 6, 4, -8, 7, 2, -3, 5, -6, 4, 2, -1, 0, 3, -4, 6, -2, 1, -7 },
        new int[] { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6, 7, -7, 8, -8, 9, -9, 0, 0, -10, 10, -11 },
        new int[] { 5, 3, -2, 8, -6, 7, -3, 2, -1, 4, -5, 6, -4, 1, -7, 9, -8, 0, 5, -9, 11, -12, 13, -14 },
        new int[] { -3, 6, -1, 7, -2, 8, -4, 9, -5, 0, 3, -6, 2, -7, 1, -8, 4, -9, 5, -10, 6, -11, 7, -12, 8 },
        new int[] { 9, -3, 8, -2, 7, -1, 6, 0, 5, 1, 4, 2, 3, -4, 2, -5, 1, -6, 0, -7, -8, 9, -9, 10, -10, 11 },
        new int[] { 2, -2, 4, -4, 6, -6, 8, -8, 10, -10, 1, -1, 3, -3, 5, -5, 7, -7, 9, -9, 11, -11, 12, -12, 13, -13, 14 },
        new int[] { 0, -1, 1, -2, 2, -3, 3, -4, 4, -5, 5, -6, 6, -7, 7, -8, 8, -9, 9, -10, 10, -11, 11, -12, 12, -13, 13, -14 },
        new int[] { 4, -4, 3, -3, 2, -2, 1, -1, 0, 5, -5, 6, -6, 7, -7, 8, -8, 9, -9, 10, -10, 11, -11, 12, -12, 13, -13, 14, -14 },
        new int[] { 7, -3, 6, -2, 5, -1, 4, 0, 3, 1, 2, -4, 1, -5, 0, -6, -1, -7, -2, -8, 8, -9, 9, -10, 10, -11, 11, -12, 12, -13 },
    };

    private delegate void SortingAlgorithm(int[] arr);

    private void TestSortingAlgorithm(SortingAlgorithm algo)
    {
        foreach (int[] arr in UnsortedArrays)
        {
            algo(arr);

            if (arr.Length > 1)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    Assert.IsTrue(arr[i - 1] <= arr[i]);
                }
            }
        }
    }

    [TestMethod]
    public void TestBubbleSort()
    {
        TestSortingAlgorithm(BubbleSort.Main);
    }
}


    //[TestMethod]
    //public void TestSelectionSort()
    //{
    //	for (int i = 0; i < sortingTests; i++)
    //	{
    //		int[] testCase = GetArrayOfRandomInts(sortingCapacity);
    //		Algorithms.SelectionSort(testCase);
    //		AssertSortedList(testCase, SortingAlgorithm.SelectionSort);
    //	}
    //}

    //[TestMethod]
    //public void TestInsertionSort()
    //{
    //	for (int i = 0; i < sortingTests; i++)
    //	{
    //		int[] testCase = GetArrayOfRandomInts(sortingCapacity);
    //		Algorithms.InsertionSort(testCase);
    //		AssertSortedList(testCase, SortingAlgorithm.SelectionSort);
    //	}
    //}

    //[TestMethod]
    //public void TestQuickSort()
    //{
    //	for (int i = 0; i < sortingTests; i++)
    //	{
    //		int[] testCase = GetArrayOfRandomInts(sortingCapacity);
    //		Algorithms.QuickSort(testCase);
    //		AssertSortedList(testCase, SortingAlgorithm.SelectionSort);
    //	}
    //}

    //[TestMethod]
    //public void TestQuickSelect()
    //{
    //	asdfjasdfkj
    //	Random random = new();
    //	for (int i = 0; i < sortingTests; i++)
    //	{
    //		int[] testCase = [6, 9, 1, 10, 0, 20];
    //		int[] testCaseCopy = new int[testCase.Length];
    //		Array.Copy(testCase, 0, testCaseCopy, 0, testCase.Length);
    //		int k = 3;
    //		int kthLargestItem = Algorithms.QuickSelect(testCase, k);
    //		Algorithms.QuickSort(testCaseCopy);
    //		Assert.IsTrue(kthLargestItem == testCaseCopy[k - 1]);
    //	}
    //}

    //private int[] GetArrayOfRandomInts(int size, int min = int.MinValue, int max = int.MaxValue)
    //{
    //	int[] arr = new int[size];
    //	Random random = new Random();
    //	for (int i = 0; i < size; i++)
    //	{
    //		arr[i] = random.Next(min, max);
    //	}

    //	return arr;
    //}

    //private void AssertSortedList(int[] arr, SortingAlgorithm algorithm)
    //{
    //	if (arr.Length <= 1)
    //	{
    //		return;
    //	}

    //	for (int i = 1; i < arr.Length; i++)
    //	{
    //		Assert.IsTrue(arr[i - 1] <= arr[i], $"Failed for algorithm {algorithm}.");
    //	}
    //}

//public enum SortingAlgorithm
//{
//	SelectionSort,
//	BubbleSort,
//}