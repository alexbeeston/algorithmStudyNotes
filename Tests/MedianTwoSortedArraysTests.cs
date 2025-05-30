﻿using algorithms.leetcode;
using Algorithms.LeetCode;
using Newtonsoft.Json;

namespace Tests;

[TestClass]
public class MedianTwoSortedArraysTests
{
    [TestMethod]
    public void Sandbox()
    {
        median_of_two_sorted_arrays s = new();
        List<TestCase> testCases = new List<TestCase>();
        //testCases.Add(new TestCase([], [1, 2, 3], 2));
        //testCases.Add(new TestCase([], [1, 2, 3, 4], 2.5));
        //testCases.Add(new TestCase([], [-10], -10));
        testCases.Add(new TestCase([1], [2, 3], 2));
        //testCases.Add(new TestCase([10], [2, 3], 3));
        //testCases.Add(new TestCase([1, 2], [3, 4], 2.5));
        //testCases.Add(new TestCase([1, 3], [2], 2));
        //testCases.Add(new TestCase([1, 3, 5], [2, 4, 6], 3.5)); // 4
        //testCases.Add(new TestCase([1, 3, 5], [2, 4, 6, 7], 4)); // 5
        //testCases.Add(new TestCase([2, 4, 6, 7], [2, 4, 6, 7], 99)); // 6


        //testCases.Add(new TestCase([0, 2, 4], [1, 3, 4, 5], 3));
        //testCases.Add(new TestCase([], 1, 2, 3, 4], 2.5));
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
