using Algorithms.Sorting;

namespace Tests;

[TestClass]
public class TestSorting
{
    private delegate void SortingAlgorithm(int[] arr);

    private void TestSortingAlgorithm(SortingAlgorithm algo)
    {
        foreach (int[] arr in TestUtils.UnsortedArrays)
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
    public void TestSelectionSort()
    {
        TestSortingAlgorithm(SelectionSort.Main);
    }

    [TestMethod]
    public void TestInsertionSort()
    {
        TestSortingAlgorithm(InsertionSort.Main);
    }

    [TestMethod]
    public void TestBubbleSort()
    {
        TestSortingAlgorithm(BubbleSort.Main);
    }

    [TestMethod]
    public void TestQuickSort()
    {
        TestSortingAlgorithm(QuickSort.Main);
    }
}



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