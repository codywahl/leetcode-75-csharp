namespace LeetCode75.Solutions.SlidingWindow;

public class Solution121
{
    public int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length < 2)
        {
            return 0; // Not enough data to make a profit
        }

        int maxProfit = 0;
        int buyingIndex = 0;
        int sellingIndex = 1;

        while (sellingIndex < prices.Length)
        {
            int buyingPrice = prices[buyingIndex];
            int sellingPrice = prices[sellingIndex];

            if (sellingPrice < buyingPrice)
            {
                buyingIndex = sellingIndex; // Update buying index if current selling price is lower

            }
            else
            {
                int profit = sellingPrice - buyingPrice;
                maxProfit = Math.Max(maxProfit, profit);
            }

            sellingIndex++; // Move to the next selling price
        }

        return maxProfit;
    }
}