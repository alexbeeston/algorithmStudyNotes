using Algorithms;

namespace Tests;

[TestClass]
public class TestAlgorithms
{
	[TestMethod]
	public void TestBinarySearch()
	{

		//const int maxSizes = 1000000;

		//int[] arr = GetArrayOfRandomInts(maxSizes, int.MinValue, int.MaxValue / 2).ToList().Distinct().Order().ToArray();

		//Random random = new Random();
		//for (int i = 0; i < arr.Length; i++)
		//{
		//	int indexToFind = random.Next(arr.Length);
		//	Assert.IsTrue(Algorithms.BinarySearchIterative(arr, arr[indexToFind]) == indexToFind);
		//	Assert.IsTrue(Algorithms.BinarySearchRecursive(arr, arr[indexToFind]) == indexToFind);
		//}

		//for (int i = 0; i < arr.Length / 2; i++)
		//{
		//	int intNotInArr = random.Next((int.MaxValue / 2) + 1, int.MaxValue);
		//	Assert.IsTrue(Algorithms.BinarySearchIterative(arr, intNotInArr) == -1);
		//	Assert.IsTrue(Algorithms.BinarySearchRecursive(arr, intNotInArr) == -1);
		//}
	}

	//const int sortingCapacity = 10000;
	//const int sortingTests = 50;

	//[TestMethod]
	//public void TestBubbleSort()
	//{
	//	for (int i = 0; i < sortingTests; i++)
	//	{
	//		int[] testCase = GetArrayOfRandomInts(sortingCapacity);
	//		Algorithms.BubbleSort(testCase);
	//		AssertSortedList(testCase, SortingAlgorithm.BubbleSort);
	//	}
	//}

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
}

//public enum SortingAlgorithm
//{
//	SelectionSort,
//	BubbleSort,
//}