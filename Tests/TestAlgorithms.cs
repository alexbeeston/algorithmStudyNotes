using Algorithms;
using Algorithms.Algorithms;
using Algorithms.Other;
using Algorithms.Sorting;

namespace Tests;

[TestClass]
public class TestAlgorithms
{
    [TestMethod]
    public void TestBinarySearch()
    {
        // Assert can find number
        foreach (int[] arr in TestUtils.SortedInts)
        {
            List<int> list = arr.ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                int target = arr[i];
                int indexOfFirstInstanceOfTarget = BinarySearch.MainIterative(arr, target);
                Assert.IsTrue(indexOfFirstInstanceOfTarget == list.IndexOf(target));

                indexOfFirstInstanceOfTarget = BinarySearch.MainRecursive(arr, target);
                Assert.IsTrue(indexOfFirstInstanceOfTarget == list.IndexOf(target));
            }
        }

        // Assert -1 returned if number is not in array
        int[] arr2 = [-18, -15, -12, -9, -6, -3, 0, 3, 6, 9, 12, 15, 18, 21, 21, 21, 24, 27, 30, 39];
        int[] integersNotInArr = [-20, -13, 1, 10, 50];

        foreach (int integer in integersNotInArr)
        {
            Assert.IsTrue(BinarySearch.MainIterative(arr2, integer) == -1);
            Assert.IsTrue(BinarySearch.MainRecursive(arr2, integer) == -1);
        }
    }

    [TestMethod]
    public void TestQuickSelect()
    {
        foreach (int[] arr in TestUtils.UnsortedArrays)
        {
            int[] sortedCopy = new int[arr.Length];
            Array.Copy(arr, 0, sortedCopy, 0, arr.Length);
            QuickSort.Main(sortedCopy);
            for (int i = 0; i < arr.Length; i++)
            {
                int[] copy = new int[arr.Length];
                Array.Copy(arr, 0, copy, 0, arr.Length);
                Assert.IsTrue(QuickSelect.Main(copy, i + 1) == sortedCopy[i]);
            }
        }
    }
}