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

        // Another simple test case with bigger numbers.
        weights = [3, 7, 1, 6, 2, 10];
        values = [10, 12, 9, 20, 5, 15];
        capacity = 20;
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
        bool[] isInKnapsackTrueSolution = solver.GetSelectedItems(weights.Length, capacity).ToArray(); ;
        bool[] isInKnapsackMyAnswer = Knapsack_01.Main(weights, values, capacity);

        Assert.IsTrue(isInKnapsackTrueSolution.Length == isInKnapsackMyAnswer.Length);
        double value = 0;
        int totalWeight = 0;
        for (int i = 0; i < isInKnapsackMyAnswer.Length; i++)
        {
            Assert.IsTrue(isInKnapsackMyAnswer[i] == isInKnapsackTrueSolution[i]);
            if (isInKnapsackMyAnswer[i])
            {
                value += values[i];
                totalWeight += weights[i];
            }
        }
    }
}