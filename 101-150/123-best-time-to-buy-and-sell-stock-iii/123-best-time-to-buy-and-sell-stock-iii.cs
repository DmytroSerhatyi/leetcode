public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int buy1 = int.MaxValue;
        int buy2 = int.MaxValue;
        int sell1 = 0;
        int sell2 = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            int price = prices[i];

            buy1 = Math.Min(buy1, price);
            sell1 = Math.Max(sell1, price - buy1);
            buy2 = Math.Min(buy2, price - sell1);
            sell2 = Math.Max(sell2, price - buy2);
        }

        return sell2;
    }
}
