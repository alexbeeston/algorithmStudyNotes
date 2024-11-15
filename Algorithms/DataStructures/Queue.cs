using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures;

public class Queue<T>
{
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

	public T Peek()
	{
		ValidateState();
		if (FrontNode == null)
		{
			throw new InvalidOperationException(Utils.EmptyStructMessage);
		}
		else
		{
			return FrontNode.Data;
		}
	}

	public T Rear()
	{
		ValidateState();
		if (RearNode == null)
		{
			throw new InvalidOperationException(Utils.EmptyStructMessage);
		}
		else
		{
			return RearNode.Data;
		}
	}

	public bool IsEmpty
	{
		get
		{
			ValidateState();
			return Size == 0;
		}
	}

	public int Size { get; set; } = 0;

	private Node<T> FrontNode { get; set; }

	private Node<T> RearNode { get; set; }

	private void ValidateState()
	{
		if (FrontNode == null ^ RearNode == null)
		{
			throw new UnreachableException();
		}
	}
}
