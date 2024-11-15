using Algorithms;
using Algorithms.Algorithms;

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
        int[] integers = [-18, -15, -12, -9, -6, -3, 0, 3, 6, 9, 12, 15, 18, 21, 21, 21, 24, 27, 30, 39];
        int[] nonExistentIntegers = [-20, -13, 1, 10, 50];

        foreach (int nonExtentNumber in nonExistentIntegers)
        {
            Assert.IsTrue(BinarySearch.MainIterative(integers, nonExtentNumber) == -1);
            Assert.IsTrue(BinarySearch.MainRecursive(integers, nonExtentNumber) == -1);
        }
    }
}