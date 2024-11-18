namespace Algorithms;

public class Utils
{
    public static void SwapItems(int[] arr, int i, int j)
    {
        int tempValue = arr[i];
        arr[i] = arr[j];
        arr[j] = tempValue;
    }

    /// <summary>
    /// Selects <paramref name="right"/> as a pivot, then moves all items between <paramref name="left"/> and <paramref name="right"/>
    /// left or right of the pivot, then returns the pivot. Items equal to the pivot are placed right of the pivot.
    /// </summary>
    /// <returns>The index of the pivot.</returns>
    public static int Partition(int[] arr, int left, int right)
    {
        int i = left; // all items left of i are less than arr[right]
        for (int j = left; j <= right; j++)
        {
            if (arr[j] < arr[right])
            {
                SwapItems(arr, i, j);
                i++;
            }
        }

        SwapItems(arr, i, right);
        return i;
    }

    public const string EmptyStructMessage = "Data structure is empty";
}

public class EmptyDataStructureException
{
}

/// <summary>
/// A node with a pointer to another node.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Node<T>
{
	/// <summary>
	/// Instantiates a node.
	public Node(T data)
	{
		Data = data;
	}

	/// <summary>
	/// The next node in the queue.
	/// </summary>
	public Node<T> Next { get; set; }

	/// <summary>
	/// Data on the node.
	/// </summary>
	public T Data { get; set; }
}
