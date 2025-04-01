namespace Algorithms.LeetCode
{
	public class integer_to_roman
	{
		public string IntToRoman(int num)
		{
			return Helper(num, string.Empty);
		}

		private string Helper(int num, string romanNumeral)
		{
			int subtractiveQuantity;
			string symbol;

			if (num >= 4000)
			{
				throw new Exception("Positive out of range");
			}
			else if (num >= 1000)
			{
				subtractiveQuantity = 1000;
				symbol = "M";
			}
			else if (num >= 900)
			{
				subtractiveQuantity = 900;
				symbol = "CM";
			}
			else if (num >= 500)
			{
				subtractiveQuantity = 500;
				symbol = "D";
			}
			else if (num >= 400)
			{
				subtractiveQuantity = 400;
				symbol = "CD";
			}
			else if (num >= 100)
			{
				subtractiveQuantity = 100;
				symbol = "C";
			}
			else if (num >= 90)
			{
				subtractiveQuantity = 90;
				symbol = "XC";
			}
			else if (num >= 50)
			{
				subtractiveQuantity = 50;
				symbol = "L";
			}
			else if (num >= 40)
			{
				subtractiveQuantity = 40;
				symbol = "XL";
			}
			else if (num >= 10)
			{
				subtractiveQuantity = 10;
				symbol = "X";
			}
			else if (num == 9)
			{
				subtractiveQuantity = 9;
				symbol = "IX";
			}
			else if (num >= 5)
			{
				subtractiveQuantity = 5;
				symbol = "V";
			}
			else if (num == 4)
			{
				subtractiveQuantity = 4;
				symbol = "IV";
			}
			else if (num > 0)
			{
				subtractiveQuantity = 1;
				symbol = "I";
			}
			else if (num == 0)
			{
				return romanNumeral;
			}
			else
			{
				throw new Exception("Negative out of range");
			}

			return Helper(num - subtractiveQuantity, romanNumeral + symbol);
		}
	}
}
