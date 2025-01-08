using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class group_anagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        List<Wrapper> words = new List<Wrapper>(strs.Length);
        int i = 0;
        for (i = 0; i < strs.Length; i++)
        {
            words.Add(new Wrapper(strs[i], i));
        }

        words = words.OrderBy(x => x.AlphabetizedWord).ToList();
        List<IList<string>> answer = new();
        i = 0;
        while (i < strs.Length)
        {
            string currentAlphabetizedWord = words[i].AlphabetizedWord;
            List<string> relatedWords = [strs[words[i].OriginalIndex]];
            i++;
            while (i < strs.Length && words[i].AlphabetizedWord == currentAlphabetizedWord)
            {
                relatedWords.Add(strs[words[i].OriginalIndex]);
                i++;
            }

            answer.Add(relatedWords);
        }

        return answer;
    }

    private class Wrapper
    {
        public Wrapper(string str, int i)
        {
            AlphabetizedWord = new string(str.Order().ToArray());
            OriginalIndex = i;
        }

        public string AlphabetizedWord { get; set; }

        public int OriginalIndex { get; set; }
    }
}
