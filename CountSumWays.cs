using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class CountSumWays
    {
        internal int CountWays(int n)
        {
            // your code here
            int[] dp = new int[n + 1];
            dp[0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    dp[j] += dp[j - i];
                }
            }

            return dp[n];
        }


        //There are n stairs, a person standing at the bottom wants to reach the top.
        //The person can climb either 1 stair or 2 stairs at a time.
        //Count the number of ways, the person can reach the top (order does matter).
        public int countWays(int n)
        {
            int res = 0, temp = 0;
            int last = 2;
            int secondLast = 1;

            if (n == 1) return secondLast;
            if (n == 2) return last;
            //Your Code Here

            for (int i = 3; i <= n; i++)
            {
                temp = last + secondLast;
                secondLast = last;
                last = temp;
                res = temp;

            }

            return res % 1000000007;
        }
    }
}
