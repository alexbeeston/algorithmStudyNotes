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

        // Init explored
        bool[] explored = new bool[wordList.Count];

        // Iterate
        int currentNode = indexOfStart;
        minDistance[indexOfStart] = 0;
        do
        {
            // explore a node
            foreach (int adjacentNode in graph[currentNode])
            {
                minDistance[adjacentNode] = Math.Min(minDistance[adjacentNode], minDistance[currentNode] + 1);
            }

            explored[currentNode] = true;
            currentNode = GetNextNodeToExplore(minDistance, explored);
        } while (currentNode != -1); // replace with priority queue; just pop off the next one on the queue

        if (minDistance[indexOfEnd] == int.MaxValue)
        {
            return 0;
        }
        else
        {
            return minDistance[indexOfEnd] + 1;
        }
    }

    public int GetNextNodeToExplore(int[] minDistance, bool[] explored)
    {
        Dictionary<int, int> unexploredNodesDistances = new Dictionary<int, int>();
        for (int i = 0; i < explored.Length; i++)
        {
            if (!explored[i] && minDistance[i] != int.MaxValue)
            {
                unexploredNodesDistances.Add(i, minDistance[i]);
            }
        }

        if (unexploredNodesDistances.Count == 0)
        {
            return -1;
        }

        return unexploredNodesDistances.OrderBy(x => x.Value).First().Key;
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
