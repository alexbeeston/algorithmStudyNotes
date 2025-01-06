using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class letter_combinations_of_a_phone_number
{
    public IList<string> LetterCombinations(string digits)
    {
        List<string> combinations = new List<string>();
        if (digits == string.Empty)
        {
            return combinations;
        }
        else
        {
            Helper(combinations, string.Empty, digits, 0);
            return combinations;
        }

    }

    private void Helper(List<string> combinations, string prefix, string digits, int i)
    {
        if (i == digits.Length)
        {
            combinations.Add(prefix);
        }
        else
        {
            foreach (char newLetter in digitLetterMapping[digits[i]])
            {
                Helper(combinations, prefix + newLetter, digits, i + 1);
            }
        }
    }

    private readonly Dictionary<char, char[]> digitLetterMapping = new Dictionary<char, char[]>()
    {
        { '2', ['a', 'b', 'c'] },
        { '3', ['d', 'e', 'f'] },
        { '4', ['g', 'h', 'i'] },
        { '5', ['j', 'k', 'l'] },
        { '6', ['m', 'n', 'o'] },
        { '7', ['p', 'q', 'r', 's'] },
        { '8', ['t', 'u', 'v'] },
        { '9', ['w', 'x', 'y', 'z'] },
    };
}
