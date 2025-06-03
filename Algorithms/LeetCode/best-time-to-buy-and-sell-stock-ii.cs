namespace Algorithms.LeetCode
{
    public class best_time_to_buy_and_sell_stock_ii
    {
        public int MaxProfit(int[] prices)
        {
            int[] maxProfits = new int[prices.Length];
            return Worker(prices, maxProfits, prices.Length - 1);
        }

        public int Worker(int[] prices, int[] maxProfit, int currentDay)
        {
            int currentMaxProfit = 0;
            for (int i = currentDay; i < prices.Length; i++)
            {
                int candidateMaxProfit = Math.Max(0, prices[i] - prices[currentDay]);
                if (i < prices.Length - 1)
                {
                    candidateMaxProfit += maxProfit[i + 1];
                }

                currentMaxProfit = Math.Max(currentMaxProfit, candidateMaxProfit);
            }

            if (currentDay == 0)
            {
                return currentMaxProfit;
            }
            else
            {
                maxProfit[currentDay] = currentMaxProfit;
                return Worker(prices, maxProfit, currentDay - 1);
            }
        }
    }
}
