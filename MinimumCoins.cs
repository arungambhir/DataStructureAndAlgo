using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class MinimumCoins
    {

        public long minimumNumberOfCoins(int[] coins, int numberOfCoins, int value)
        {
            int[] dp = new int[value + 1];
            dp[0] = 0;

            for (int i = 1; i <= value; i++)
            {
                dp[i] = int.MaxValue;
                for (int j = 0; j < numberOfCoins; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }
            return dp[value];
            // your code here
        }

    }
}
