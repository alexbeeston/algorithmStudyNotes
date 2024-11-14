using Algorithms.Algorithms;

namespace Tests;

[TestClass]
public class TestAlgorithms
{
    /// <summary>
    /// Arrays of sorted integers of varying lengths; includes duplicates and negatives.
    /// </summary>
    private List<int[]> SortedInts = new List<int[]>
    {
        new int[] { 10 },
        new int[] { -15, -12, -8, -5, -2, 1, 4, 7, 10, 13, 25, 28, 31, 34, 37, 40, 43 },
        new int[] { -20, -17, -14, -11, -8, -5, -2, 1, 4, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 45, 60, 70, 111 },
        new int[] { -18, -15, -12, -9, -6, -3, 0, 3, 6, 9, 12, 15, 18, 21, 21, 21, 24, 27, 30, 39 },
        new int[] { -19, -16, -13, -10, -7, -4, -1, 2, 5, 8, 11, 12, 13, 14, 17, 20, 23, 26, 29, 32, 35, 38 },
        new int[] { -21, -18, -15, -12, -9, -9, -6, -6, -3, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 },
    };


    [TestMethod]
    public void TestBinarySearch()
    {
        // Assert can find number
        foreach (int[] intArray in SortedInts)
        {
            List<int> intList = intArray.ToList();
            for (int i = 0; i < intList.Count(); i++)
            {
                int numberToFind = intArray[i];
                int indexOfFirstOccurrence = BinarySearch.MainIterative(intArray, numberToFind);
                Assert.IsTrue(indexOfFirstOccurrence == intList.IndexOf(numberToFind));

                indexOfFirstOccurrence = BinarySearch.MainRecursive(intArray, numberToFind);
                Assert.IsTrue(indexOfFirstOccurrence == intList.IndexOf(numberToFind));
            }
        }

        // Assert -1 returned if number is not in array
        int[] integers = new int[] { -18, -15, -12, -9, -6, -3, 0, 3, 6, 9, 12, 15, 18, 21, 21, 21, 24, 27, 30, 39 };
        int[] nonExistentIntegers = new int[] { -20, -13, 1, 10, 50 };

        foreach (int nonExtentNumber in nonExistentIntegers)
        {
            Assert.IsTrue(BinarySearch.MainIterative(integers, nonExtentNumber) == -1);
            Assert.IsTrue(BinarySearch.MainRecursive(integers, nonExtentNumber) == -1);
        }
    }
}