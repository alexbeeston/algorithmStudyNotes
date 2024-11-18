using Algorithms;
using Algorithms.Algorithms;
using Algorithms.Other;
using Algorithms.Sorting;
using Optimal.Knapsack;

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

    [TestMethod]
    public void TestKnapsack_01()
    {
        // Simple test case
        int[] weights = [1, 3, 4, 5];
        double[] values = [1, 4, 5, 7];
        int capacity = 7;
        KnapsackTester(weights, values, capacity);

        // test case from academic paper
        weights = [95, 4, 60, 32, 23, 72, 80, 62, 65, 46];
        values = [55, 10, 47, 5, 4, 50, 8, 61, 85, 87];
        capacity = 269;
        KnapsackTester(weights, values, capacity);

        // tests with random numbers
        for (int i = 1; i < TestUtils.PositiveInteger.Count; i++)
        {
            weights = TestUtils.PositiveInteger[i - 1];
            values = TestUtils.PositiveInteger[i].Select(x => (double)x).ToArray();
            capacity = (int)(TestUtils.PositiveInteger[i].Sum() * .6);
            KnapsackTester(weights, values, capacity);
        }
    }

    private static void KnapsackTester(int[] weights, double[] values, int capacity, bool validateInclusions = false)
    {
        if (weights.Length != values.Length)
        {
            throw new ArgumentException("Weight and values do not have the same length");
        }

        ZeroOneKnapsackSolver solver = new ZeroOneKnapsackSolver(weights, values);
        List<bool> isInKnapsack = solver.GetSelectedItems(weights.Length, capacity);
        double trueMaxValue = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if (isInKnapsack[i])
            {
                trueMaxValue += values[i];
            }
        }

        double testMaxValue = Knapsack.Main(weights, values, capacity);
        Assert.IsTrue(testMaxValue == trueMaxValue);
    }
}