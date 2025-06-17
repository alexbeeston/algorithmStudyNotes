using System.Text;

namespace Algorithms.LeetCode;

public class word_ladder
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        wordList.Add(beginWord);
        int indexOfStart = wordList.Count - 1;
        int indexOfEnd = wordList.IndexOf(endWord);
        if (indexOfEnd == -1)
        {
            return 0;
        }

        LinkedList<int>[] graph = BuildGraph(wordList);
        return 10;
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
 */
