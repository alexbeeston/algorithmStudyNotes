namespace Algorithms.LeetCode;

public class palindrome_number
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

    /// <summary>
    /// Assumes x > 0
    /// </summary>
    public bool NumericPalindromeHelper(double x, int orderOfMagnitude)
    {
        if (orderOfMagnitude < 0)
        {
            return false;
        }
        else if (orderOfMagnitude == 0)
        {
            return true;
        }
        else if (orderOfMagnitude == 1)
        {
            return x % 11 == 0;
        }
        else
        {
            double rightMostDigit = x % 10;
            if (rightMostDigit == 0)
            {
                return false;
            }

            double powerOfTen = Math.Pow(10, orderOfMagnitude);
            x -= powerOfTen * rightMostDigit;
            if (x <= 0 || x > powerOfTen)
            {
                return false;
            }
            else
            {
                x -= rightMostDigit;
                if (x >= (powerOfTen / 10))
                {
                    x /= 10;
                }

                if (x == 0)
                {
                    return true;
                }

                return NumericPalindromeHelper(x, orderOfMagnitude - 2);
            }
        }
    }
}
