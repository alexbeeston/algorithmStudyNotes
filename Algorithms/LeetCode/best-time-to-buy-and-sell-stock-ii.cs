namespace Algorithms.LeetCode
{
    public class best_time_to_buy_and_sell_stock_ii
    {
        public int MaxProfit(int[] prices)
        {
            int[] maxProfits = new int[prices.Length];
            return Worker(prices, maxProfits, prices.Length - 2);

        }

        public int Worker(int[] prices, int[] maxProfit, int i)
        {
            int currentMaxProfit = 0;
            for (int j = i + 1; j < prices.Length; j++)
            {
                int candidateMaxProfit = prices[j] - prices[i];
                if (j < prices.Length - 1)
                {
                    candidateMaxProfit += maxProfit[j + 1];
                }
                currentMaxProfit = Math.Max(currentMaxProfit, candidateMaxProfit);
            }

            if (i == 0)
            {
                return currentMaxProfit;
            }
            else
            {
                maxProfit[i] = currentMaxProfit;
                return Worker(prices, maxProfit, i - 1);
            }
        }
    }
}
