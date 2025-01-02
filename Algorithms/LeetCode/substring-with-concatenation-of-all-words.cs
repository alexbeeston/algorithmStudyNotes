namespace Algorithms.LeetCode;

public class substring_with_concatenation_of_all_words
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        words = words.Order().ToArray();
        int wordLength = words[0].Length;
        int concatenationIndex = 0;
        List<int> indices = [];
        int maxConcatenationIndex = s.Length - words.Length * wordLength;
        while (concatenationIndex <= maxConcatenationIndex)
        {
            int readingFrameIndex = concatenationIndex;
            string[] arrayCopy = new string[words.Length];
            Array.Copy(words, arrayCopy, words.Length);
            List<string> remainingWords = arrayCopy.ToList();
            int wordMatchIndex = -1;
            do
            {
                string readingFrame = s.Substring(readingFrameIndex, wordLength);
                wordMatchIndex = remainingWords.IndexOf(readingFrame); // use binary search for optimization
                if (wordMatchIndex != -1)
                {
                    remainingWords.RemoveAt(wordMatchIndex);
                    readingFrameIndex += wordLength;
                }
            }
            while (wordMatchIndex != -1 && remainingWords.Count > 0);

            if (remainingWords.Count == 0)
            {
                indices.Add(concatenationIndex);
            }

            concatenationIndex++;
        }

        return indices;
    }
}
