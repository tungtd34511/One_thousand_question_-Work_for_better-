﻿int MaxProfit(int[] prices)
{
    int max = 0;
    for (int i = 0; i < prices.Length - 1; i++)
    {
        for (int j = i + 1; j < prices.Length; j++)
        {
            int res = prices[j] - prices[i];
            if (res > max)
            {
                max = res;
            }
        }
    }
    return max;
}
Console.Write(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));