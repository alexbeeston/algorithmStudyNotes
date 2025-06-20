using System.Runtime.CompilerServices;

namespace Algorithms;
public class temp
{
	public static long calculateTotalGroupImbalance(List<int> rank)
	{
		long inbalnces = 0;
		for (int end = rank.Count - 1; end >= 0; end--)
		{
			for (int start = 0; start <= end; start++)
			{
				inbalnces += ComputeInbalence(rank, start, end);

			}
		}

		return inbalnces;
	}

	private static long ComputeInbalence(List<int> rank, int start, int end)
	{
		List<int> subArray = rank.GetRange(start, end - start + 1);
		subArray.Sort();
		long inbalences = 0;
		for (int i = 0; i < subArray.Count - 1; i++)
		{
			if (subArray[i + 1] - subArray[i] > 1)
			{
				inbalences++;
			}
		}

		return inbalences;
	}
}

public class Sync
{
	public static int getMinimumRemovals(List<int> starts, List<int> ends)
	{
		bool[,] graph = BuildGraph(starts, ends);
		int[] numEdges = new int[starts.Count];
		for (int i = 0; i < starts.Count; i++)
		{
			for (int j = 0; j < ends.Count; j++)
			{
				if (graph[i, j])
				{
					numEdges[i]++;
				}
			}
		}

		for (int i = 0; i < starts.Count; i++)
		{
			bool[] isActive = new bool[];
			if (IsValid(graph, isActive, i))
			{
				return starts.Count - 1;
			}
		}

		return -1;
	}

	private static bool[][] GetActiveArrays(int size, int numInactive)
	{
		bool[] ranOutOfTime = new bool[size];
		bool[][] returnMe = new bool[1][];
		returnMe[0] = ranOutOfTime;
		return returnMe;
	}

	private static bool IsValid(bool[,] graph, bool[] isActive, int numActive)
	{
		int targetEdges = numActive - 1;
		for (int i = 0; i < graph.GetLength(0); i++)
		{
			if (isActive[i] && CountActiveEdges(graph, isActive, i) >= targetEdges)
			{
				return true;
			}
		}

		return false;
	}

	private static int CountActiveEdges(bool[,] graph, bool[] isActive, int row)
	{
		int activeEdges = 0;
		for (int i = 0; i < graph.GetLength(1); i++)
		{
			if (isActive[i] && graph[row, i])
			{
				activeEdges++;
			}
		}

		return activeEdges;
	}


	private static bool[,] BuildGraph(List<int> starts, List<int> ends)
	{
		bool[,] graph = new bool[starts.Count, ends.Count];
		for (int i = 0; i < starts.Count; i++)
		{
			for (int j = i + 1; j < starts.Count; j++)
			{
				bool hasEdge = ends[i] >= starts[j];
				graph[i, j] = hasEdge;
				graph[j, i] = hasEdge;
			}
		}

		return graph;
	}
}












