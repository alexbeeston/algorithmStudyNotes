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

### Quick Select
Finds the kth largest item in a list. Select a pivot, then move items less than the pivot to the left and items greater than the pivot to the right. If the pivot of the index is less than k, recurse on items less than pivot, if k equals the pivot, you have your answer, and if k is greater than the pivot, recurse on the items greater than the pivot and look for k - pivot. If you have a good pivot each time, you could do this in linear time, but in worst-case you're only removing one item from the list each time, which would be n^2 time. So, if you can find the median, or an approximation thereof and use that as you're pivot, you're in a much better shape.

### Median of Medians
Finds an approximation of the median (something between 30th and 70th percentiles) by sorting every five elements (omitting the remainder group), then recuring on the third element of each group.

