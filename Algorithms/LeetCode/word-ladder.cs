using System.Security;
using System.Text;

namespace Algorithms.LeetCode;

public class word_ladder
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        // Init and validation
        wordList.Add(beginWord);
        int indexOfStart = wordList.Count - 1;
        int indexOfEnd = wordList.IndexOf(endWord);
        if (indexOfEnd == -1)
        {
            return 0;
        }

        // Build graph
        LinkedList<int>[] graph = BuildGraph(wordList);

        // Init min distance
        int[] minDistance = new int[wordList.Count];
        for (int i = 0; i < wordList.Count; i++)
        {
            minDistance[i] = int.MaxValue;
        }

        // Iterate
        minDistance[indexOfStart] = 0;
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        heap.Enqueue(indexOfStart, 0);
        while (heap.TryPeek(out int currentNode, out int currentPriority))
        {
            foreach (int adjacentNode in graph[currentNode])
            {
                if (minDistance[currentNode] + 1 < minDistance[adjacentNode])
                {
                    minDistance[adjacentNode] = minDistance[currentNode] + 1;
                    heap.Enqueue(adjacentNode, minDistance[currentNode] + 1);
                }
            }

            heap.Dequeue();
        }

        if (minDistance[indexOfEnd] == int.MaxValue)
        {
            return 0;
        }
        else
        {
            return minDistance[indexOfEnd] + 1;
        }
    }

    public LinkedList<int>[] BuildGraph(IList<string> wordList)
    {
        LinkedList<int>[] graph = new LinkedList<int>[wordList.Count];
        for (int i = 0; i < wordList.Count; i++)
        {
            graph[i] = GetNodesInList(wordList[i], wordList);
        }

        return graph;
    }

    public LinkedList<int> GetNodesInList(string word, IList<string> wordList)
    {
        LinkedList<int> nodes = new LinkedList<int>();
        for (int i = 0; i < wordList.Count; i++)
        {
            if (NumLettersDifferent(word, wordList[i]) == 1)
            {
                nodes.AddLast(i);
            }
        }

        return nodes;
    }

    public int NumLettersDifferent(string a, string b)
    {
        int differences = a.Length;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == b[i])
            {
                differences--;
            }
        }

        return differences;
    }
}


/* Optimizations
 * when building graph, recycle values computed bidirectionally (stair-case)
 * A*, which will require reading the number of letters that are different as the hueristic
 * optimize which node to explore next with a priority queue
 */
