namespace Algorithms.DataStructures;

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
