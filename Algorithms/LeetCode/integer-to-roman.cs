namespace Algorithms.LeetCode
{
	public class integer_to_roman
	{
		public string IntToRoman(int num)
		{
			return RegularForm(num, string.Empty);
		}

		private string RegularForm(int num, string romanNumeral)
		{
			int subtractiveQuantity;
			char symbol;

			if (num == 0)
			{
				return romanNumeral;
			}
			else if (num >= 1000)
			{
				subtractiveQuantity = 1000;
				symbol = 'M';
			}
			else if (num >= 500)
			{
				subtractiveQuantity = 500;
				symbol = 'D';
			}
			else if (num >= 100)
			{
				subtractiveQuantity = 100;
				symbol = 'C';
			}
			else if (num >= 50)
			{
				subtractiveQuantity = 50;
				symbol = 'L';
			}
			else if (num >= 10)
			{
				subtractiveQuantity = 10;
				symbol = 'X';
			}
			else if (num >= 5)
			{
				subtractiveQuantity = 5;
				symbol = 'V';
			}
			else
			{
				throw new Exception("Flag A");
			}

			return RegularForm(num - subtractiveQuantity, romanNumeral + symbol);
		}
	}
}
