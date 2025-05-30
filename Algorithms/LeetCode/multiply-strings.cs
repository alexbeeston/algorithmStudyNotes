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

        int[] nums1 = GetReversedIntArray(num1);
        int[] nums2 = GetReversedIntArray(num2);
        int[] answer = new int[num1.Length + num2.Length];
        int i = 0;
        while (i < num1.Length)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                int product = nums1[i] * nums2[j];
                IncrementIndex(answer, i + j, product % 10);
                IncrementIndex(answer, i + j + 1, product / 10);
            }
            i++;
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

    private int[] GetReversedIntArray(string number)
    {
        int[] ints = new int[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            ints[number.Length - 1 - i] = int.Parse(number.Substring(i, 1));
        }

        return ints;
    }
}
