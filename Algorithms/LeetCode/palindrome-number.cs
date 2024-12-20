namespace Algorithms.LeetCode;

public class palindrome_number_reverseIntegerSolution // beats 67.92% on runtime
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int originalNumber = x;
        int reversedNumber = 0;
        while (x != 0)
        {
            if (reversedNumber > 214748364)
            {
                return false;
            }

            int rightMostDigit = x % 10;
            reversedNumber *= 10;
            reversedNumber += rightMostDigit;

            if (reversedNumber < 0)
            {
                return false;
            }

            x -= rightMostDigit;
            x /= 10;
        }

        return reversedNumber == originalNumber;
    }
}


public class palindrome_number_leftRightDigitComparison // beats 26.7% on runtime
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        else if (x < 10)
        {
            return true;
        }

        int orderOfMagnitude = 1;
        while ((x - Math.Pow(10, orderOfMagnitude)) >= 0)
        {
            orderOfMagnitude++;
        }

        orderOfMagnitude--;
        return NumericPalindromeHelper(x, orderOfMagnitude);
    }

    public bool NumericPalindromeHelper(int x, int expectedOrderOfMagnitude)
    {
        if (expectedOrderOfMagnitude == 0)
        {
            return true;
        }
        else if (expectedOrderOfMagnitude == 1)
        {
            return x % 11 == 0;
        }

        int rightMostDigit = x % 10;
        int powerOfTen = (int)Math.Pow(10, expectedOrderOfMagnitude);
        int leftMostDigit = x / powerOfTen;
        if (rightMostDigit == leftMostDigit)
        {
            x -= rightMostDigit;
            x -= leftMostDigit * powerOfTen;
            x /= 10;
            return NumericPalindromeHelper(x, expectedOrderOfMagnitude - 2);
        }
        else
        {
            return false;
        }
    }
}

