using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode
{
    public class string_to_integer_atoi
    {
        public int MyAtoi(string s)
        {
            int i = 0;

            // Step 1
            while (i < s.Length && s[i] == ' ') i++;
            if (i == s.Length) return 0;

            // Step 2
            bool isPositive = true;
            if (s[i] == '-')
            {
                isPositive = false;
                i++;
            }
            else if (s[i] == '+')
            {
                i++;
            }
            if (i == s.Length) return 0;

            // Step 3a
            while (i < s.Length && s[i] == '0') i++;
            if (i == s.Length) return 0;

            // Step 3b
            List<int> digits = new List<int>();
            while (i < s.Length && int.TryParse(s.Substring(i, 1), out int parsedDigit))
            {
                digits.Add(parsedDigit);
                i++;
            }
            if (digits.Count == 0) return 0;

            // Step 4
            int integer = 0;
            for (int powerOfTen = 0; powerOfTen < digits.Count; powerOfTen++)
            {
                double absoluteValue = Math.Pow(10, powerOfTen) * digits[digits.Count - powerOfTen - 1];
                if (isPositive)
                {
                    int maxAbsoluteValue = int.MaxValue - integer;
                    if (absoluteValue >= maxAbsoluteValue)
                    {
                        return int.MaxValue;
                    }
                    else
                    {
                        integer += (int)absoluteValue;
                    }
                }
                else
                {
                    int maxAbsoluteValue = Math.Abs(int.MinValue - integer);
                    if (absoluteValue >= maxAbsoluteValue)
                    {
                        return int.MinValue;
                    }
                    else
                    {
                        integer -= (int)absoluteValue;
                    }
                }
            }

            return integer;
        }
    }
}
