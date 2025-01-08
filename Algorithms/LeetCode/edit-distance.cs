namespace algorithms.leetcode;

public class edit_distance
{
    public int MinDistance(string word1, string word2)
    {
        Dictionary<string, int> words = new();
        words.Add(word1, 0);
        int minDistance = int.MaxValue - 2;
        List<string> wordsToExplore = words.Where(x => x.Value + 2 <= minDistance).Select(x => x.Key).ToList();
        while (wordsToExplore.Count > 0)
        {
            foreach (string word in wordsToExplore)
            {
                int originalMinDistance = minDistance;
                minDistance = Math.Min(minDistance, Modify(words, word, word2, words[word]));
                if (minDistance == originalMinDistance)
                {
                    // explore via inserting
                }

                if (minDistance == originalMinDistance)
                {
                    // explore via deleting
                }

                words[word] = minDistance;
            }

            wordsToExplore = words.Where(x => x.Value + 2 <= minDistance).Select(x => x.Key).ToList();
        }

        return minDistance;
    }

    private int Modify(Dictionary<string, int> words, string word, string target, int minDistance)
    {
        int newDistance = minDistance + 1;
        for (int i = 0; i < word.Length; i++)
        {
            foreach (char c in target)
            {
                char[] array = word.ToCharArray();
                array[i] = c;
                string newWord = new string(array);
                if (newWord == target)
                {
                    return newDistance;
                }
                else
                {
                    words.TryAdd(newWord, newDistance);
                }
            }
        }

        return minDistance;
    }
}
