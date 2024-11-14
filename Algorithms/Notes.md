### Binary Search
Given a sorted array, find mid of array, if target < mid, search left side, else search right side recursively.

### Selection Sort
Go through the array and find the smallest or largest item, then place it in the last or first place, then repeat.

### Bubble sort
Bubble up the array swapping arr[i] and arr[i + i] if arr[i + i] > arr[i]. If no swaps, then the array is sorted.

### Insertion sort
Starting at i = 1, assume everything left of i is sorted, then 'insert' i + 1 into its position left of i. Easy to implement if you bubble up from where it belongs in the array.

### Quick sort
Select a pivot, then put everything less than the pivot on the left and everything greater than the pivot to its right, then recurse on left and right.
Selecting a pivot:
1. High index - easy to implement, can do in-place: maintain index i of all items in list less than pivot. Then for each item j in list, if arr[j] < arr[pivot], swap arr[j] and arr[i]. Then swap arr[high], which is arr[pivot], with arr[i+1].
2. Median - can find median in n time, optimizes recursive calls.

### Finding median
1. "Quick Select": finds the kth largest item in a list. Pick a random pivot, split items into less than pivot and greater than pivot. If left group has more than K items, recurse on lower half and find the kth largest element. If left group has greater than K items, recurse on right side and look for the (k - len(leftSide)) item. However, at worst case, you could pick the smallest or larget item in the list every time, in which case you'd be traversing the list in n^2 time.
2. "Median of medians" O(n) time: if list is less than 5 elements, find the median, otherwise, place items in groups of 5 (remove the remainder), then sort each list, then get the median of all items at index 2 recursively. Proven that it's O(n) time by induction, something like in (7/10)*n time.

