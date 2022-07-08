using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class BSTCount
    {
        internal int BSTCountDP(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                dp[i] = 0;
                for (int j = 0; j < i; j++)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                
                }
            }
            return dp[n];
        }
        internal int BSTCountR(int n)
        {
            int res = 0 ;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    res += (BSTCountRec(j) * BSTCountRec(i - j - 1));
                }
            }

            return res;
        
        }

        internal int BSTCountRec(int n)
        { int ret = 0;
            if (n == 0 ||  n == 1)
                return 1;
            if (n == 2) return 2;

            ret += BSTCountRec(n - 1);
            return ret;
        }

    }
}
