public class reverse_integer
{
	public int Reverse(int x)
	{
		int reversedNumber = 0;
		bool isPositive = x > 0;
		while (x != 0)
		{
			if (reversedNumber > 214748364 || reversedNumber < -214748364)
			{
				return 0;
			}

			int rightMostDigit = x % 10;
			reversedNumber *= 10;
			reversedNumber += rightMostDigit;

			if ((isPositive && (reversedNumber < 0)) ||
				(!isPositive && (reversedNumber > 0))
				)
			{
				return 0;
			}

			x -= rightMostDigit;
			x /= 10;
		}

		return reversedNumber;
	}
}
