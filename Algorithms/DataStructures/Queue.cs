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
	}

	public T Dequeue()
	{
		if (Size == 0)
		{
			throw new InvalidOperationException(Utils.EmptyStructMessage);
		}

		T data = FrontNode.Data;
		FrontNode = FrontNode.Next;
		if (FrontNode == null)
		{
			RearNode = null;
		}

		Size--;
		return data;
	}

	public T Peek()
	{
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
			return Size == 0;
		}
	}

	public int Size { get; private set; }

	private Node<T> FrontNode { get; set; }

	private Node<T> RearNode { get; set; }
}
