using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class ReachGivenScoreOrCoinSum
    {

        internal int DistinctCount(int n)
        {
            //string s = "124";
            //long b = Convert.ToInt64(s);

            int[] arr = new int[] { 3, 5, 10 };
            int len = arr.Length;

            int[,] dp = new int[n + 1, len + 1];

            for (int i = 0; i <= len; i++) dp[0, i] = 1;
            for (int i = 1; i <= n; i++) dp[i, 0] = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= len; j++)
                {
                    dp[i, j] = dp[i, j-1];
                    if (arr[j-1] <= i)
                    {
                        dp[i, j] += dp[i - arr[j-1], j];
                    }
                }
            
            }
            return dp[n, len];

        }
    }
}
