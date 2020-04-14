public class Solution
{
    public int MaxProfit(int k, int[] prices)
    {
        int length = prices.Length;

        if (k >= length / 2)
        {
            int profit = 0;

            for (int i = 1; i < length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }

        int[,] dp = new int[k + 1, length];

        for (int i = 1; i <= k; i++)
        {
            int temp = -prices[0];

            for (int j = 1; j < length; j++)
            {
                dp[i, j] = Math.Max(dp[i, j - 1], prices[j] + temp);
                temp = Math.Max(temp, dp[i - 1, j - 1] - prices[j]);
            }
        }

        return dp[k, length - 1];
    }
}
