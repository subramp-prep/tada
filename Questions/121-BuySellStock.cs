using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

    // Say you have an array for which the ith element is the price of a given stock on day i.
    // If you were only permitted to complete at most one transaction(ie, buy one and sell one share of the stock), 
    // design an algorithm to find the maximum profit.

    //Example 1:
    //Input: [7, 1, 5, 3, 6, 4]
    //Output: 5

    //max.difference = 6 - 1 = 5(not 7 - 1 = 6, as selling price needs to be larger than buying price)
    //Example 2:
    //Input: [7, 6, 4, 3, 1]
    //Output: 0
    //In this case, no transaction is done, i.e.max profit = 0.

    public class BuySellStock
    {
        // Follows Kadane's algorithm
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minValue = int.MaxValue;

            for (int index = 0; index < prices.Length; index++)
            {
                minValue = Math.Min(minValue, prices[index]);

                maxProfit = Math.Max(maxProfit, prices[index] - minValue);
            }

            return maxProfit;
        } 

        // Minor optimization compared to the above solution
        public static int MaxProfit_Optimum(int[] prices)
        {
            if (prices == null || prices.Length < 2)
            {
                return 0;
            }

            int maxProfit = 0;
            int minValue = int.MaxValue;

            for (int index = 1; index < prices.Length; index++)
            {
                if (prices[index] < prices[index - 1])
                {
                    minValue = Math.Min(minValue, prices[index]);
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, prices[index] - minValue);
                }
            }

            return maxProfit;
        } 
    }
}
