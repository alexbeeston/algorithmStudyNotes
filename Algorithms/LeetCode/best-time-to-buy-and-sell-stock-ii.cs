namespace Algorithms.LeetCode;

public class best_time_to_buy_and_sell_stock_ii
{
	public int MaxProfit(int[] prices)
	{
		if (prices.Length == 1)
		{
			return 0;
		}
		else if (prices.Length == 2)
		{
			return Math.Max(0, prices[1] - prices[0]);
		}
		else
		{
			return Worker(prices, 1, 0, 0);
		}
	}

	private int Worker(int[] prices, int i, int lastBuy, int cummulitiveProfit) // prices
	{
		if (i == prices.Length - 2) // on penultimate
		{
			if (prices[i + 1] >= prices[i]) //  last day is greater than or eq penultimate
			{
				lastBuy = lastBuy == -1 ? i : lastBuy;
				return cummulitiveProfit + prices[i + 1] - prices[lastBuy];
			}
			else
			{
				if (lastBuy != -1)
				{
					cummulitiveProfit += prices[i] - prices[lastBuy];
				}

				return cummulitiveProfit;
			}
		}

		bool upFromYesterday = prices[i] > prices[i - 1];
		bool sameAsYesterday = prices[i] == prices[i - 1];
		bool upTomorrow = prices[i + 1] > prices[i];
		bool sameTomorrow = prices[i + 1] == prices[i];

		if (upFromYesterday)
		{
			if (upTomorrow || sameTomorrow)
			{
				return Worker(prices, i + 1, lastBuy, cummulitiveProfit);
			}
			else
			{
				cummulitiveProfit += prices[i] - prices[lastBuy];
				return Worker(prices, i + 1, -1, cummulitiveProfit);
			}
		}
		else if (sameAsYesterday)
		{
			if (upTomorrow)
			{
				return Worker(prices, i + 1, i, cummulitiveProfit);
			}
			else
			{
				return Worker(prices, i + 1, -1, cummulitiveProfit);
			}
		}
		else
		{
			if (upTomorrow)
			{
				return Worker(prices, i + 1, i, cummulitiveProfit);
			}
			else
			{
				return Worker(prices, i + 1, -1, cummulitiveProfit);
			}
		}
	}
}
