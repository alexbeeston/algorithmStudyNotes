namespace Algorithms.LeetCode;

public class best_time_to_buy_and_sell_stock_ii
{
	public int MaxProfit(int[] prices)
	{
		if (prices.Length == 1)
		{
			return 0;
		}
		else
		{
			return Worker(prices, 0, 0, 0);
		}
	}

	private int Worker(int[] prices, int i, int lastBuy, int cummulitiveProfit) // prices
	{
		bool upOrSameTomorrow = prices[i + 1] >= prices[i];
		if (i == prices.Length - 2)
		{
			int lastSell = i;
			if (upOrSameTomorrow)
			{
				lastBuy = lastBuy == -1 ? i : lastBuy;
				lastSell = i + 1;
			}
			else if (lastBuy == -1)
			{
				lastBuy = i;
			}

			cummulitiveProfit += prices[lastSell] - prices[lastBuy];
			return cummulitiveProfit;
		}

		if (upOrSameTomorrow)
		{
			lastBuy = lastBuy == -1 ? i : lastBuy;
			return Worker(prices, i + 1, lastBuy, cummulitiveProfit);
		}
		else
		{
			if (lastBuy != -1)
			{
				cummulitiveProfit += prices[i] - prices[lastBuy];
			}

			return Worker(prices, i + 1, -1, cummulitiveProfit);
		}
	}
}
