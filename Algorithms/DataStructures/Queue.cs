using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures;

public class Queue<T>
{
	/// <summary>
	/// Add an element to the end of the queue.
	/// </summary>
	public void Enqueue(T item)
	{
		ValidateState();
		Node<T> node = new Node<T>(item);
		if (FrontNode == null)
		{
			RearNode = node;
			FrontNode = node;
		}
		else
		{
			RearNode.Next = node;
			RearNode = node;
		}

		Size++;
		ValidateState();
	}

	/// <summary>
	/// Remove an element from the front of the queue.
	/// </summary>
	/// <returns>The front element in the queue, or null if the queue is empty.</returns>
	public T Dequeue()
	{
		ValidateState();
		Node<T> tempFrontNode = FrontNode;
		FrontNode = tempFrontNode?.Next;
		if (tempFrontNode?.Next == null)
		{
			RearNode = null;
		}

		Size--;
		ValidateState();
		return tempFrontNode.Data;
	}

	/// <summary>
	/// Get the front element without removing it.
	/// </summary>
	public T Peek()
	{
		ValidateState();
		if (FrontNode == null)
		{
			throw new Exception("Empty queue. I dont' really care if you throw an exception or use a sentinal value.");
		}
		else
		{
			return FrontNode.Data;
		}
	}

	/// <summary>
	/// Get the rear element without removing it.
	/// </summary>
	public T Rear()
	{
		ValidateState();
		if (RearNode == null)
		{
			throw new Exception("Empty queue. I dont' really care if you throw an exception or use a sentinal value.");
		}
		else
		{
			return RearNode.Data;
		}
	}

	/// <summary>
	/// Whether the queue is empty.
	/// </summary>
	public bool IsEmpty
	{
		get
		{
			ValidateState();
			return Size == 0;
		}
	}

	/// <summary>
	/// The number of items in the queue.
	/// </summary>
	public int Size { get; set; } = 0;

	/// <summary>
	/// The front element of the queue.
	/// </summary>
	private Node<T> FrontNode { get; set; }

	/// <summary>
	/// The rear element of the queue.
	/// </summary>
	private Node<T> RearNode { get; set; }

	/// <summary>
	/// Throws an <see cref="UnreachableException"/> if the front or rear node is null but not the other.
	/// </summary>
	private void ValidateState()
	{
		if (FrontNode == null ^ RearNode == null)
		{
			throw new UnreachableException();
		}
	}
}

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
