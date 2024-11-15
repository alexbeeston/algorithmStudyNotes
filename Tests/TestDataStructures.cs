using Algorithms.DataStructures;
using System.Collections;

namespace Tests;

[TestClass]
public class TestDataStructures
{
	[TestMethod]
	public void TestQueue()
	{
		foreach (int[] arr in TestUtils.UnsortedArrays)
		{
			Algorithms.DataStructures.Queue<int> testQueue = new Algorithms.DataStructures.Queue<int>();
			System.Collections.Generic.Queue<int> systemQueue = new System.Collections.Generic.Queue<int>();
			for (int i = 0; i < arr.Length; i++)
			{
				testQueue.Enqueue(arr[i]);
				systemQueue.Enqueue(arr[i]);
				Assert.IsTrue(testQueue.Peek() == systemQueue.Peek());
				Assert.IsTrue(testQueue.Rear() == arr[i]);
				Assert.IsTrue(testQueue.Size == systemQueue.Count);
				Assert.IsFalse(testQueue.IsEmpty);
				if (i % 5 == 4)
				{
					int testDequeuedItem = testQueue.Dequeue();
					int systemDequeuedItem = systemQueue.Dequeue();
					Assert.IsTrue(testDequeuedItem == systemDequeuedItem);
					Assert.IsTrue(testQueue.Size == systemQueue.Count);
				}
			}

			while (!testQueue.IsEmpty)
			{
				Assert.IsTrue(testQueue.Dequeue() == systemQueue.Dequeue());
				Assert.IsTrue(testQueue.Size == systemQueue.Count);
			}
		}
	}
}