public class MaxProfitSln {
    public int MaxProfit(int[] prices)
    {
        var buy = 0;
        var sell = 1;
        var maxProfit = 0;

        while (sell < prices.Length)
        {
            if (prices[buy] < prices[sell])
            {
                var profit = prices[sell] - prices[buy];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                buy = sell;
            }

            sell++;
        }

        return maxProfit;
    }
}
