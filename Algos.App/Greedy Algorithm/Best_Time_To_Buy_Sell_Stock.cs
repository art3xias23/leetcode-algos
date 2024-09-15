using System.ComponentModel;

namespace Algos.Greedy_Algorithm
{
    internal class Best_Time_To_Buy_Sell_Stock
    {
        [Id(121)]
        [Category("GreedyAlgorithm")]
        public int MaxProfit(int[] prices)
        {
            var min = int.MaxValue;
            var profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                var currentProfit = prices[i] - min;
                profit = currentProfit > profit ? currentProfit : profit;

                min = min > prices[i] ? prices[i] : min;
            }
            return profit;
        }
    }
}
