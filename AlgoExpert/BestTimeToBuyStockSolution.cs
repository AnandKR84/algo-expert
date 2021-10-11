// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

using System;

namespace AlgoExpert 
{
    public class BestTimeToBuyStockSolution
    {
        /// Brute force technique. Highest complexity 
        //public int MaxProfit(int[] prices)
        //{
        //    int maxProfit = 0;
        //    for (int i = 0; i < prices.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < prices.Length; j++)
        //        {
        //            if (prices[i] < prices[j] &&
        //                (prices[j] - prices[i]) > maxProfit)
        //            {
        //                maxProfit = prices[j] - prices[i];
        //            }
        //        }
        //    }
        //    return maxProfit;
        //}


        public int MaxProfit(int[] prices)
        {
            int minPricePos = 0, maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] - prices[minPricePos] > maxProfit)
                    maxProfit = prices[i] - prices[minPricePos];
                else if (prices[i] - prices[minPricePos] < 0)
                    minPricePos = i;
            }
            return maxProfit;
        }
    }
}