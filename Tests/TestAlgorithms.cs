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
        foreach (int[] intArray in TestUtils.SortedInts)
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
        int[] integers = [-18, -15, -12, -9, -6, -3, 0, 3, 6, 9, 12, 15, 18, 21, 21, 21, 24, 27, 30, 39];
        int[] nonExistentIntegers = [-20, -13, 1, 10, 50];

        foreach (int nonExtentNumber in nonExistentIntegers)
        {
            Assert.IsTrue(BinarySearch.MainIterative(integers, nonExtentNumber) == -1);
            Assert.IsTrue(BinarySearch.MainRecursive(integers, nonExtentNumber) == -1);
        }
    }
}