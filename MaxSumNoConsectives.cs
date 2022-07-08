using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class MaxSumNoConsectives
    {
        internal int MaxSumDP(int[] arr, int n)
        {
            int[] dp = new int[n];
            dp[0] = arr[0];
            dp[1] = Math.Max(arr[0], arr[1]);

            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], arr[i] + dp[i - 2]);
            }

            return dp[n - 1];
        }

        internal int MaxSum(int[] arr, int n)
        {
            if (n == 1) return arr[0];
            if (n == 2) return Math.Max(arr[0], arr[1]);

            return Math.Max(MaxSum(arr, n - 1), MaxSum(arr, n - 2) + arr[n - 1]);
        }
    }
}
