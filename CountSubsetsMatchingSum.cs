using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class CountSubsetsMatchingSum
    {
        internal int CountSubsetRecursion(int[] arr, int n, int sum)
        {
            if (n == 0)
                return (sum == 0) ? 1 : 0;

            return CountSubsetRecursion(arr, n - 1, sum) +
                   CountSubsetRecursion(arr, n - 1, sum - arr[n - 1]);
        }

        internal int CountSubsetDP(int[] arr, int n, int sum)
        {
            int[,] dp = new int[n + 1, sum + 1];

            //if sum is zero, then there is only one subset {}.
            for (int i = 0; i <= n; i++) { dp[i, 0] = 1; }
            //if n == 0 & sum not zero then there is no subset.
            for (int i = 1; i <= sum; i++) { dp[0, i] = 0; }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    //2 cases include ith element or not, include only if  sum is greater that number
                    if (j >= arr[i - 1])
                    { dp[i, j] = dp[i - 1, j] + dp[i - 1, j - arr[i - 1]]; }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }

                }
            }
            return dp[n, sum];
        }
    }
}
