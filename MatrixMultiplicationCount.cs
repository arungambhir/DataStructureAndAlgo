using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class MatrixMultiplicationCount
    {

        internal int MatrixMultiplicationDP(int[] arr, int n)
        {
            int[,] dp = new int[n, n];

            //j == i+1 return 0
            for (int i = 0; i < n - 1; i++) dp[i, i + 1] = 0;

            //i can't be greater than J.
            for (int gap = 2; gap < n; gap++)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    dp[i, j] = int.MaxValue;
                    for (int k = i + 1; k < j; k++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i, k] + dp[k, j] + arr[i] * arr[k] * arr[j]);
                    }
                }
            }
            return dp[0, n - 1];
        }

        //internal int MatrixMultiplicationDP(int[] arr, int n)
        //{
        //    int[,] dp = new int[n, n];

        //    //j == i+1 return 0
        //    for (int i = 0; i < n-1; i++) dp[i, i + 1] = 0;


        //    for (int gap = 2; gap < n; gap++)
        //    {
        //        for (int i = 0; i + gap < n; i++)
        //        {
        //            int j = i + gap;
        //            dp[i, j] = int.MaxValue;
        //            for (int k = i+1; k < j; k++)
        //            {
        //                dp[i, j] = Math.Min(dp[i, j], dp[i, k] + dp[k, j] + arr[i] * arr[k] * arr[j]);
        //            }
        //        }
        //    }
        //    return dp[0, n-1];
        //}
        internal int MatrixMultiplicationRec(int[] arr, int i, int j)
        {
            if (i + 1 == j) return 0;
            //if (j-i == 2) return arr[i] * arr[i+1] * arr[i+2];
            int res = int.MaxValue;

            for (int k = i + 1; k < j; k++)
            {
                res = Math.Min(res, MatrixMultiplicationRec(arr, i, k) + MatrixMultiplicationRec(arr, k, j) + arr[i] * arr[k] * arr[j]);
            }

            return res;
        }
    }
}
