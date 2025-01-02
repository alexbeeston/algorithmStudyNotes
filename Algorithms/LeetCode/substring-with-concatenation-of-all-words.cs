using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class substring_with_concatenation_of_all_words
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        int wordLength = words[0].Length;
        int concatenationIndex = 0;
        List<int> indices = [];
        int maxConcatenationIndex = s.Length - words.Length * wordLength;
        while (concatenationIndex <= maxConcatenationIndex)
        {
            int readingFrameIndex = concatenationIndex;
            bool[] wordCandidates = GetTrueArray(words.Length);
            int wordMatchIndex = -1;
            int foundWords = 0;
            do
            {
                string readingFrame = s.Substring(readingFrameIndex, wordLength);
                wordMatchIndex = GetWordIndex(readingFrame, words, wordCandidates);
                if (wordMatchIndex != -1)
                {
                    wordCandidates[wordMatchIndex] = false;
                    readingFrameIndex += wordLength;
                    foundWords++;
                }
            }
            while (wordMatchIndex != -1 && foundWords < words.Length);

            if (foundWords == words.Length)
            {
                indices.Add(concatenationIndex);
            }

            concatenationIndex++;
        }

        return indices;
    }

    private int GetWordIndex(string s, string[] words, bool[] isCandidate)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (isCandidate[i] && s == words[i])
            {
                return i;
            }
        }

        return -1;
    }

    private bool[] GetTrueArray(int length)
    {
        bool[] array = new bool[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = true;
        }

        return array;
    }
}
