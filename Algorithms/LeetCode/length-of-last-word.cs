using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class length_of_last_word
{
    public int LengthOfLastWord(string s)
    {
        int i = s.Length - 1;
        while (s[i] == ' ') i--;

        int indexOfLastLetterInLastWord = i;
        while (i >= 0 && s[i] != ' ') i--;

        return indexOfLastLetterInLastWord - i;
    }
}
