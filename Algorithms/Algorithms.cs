using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study;

public static class Algorithms
{
	public static int BinarySearchIterative(int[] arr, int target)
	{
		int left = 0;
		int right = arr.Length - 1;
		while (left <= right)
		{
			int mid = (left + right) / 2;
			if (target < arr[mid])
			{
				right = mid - 1;
			}
			else if (target == arr[mid])
			{
				return mid;
			}
			else
			{
				left = mid + 1;
			}
		}

		return -1;
	}

	public static int BinarySearchRecursive(int[] arr, int target)
	{
		return BinarySearchRecursiveWorker(arr, target, 0, arr.Length - 1);
	}

	private static int BinarySearchRecursiveWorker(int[] arr, int target, int left, int right)
	{
		if (left > right)
		{
			return -1;
		}

		int mid = (left + right) / 2;
		if (target < arr[mid])
		{
			return BinarySearchRecursiveWorker(arr, target, left, mid - 1);
		}
		else if (target == arr[mid])
		{
			return mid;
		}
		else
		{
			return BinarySearchRecursiveWorker(arr, target, mid + 1, right);
		}
	}

	public static void BubbleSort(int[] arr)
	{
		if (arr.Length <= 1)
		{
			return;
		}

		for (int maxCompareIndex = arr.Length - 1; maxCompareIndex > 0; maxCompareIndex--)
		{
			bool didASwap = false;
			for (int i = 0; i < maxCompareIndex; i++)
			{
				if (arr[i] > arr[i + 1])
				{
					didASwap = true;
					SwapItems(arr, i, i + 1);
				}
			}

			if (!didASwap)
			{
				return;
			}
		}
	}

	public static void SelectionSort(int[] arr)
	{
		for (int i = 0; i < arr.Length - 1; i++)
		{
			int indexOfSmallestUnsortedElement = i;
			for (int j = i + 1; j < arr.Length; j++)
			{
				if (arr[j] < arr[indexOfSmallestUnsortedElement])
				{
					indexOfSmallestUnsortedElement = j;
				}
			}

			SwapItems(arr, i, indexOfSmallestUnsortedElement);
		}
	}

	public static void InsertionSort(int[] arr)
	{
		for (int i = 1; i < arr.Length; i++)
		{
			int stopIndex = i - 1;
			while (stopIndex >= 0 && arr[i] < arr[stopIndex])
			{
				stopIndex--;
			}

			for (int j = i - 1; j > stopIndex; j--)
			{
				SwapItems(arr, j, j + 1);
			}
		}
	}

	public static void QuickSort(int[] arr)
	{
		QuickSortWorker(arr, 0, arr.Length - 1);
	}

	private static void QuickSortWorker(int[] arr, int left, int right)
	{
		if (right <= left)
		{
			return;
		}

		int pivot = QuickPivot(arr, left, right);
		QuickSortWorker(arr, left, pivot - 1);
		QuickSortWorker(arr, pivot + 1, right);
	}

	/// <summary>
	/// Returns the kth larget element in <paramref name="arr"/>.
	/// </summary>
	public static int QuickSelect(int[] arr, int k)
	{
		if (arr.Length  < k )
		{
			throw new ArgumentException("Insufficient items in arr");
		}
		else if (arr.Length == 1)
		{
			return arr[0];
		}

		int pivotIndex = QuickPivot(arr, 0, arr.Length - 1);
		if (pivotIndex == k - 1)
		{
			return arr[pivotIndex];
		}
		else if (arr[k - 1] < arr[pivotIndex])
		{
			int[] copy = new int[pivotIndex];
			Array.Copy(arr, 0, copy, 0, pivotIndex - 1);
			return QuickSelect(copy, k);
		}
		else
		{
			int[] copy = new int[arr.Length - pivotIndex - 1];
			Array.Copy(arr, pivotIndex + 1, copy, 0, arr.Length - pivotIndex);
			return QuickSelect(copy, k - 1 - pivotIndex);
		}
	}

	/// <summary>
	/// Move items less than arr[right] to the right of <paramref name="left"/> and items less than arr[right]
	/// to the left of <paramref name="right"/>.
	/// </summary>
	/// <returns>The index of the pivot.</returns>
	private static int QuickPivot(int[] arr, int left, int right)
	{
		int pivotIndex = right;
		int i = left;
		for (int j = left; j <= right; j++)
		{
			if (arr[j] < arr[pivotIndex])
			{
				SwapItems(arr, i, j);
				i++;
			}
		}

		SwapItems(arr, i, pivotIndex);
		return i;
	}

	private static void SwapItems(int[] arr, int i, int j)
	{
		int tempValue = arr[i];
		arr[i] = arr[j];
		arr[j] = tempValue;
	}
}
