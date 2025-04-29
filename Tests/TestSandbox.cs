using algorithms.leetcode;
using Algorithms.LeetCode;
using Newtonsoft.Json;

namespace Tests;

[TestClass]
public class TestSandbox2
{
    [TestMethod]
    public void Sandbox()
    {
        median_of_two_sorted_arrays s = new();
        List<TestCase> testCases = new List<TestCase>();
        testCases.Add(new TestCase([0, 2, 4], [1, 3, 4, 5], 3));
        foreach (var testCase in testCases)
        {
            double calculatedMedian = s.FindMedianSortedArrays(testCase.nums1, testCase.nums2);
            Assert.IsTrue(calculatedMedian == testCase.median, testCase.ToString() + $"\nReversed: false\nCalculated median: {calculatedMedian}");

            calculatedMedian = s.FindMedianSortedArrays(testCase.nums2, testCase.nums1);
            Assert.IsTrue(calculatedMedian == testCase.median, testCase.ToString() + $"\nReversed: true\nCalculated median: {calculatedMedian}");
        }
    }

    public class TestCase
    {
        public int[] nums1 { get; set; }

        public int[] nums2 { get; set; }

        public double median { get; set; }

        public override string ToString()
        {
            return $"Nums1: {GetStringArray(nums1)}\nNum2: {GetStringArray(nums2)}\nActual median: {median}";
        }

        private string GetStringArray(int[] arr)
        {
            return string.Join(", ", arr);
        }

        public TestCase(int[] nums1, int[] nums2, double median)
        {
            this.nums1 = nums1;
            this.nums2 = nums2;
            this.median = median;
        }
    }
}
