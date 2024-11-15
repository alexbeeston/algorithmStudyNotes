using Algorithms.DataStructures;
using System.Collections;

namespace Tests;

[TestClass]
public class TestDataStructures
{
	[TestMethod]
	public void TestQueue()
	{
		foreach (int[] ints in TestUtils.UnsortedArrays)
		{
			Algorithms.DataStructures.Queue<int> testQueue = new Algorithms.DataStructures.Queue<int>();
			System.Collections.Generic.Queue<int> systemQueue = new System.Collections.Generic.Queue<int>();
			foreach (int i in ints)
			{
				testQueue.Enqueue(i);
				systemQueue.Enqueue(i);
				Assert.IsTrue(testQueue.Peek() == systemQueue.Peek());
				Assert.IsTrue(testQueue.Rear() == i);
				Assert.IsTrue(testQueue.Size == systemQueue.Count);
				Assert.IsFalse(testQueue.IsEmpty);
			}

			while (!testQueue.IsEmpty)
			{
				Assert.IsTrue(testQueue.Dequeue() == systemQueue.Dequeue());
				Assert.IsTrue(testQueue.Size == systemQueue.Count);
			}
		}
	}
}