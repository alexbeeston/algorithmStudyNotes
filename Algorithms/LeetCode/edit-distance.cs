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
                minDistance = Math.Min(minDistance, Explore(words, word, word2, minDistance));
                words[word] = minDistance;
            }

            wordsToExplore = words.Where(x => x.Value + 2 <= minDistance).Select(x => x.Key).ToList();
        }

        return minDistance;
    }

    private int Explore(Dictionary<string, int> words, string word, string target, int minDistance)
    {
        int currentDistance = words[word];
        string newWord;
        int potentiallyNewDistance;
        foreach (char c in target)
        {
            for (int i = 0; i < word.Length; i++)
            {
                // modify
                char[] array = word.ToCharArray();
                array[i] = c;
                newWord = new string(array);
                potentiallyNewDistance = CheckForTarget(words, newWord, target, minDistance, currentDistance);
                if (potentiallyNewDistance < minDistance)
                {
                    return potentiallyNewDistance;
                }

                // insert
                newWord = word.Insert(i, c.ToString());
                potentiallyNewDistance = CheckForTarget(words, newWord, target, minDistance, currentDistance);
                if (potentiallyNewDistance < minDistance)
                {
                    return potentiallyNewDistance;
                }
            }

            // insert at end
            newWord = word.Insert(word.Length, c.ToString());
            potentiallyNewDistance = CheckForTarget(words, newWord, target, minDistance, currentDistance);
            if (potentiallyNewDistance < minDistance)
            {
                return potentiallyNewDistance;
            }
        }

        for (int i = 0; i < word.Count(); i++)
        {
            // delete
            newWord = word.Remove(i, 1);
            potentiallyNewDistance = CheckForTarget(words, newWord, target, minDistance, currentDistance);
            if (potentiallyNewDistance < minDistance)
            {
                return potentiallyNewDistance;
            }
        }


        return minDistance;
    }

    private int CheckForTarget(Dictionary<string, int> words, string newWord, string target, int minDistance, int currentDistance)
    {
        if (newWord == target)
        {
            return currentDistance + 1;
        }
        else
        {
            words.TryAdd(newWord, currentDistance + 1);
        }

        return minDistance;
    }
}
