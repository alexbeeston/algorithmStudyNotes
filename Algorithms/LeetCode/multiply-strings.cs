using System.Text;

namespace Algorithms.LeetCode;

public class multiply_strings
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
        {
            return "0";
        }

        bool nums1IsLonger = num1.Length >= num2.Length;
        int[] longerNumber = GetIntArray(nums1IsLonger ? num1 : num2).Reverse().ToArray();
        int[] shorterNumber = GetIntArray(nums1IsLonger ? num2 : num1).Reverse().ToArray();

        // TODO: remove longer number thing
        int[] answer = new int[num1.Length + num2.Length];
        int i = 0;
        for (; i < longerNumber.Length; i++)
        {
            for (int j = 0; j < shorterNumber.Length; j++)
            {
                int product = longerNumber[i] * shorterNumber[j];
                IncrementIndex(answer, i + j, product % 10);
                IncrementIndex(answer, i + j + 1, product / 10);
            }
        }

        i = answer.Length - 1;
        while (answer[i] == 0)
        {
            i--;
        }

        StringBuilder sb = new();
        while (i >= 0)
        {
            sb.Append(answer[i]);
            i--;
        }

        return sb.ToString();
    }

    private void IncrementIndex(int[] answer, int i, int amount)
    {
        answer[i] += amount;
        while (answer[i] > 9)
        {
            answer[i] = answer[i] % 10;
            answer[i + 1] += 1;
            i++;
        }
    }

    private int[] GetIntArray(string number)
    {
        int[] ints = new int[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            ints[i] = int.Parse(number.Substring(i, 1));
        }

        return ints;
    }
}
