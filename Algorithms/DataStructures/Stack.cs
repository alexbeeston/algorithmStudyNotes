namespace Algorithms.DataStructures;

public class Stack<T>
{
    public void Push(T item)
    {
        Node<T> node = new Node<T>(item);
        if (TopNode == null)
        {
            TopNode = node;
        }
        else
        {
            node.Next = TopNode;
            TopNode = node;
        }

        Size++;
    }

    public T Pop()
    {
        if (TopNode == null)
        {
            throw new InvalidOperationException(Utils.EmptyStructMessage);
        }

        T topData = TopNode.Data;
        TopNode = TopNode.Next;
        Size--;
        return topData;
    }

    public T Peek()
    {
        if (TopNode == null)
        {
            throw new InvalidOperationException(Utils.EmptyStructMessage);
        }

        return TopNode.Data;
    }

    public bool IsEmpty()
    {
        return Size == 0;
    }

    public int Size { get; private set; }

    private Node<T> TopNode { get; set; }
}
