using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int buy_price = prices[0];
            int profit = 0;

            foreach (var price in prices)
            {
                if (buy_price > price)
                {
                    buy_price = price;
                }

                profit = Math.Max(profit, price - buy_price);

            }

            return profit;
        }
    }
}
