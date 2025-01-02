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
        if (digits.Length == 0)
        {
            return new List<string>();
        }

        List<string> combos = GetNewLetters(digits[0]);
        if (digits.Length == 1)
        {
            return combos;
        }
        else
        {
            return Helper(combos, digits.Substring(1, digits.Length - 1));
        }
    }

    private List<string> Helper(List<string> combinations, string digits)
    {
        if (digits.Length == 0)
        {
            return combinations;
        }

        List<string> newCombinations = new List<string>();
        foreach (string newLetter in GetNewLetters(digits[0]))
        {
            foreach (string oldWord in combinations)
            {
                newCombinations.Add(oldWord + newLetter);
            }
        }

        if (digits.Length == 1)
        {
            return newCombinations;
        }
        else
        {
            return Helper(newCombinations, digits.Substring(1, digits.Length - 1));
        }
    }

    private static List<string> GetNewLetters(char c)
    {
        return c switch
        {
            '2' => ["a", "b", "c"],
            '3' => ["d", "e", "f"],
            '4' => ["g", "h", "i"],
            '5' => ["j", "k", "l"],
            '6' => ["m", "n", "o"],
            '7' => ["p", "q", "r", "s"],
            '8' => ["t", "u", "v"],
            '9' => ["w", "x", "y", "z"],
            _ => throw new ArgumentException("not a valid character"),
        };
    }
}
