﻿namespace Tests;

public static class TestUtils
{
    /// <summary>
    /// Arrays of sorted integers of varying lengths; includes duplicates and negatives.
    /// </summary>
    public static readonly List<int[]> SortedInts = new List<int[]>
    {
        new int[] { 10 },
        new int[] { -15, -12, -8, -5, -2, 1, 4, 7, 10, 13, 25, 28, 31, 34, 37, 40, 43 },
        new int[] { -20, -17, -14, -11, -8, -5, -2, 1, 4, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 45, 60, 70, 111 },
        new int[] { -18, -15, -12, -9, -6, -3, 0, 3, 6, 9, 12, 15, 18, 21, 21, 21, 24, 27, 30, 39 },
        new int[] { -19, -16, -13, -10, -7, -4, -1, 2, 5, 8, 11, 12, 13, 14, 17, 20, 23, 26, 29, 32, 35, 38 },
        new int[] { -21, -18, -15, -12, -9, -9, -6, -6, -3, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 },
    };

    /// <summary>
    /// Arrays of integers of variable length, including negative and duplicates.
    /// </summary>
    public static readonly List<int[]> UnsortedArrays = new List<int[]>
    {
        new int[] { 3, 3, 3, 2 },
        new int[] { 1 },
        new int[] { 3, -1, 4, -1, 5, 9, -2, 6, 5, 3, -5, 8, 9, -7, 9, 3, -2, 6, 5, -3 },
        new int[] { -10, 4, 3, -5, 6, 4, -8, 7, 2, -3, 5, -6, 4, 2, -1, 0, 3, -4, 6, -2, 1, -7 },
        new int[] { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6, 7, -7, 8, -8, 9, -9, 0, 0, -10, 10, -11 },
        new int[] { 5, 3, -2, 8, -6, 7, -3, 2, -1, 4, -5, 6, -4, 1, -7, 9, -8, 0, 5, -9, 11, -12, 13, -14 },
        new int[] { -3, 6, -1, 7, -2, 8, -4, 9, -5, 0, 3, -6, 2, -7, 1, -8, 4, -9, 5, -10, 6, -11, 7, -12, 8 },
        new int[] { 9, -3, 8, -2, 7, -1, 6, 0, 5, 1, 4, 2, 3, -4, 2, -5, 1, -6, 0, -7, -8, 9, -9, 10, -10, 11 },
        new int[] { 2, -2, 4, -4, 6, -6, 8, -8, 10, -10, 1, -1, 3, -3, 5, -5, 7, -7, 9, -9, 11, -11, 12, -12, 13, -13, 14 },
        new int[] { 0, -1, 1, -2, 2, -3, 3, -4, 4, -5, 5, -6, 6, -7, 7, -8, 8, -9, 9, -10, 10, -11, 11, -12, 12, -13, 13, -14 },
        new int[] { 4, -4, 3, -3, 2, -2, 1, -1, 0, 5, -5, 6, -6, 7, -7, 8, -8, 9, -9, 10, -10, 11, -11, 12, -12, 13, -13, 14, -14 },
        new int[] { 7, -3, 6, -2, 5, -1, 4, 0, 3, 1, 2, -4, 1, -5, 0, -6, -1, -7, -2, -8, 8, -9, 9, -10, 10, -11, 11, -12, 12, -13 },
    };

    /// <summary>
    /// Arrays of unique integers.
    /// </summary>
    public static readonly List<int[]> UniqueArrays = new List<int[]>
    {
        new int[] { -12, 14, 26, -17, -10, 17, 18, -9, 22, 29, -27, 7, -29, -19, -7, 5, -16, 21, -6, 11, -5, -20 },
        new int[] { -7, 8, -16, 5, 6, -18, 14, 26, 20, -8, 10, 19, -9, 23, -14, 3, 1, -28, -22, 9, 21, 11, -10, 22, -2, -25, 28, -11, -15, 30 },
        new int[] { -6, -14, -23, 2, 20, -10, 5, 29, 9, 24, 12, -2, 16, -30, -17, 14, -25, 4, 15, 19, -1, 21, 17, -15, -9, -20, -3, 26, -27, 30},
        new int[] { -1, -3, 14, -29, 30, -6, -15, 19, 8, -7, 21, 17, 29, 18, -9, -27, -4, 1, 9, -23, -11, -17, 12, 0, 26, -24, 27, 10 },
        new int[] { 25, 28, -2, 2, -21, 26, 7, -4, -20, 29, 21, 11, 19, 20, -5, 12, -6, 15, 17, -23, -18 },
    };


    public static readonly List<int[]> PositiveInteger = new List<int[]>
    {
        new int[] { 4, 5, 1, 8, 3, 10, 2, 7, 4, 8 },
        new int[] { 1, 9, 4, 3, 2, 8, 5, 5, 4, 2 },
        new int[] { 3, 2, 1, 9, 4, 10, 5, 4, 4, 10 },
    };
}
