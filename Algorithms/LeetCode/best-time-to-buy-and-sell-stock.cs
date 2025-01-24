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
		int left = 0;
		int right = 0;
		int maxProfit = 0;
		for (int i = 0; i < prices.Length; i++)
		{
			if (prices[i] > prices[right])
			{
				right = i;
			}
			else if (prices[i] < prices[left])
			{
				maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
				left = i;
				right = i;
			}
		}

		return Math.Max(maxProfit, prices[right] - prices[left]);
	}
}
