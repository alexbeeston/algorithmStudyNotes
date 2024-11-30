public class reverse_integer
{
	const int ten_0 = 1;
	const int ten_1 = 10;
	const int ten_2 = 100;
	const int ten_3 = 1000;
	const int ten_4 = 10000;
	const int ten_5 = 100000;
	const int ten_6 = 1000000;
	const int ten_7 = 10000000;
	const int ten_8 = 100000000;
	const int ten_9 = 1000000000;

	private static int[] powersOfTen = [ten_0, ten_1, ten_2, ten_3, ten_4, ten_5, ten_6, ten_7, ten_8, ten_9];

	public int Reverse(int x)
	{
		bool isPositive = x >= 0;
		if (x == int.MinValue || x == 0)
		{
			return 0;
		}
		else
		{
			x = Math.Abs(x);
		}

		int placeValueRead = 9;
		while (x < powersOfTen[placeValueRead]) placeValueRead--;

		int number = 0;
		int placeValueWrite = 0;
		while (placeValueRead >= 0)
		{
			int digit = ExtractDigit(x, placeValueRead);
			x -= digit * powersOfTen[placeValueRead];
			if (placeValueWrite == 9 && digit > 2)
			{
				return 0;
			}

			int amountToAdd = (isPositive ? 1 : -1) * digit * powersOfTen[placeValueWrite];
			if (isPositive)
			{
				if (amountToAdd > int.MaxValue - number)
				{
					return 0;
				}
			}
			else
			{
				if (amountToAdd < int.MinValue - number)
				{
					return 0;
				}
			}

			number += amountToAdd;
			placeValueRead--;
			placeValueWrite++;
		}

		return number;
	}

	public static int ExtractDigit(int number, int placeValue) // optimize w/binary search (?)
	{
		for (int i = 0; i < 10; i++)
		{
			int testAmount = i * powersOfTen[placeValue];
			if (number - testAmount < powersOfTen[placeValue]) // optimize by passing by ref and remembering the difference ?
			{
				return i;
			}
		}

		throw new Exception("I don't think I'll get here, will debug later.");
	}
}
