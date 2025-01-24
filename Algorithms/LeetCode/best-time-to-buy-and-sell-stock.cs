using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

public class best_time_to_buy_and_sell_stock
{
	public int MaxProfit(int[] prices)
	{
		int maxProfit = 0;
		for (int i = 0; i < prices.Length - 1; i++)
		{
			for (int j = i + 1; j < prices.Length; j++)
			{
				maxProfit = Math.Max(maxProfit, prices[j] - prices[i]);

			}
		}

		return maxProfit;
	}
}
