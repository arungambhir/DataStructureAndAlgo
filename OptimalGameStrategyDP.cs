using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class OptimalGameStrategyDP
    {

        public int OptimalGameStrategyRec(int[] arr, int i, int j)
        {
            //base condition when there are only 2 values.
            if (i + 1 == j)
                return Math.Max(arr[i], arr[j]);

            //pick the max you choose & min what opponent choose for you in his turn.
            return Math.Max(arr[i] + Math.Min(OptimalGameStrategyRec(arr, i + 2, j), OptimalGameStrategyRec(arr, i + 1, j - 1)),
                            arr[j] + Math.Min(OptimalGameStrategyRec(arr, i + 1, j - 1), OptimalGameStrategyRec(arr, i, j - 2)));
        }


        public int OptimalGameStrategy(int[] arr, int n)
        {
            //base condition when there are only 2 values.
            int[,] dp = new int[n, n];
            for (int i = 0; i < n-1; i++)
            {
                dp[i, i + 1] = Math.Max(arr[i], arr[i + 1]);
            }
            /*
             * 0    1   2   3   4   5
            0       X       X       X
            1           X       X   
            2               X       X
            3                   X
            4                       X
            5
             * 
             */
            for (int gap = 3; gap < n; gap+= 2)
            {
                for (int i = 0; i + gap < n; i++)
                {
                   int j = i + gap;
                    dp[i, j] = Math.Max(arr[i] + Math.Min(dp[i + 2, j], dp[i + 1, j - 1]),
                                        arr[j] + Math.Min(dp[i + 1, j - 1], dp[i, j - 2]));
                }
            }
            return dp[0, n-1];
        }


    }

}
